using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace BookmarketApp
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(login_txtBox.Text) &&
                !string.IsNullOrWhiteSpace(password_txtBox.Text))
            {
                Error res = TransactionScripts.auth(login_txtBox.Text, password_txtBox.Text);
                if (!res.error)
                {
                    EventForm ef = new EventForm(new User(login_txtBox.Text), this);
                    ef.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                        res.message,
                        "Не успешно",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
            }
        }
        private void registrationFormShow_Click(object sender, EventArgs e)
        {
            RegistrationForm regF = new RegistrationForm(this);
            this.Hide();
            regF.Show();
        }
        


        private void test_btn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

        }
        private void debug_Click(object sender, EventArgs e)
        {
            test_hash.Text = encryption.HashPassword(password_txtBox.Text);
        }


        private void password_txtBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
