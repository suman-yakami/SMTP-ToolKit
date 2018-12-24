using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmtpToolKit
{
    public partial class MailAddForm : Form
    {
        Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        Action<string> action_AddEmail;

        public MailAddForm()
        {
            InitializeComponent();
        }

        public MailAddForm(Action<string> _addEmailAction)
        {
            InitializeComponent();
            action_AddEmail = _addEmailAction;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                action_AddEmail(txtEmail.Text.Trim());
                txtEmail.Text = string.Empty;
            }
        }

        private bool ValidateForm()
        {
            lblErrEmail.Visible = false;
            lblErrEmail.Text = "Required";

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                isValid = false;
                lblErrEmail.Visible = true;
            }
            else if (!RegexValidation())
            {
                isValid = false;
                lblErrEmail.Visible = true;
                lblErrEmail.Text = "Invalid email";
            }

            return isValid;
        }

        private bool RegexValidation()
        {
            Match match = emailRegex.Match(txtEmail.Text.Trim());
            return match.Success;
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(null, null);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
