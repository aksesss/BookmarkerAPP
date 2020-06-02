using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookmarketApp
{
    public partial class RegistrationForm : Form
    {
        private MainForm authForm;

        public RegistrationForm(MainForm authf)
        {
            authForm = authf;
            InitializeComponent();
            //List<TextBox> textBoxes;
            //textBoxes = new List<TextBox>() { login_txtBox, fnane_txtBtn, lname_txtBtn, email_txtBtn, password_txtBtn };
        }

        private void registrate_btn_Click(object sender, EventArgs e)
        {
            //label2.Text = encryption.VerifyHashedPassword(hash, password_txtBtn.Text).ToString();
            if (!string.IsNullOrWhiteSpace(email_txtBtn.Text) &&
                !string.IsNullOrWhiteSpace(fnane_txtBtn.Text) &&
                !string.IsNullOrWhiteSpace(lname_txtBtn.Text) &&
                !string.IsNullOrWhiteSpace(login_txtBox.Text) &&
                !string.IsNullOrWhiteSpace(password_txtBtn.Text))
            {
                Error res = TransactionScripts.createUser(login_txtBox.Text, fnane_txtBtn.Text, lname_txtBtn.Text,
                                              email_txtBtn.Text, password_txtBtn.Text);
                if (!res.error)
                {
                    DialogResult result = MessageBox.Show(
                        res.message,
                        "Успешно",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);

                    authForm.Show();
                    this.Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                        res.message,
                        "Не успешно",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
