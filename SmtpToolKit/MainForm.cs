using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmtpToolKit
{
    public partial class MainForm : Form
    {
        Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        List<string> ccEmails;
        List<string> bccEmails;
        public MainForm()
        {
            InitializeComponent();

            ccEmails = new List<string>();
            bccEmails = new List<string>();
        }


        private void ClearForm()
        {
            txtEmailFrom.Text = txtEmailTo.Text = txtEmailBody.Text = string.Empty;
            ccEmails = new List<string>();
            bccEmails = new List<string>();

            dgvCC.Rows.Clear();
            dgvCC.Refresh();

            dgvBCC.Rows.Clear();
            dgvBCC.Refresh();
        }

        private bool ValidateForm()
        {
            lblErrSMTP.Visible = lblErrPort.Visible = lblErrUsername.Visible = lblErrPassword.Visible = lblErrEmailFrom.Visible = lblErrEmailTo.Visible = lblErrEmailBody.Visible = false;
            lblErrSMTP.Text = lblErrPort.Text = lblErrUsername.Text = lblErrPassword.Text = lblErrEmailFrom.Text = lblErrEmailTo.Text = lblErrEmailBody.Text = "Required";

            bool isValid = true;

            #region SMTP server
            if (string.IsNullOrWhiteSpace(txtSmtpServer.Text))
            {
                isValid = false;
                lblErrSMTP.Visible = true;
            }
            #endregion

            #region Port
            //if (string.IsNullOrWhiteSpace(.Text))
            //{
            //    isValid = false;
            //    lblErrSMTP.Visible = true;
            //}
            #endregion

            #region Authentication Credentials

            if (chkAuthentication.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    isValid = false;
                    lblErrUsername.Visible = true;
                }
                else if (!RegexValidation(txtUsername.Text.Trim(), emailRegex))
                {
                    isValid = false;
                    lblErrUsername.Visible = true;
                    lblErrUsername.Text = "Invalid";
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    isValid = false;
                    lblErrPassword.Visible = true;
                }
            }
            #endregion

            #region Email From
            if (string.IsNullOrWhiteSpace(txtEmailFrom.Text))
            {
                isValid = false;
                lblErrEmailFrom.Visible = true;
            }
            else if (!RegexValidation(txtEmailFrom.Text.Trim(), emailRegex))
            {
                isValid = false;
                lblErrEmailFrom.Visible = true;
                lblErrEmailFrom.Text = "Invalid";
            }
            #endregion

            #region Email To
            if (string.IsNullOrWhiteSpace(txtEmailTo.Text))
            {
                isValid = false;
                lblErrEmailTo.Visible = true;
            }
            else if (!RegexValidation(txtEmailTo.Text.Trim(), emailRegex))
            {
                isValid = false;
                lblErrEmailTo.Visible = true;
                lblErrEmailTo.Text = "Invalid";
            }
            #endregion

            #region Email Body
            if (string.IsNullOrWhiteSpace(txtEmailBody.Text))
            {
                isValid = false;
                lblErrEmailBody.Visible = true;
            }
            #endregion

            return isValid;
        }

        private bool RegexValidation(string text, Regex regex)
        {
            Match match = regex.Match(text);
            return match.Success;
        }


        private void chkAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            gbxCredentials.Visible = chkAuthentication.Checked;
            lblErrUsername.Visible = lblErrPassword.Visible = false;
            lblErrUsername.Text = lblErrPassword.Text = "Required";
            txtUsername.Text = txtPassword.Text = string.Empty;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Create and build a new MailMessage object
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(txtEmailFrom.Text.Trim());
                message.To.Add(new MailAddress(txtEmailTo.Text.Trim()));
                message.Subject = "SMPT Toolkit Text Mail";
                message.Body = txtEmailBody.Text.Trim();
                message.BodyEncoding = Encoding.UTF8;

                if (ccEmails.Count > 0)
                {
                    foreach (string email in ccEmails)
                    {
                        message.CC.Add(new MailAddress(email));
                    }
                }

                if (bccEmails.Count > 0)
                {
                    foreach (string email in bccEmails)
                    {
                        message.Bcc.Add(new MailAddress(email));
                    }
                }

                using (var client = new SmtpClient(txtSmtpServer.Text.Trim(), Convert.ToInt16(nudPort.Value)))
                {
                    client.EnableSsl = chkSSL.Checked;

                    if (chkAuthentication.Checked)
                    {
                        client.Credentials = new NetworkCredential(txtUsername.Text.Trim(), txtPassword.Text);
                    }

                    try
                    {
                        client.Send(message);

                        client.Dispose();
                        ClearForm();
                        MessageBox.Show("Mail Sent");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Email Not Sent!! exception : " + ex.Message);
                    }


                }
            }
        }

        private void btnAddCC_Click(object sender, EventArgs e)
        {
            using (MailAddForm frm = new MailAddForm(AddCCItem))
            {
                frm.ShowDialog();
            }
        }

        private void AddCCItem(string email)
        {
            int index = dgvCC.Rows.Add();
            dgvCC.Rows[index].Cells[0].Value = email;

            ccEmails.Add(email);
        }

        private void AddBCCItem(string email)
        {
            int index = dgvBCC.Rows.Add();
            dgvBCC.Rows[index].Cells[0].Value = email;

            bccEmails.Add(email);
        }

        private void dgvCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView ccGrid = sender as DataGridView;

            if (e.RowIndex > -1)
            {
                if (ccGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                {
                    DataGridViewRow clickedRow = ccGrid.Rows[e.RowIndex];

                    string email = clickedRow.Cells["colCcEmail"].Value.ToString();

                    ccGrid.Rows.Remove(clickedRow);

                    ccEmails.Remove(email);
                }
            }

        }

        private void btnAddBCC_Click(object sender, EventArgs e)
        {
            using (MailAddForm frm = new MailAddForm(AddBCCItem))
            {
                frm.ShowDialog();
            }
        }

        private void dgvBCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView bccGrid = sender as DataGridView;

            if (e.RowIndex > -1)
            {
                if (bccGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                {
                    DataGridViewRow clickedRow = bccGrid.Rows[e.RowIndex];

                    string email = clickedRow.Cells["colBccEmail"].Value.ToString();

                    bccGrid.Rows.Remove(clickedRow);

                    bccEmails.Remove(email);
                }
            }
        }
    }
}
