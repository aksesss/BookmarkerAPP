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
    public partial class CreateEventForm : Form
    {
        //private EventForm mainF;
        public CreateEventForm()
        {
            InitializeComponent();
          //  mainF.Hide();
        }

        private void createEvent_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(type_txtBox.Text) &&
                !string.IsNullOrWhiteSpace(place_txtBox.Text) &&
                !string.IsNullOrWhiteSpace(date_txtBox.Text) &&
                !string.IsNullOrWhiteSpace(time_txtBox.Text))
            {

                Error res = TransactionScripts.createEvent(type_txtBox.Text, place_txtBox.Text,
                                                           date_txtBox.Text, time_txtBox.Text);
                if (!res.error)
                {
                    this.Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                        res.message,
                        "Проверьте корректность введенных данных",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
            }
        }



        private void CreateEventForm_Load(object sender, EventArgs e)
        {

        }
        private void CreateEventForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //mainF.Show();
        }
    }
}
