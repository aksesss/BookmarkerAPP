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
    public partial class UpdateEventForm : Form
    {
        private Event event_;
        private EventForm mainF;
        public UpdateEventForm(EventForm mainForm, int id)
        {
            InitializeComponent();
            mainF = mainForm;
            event_ = new Event(id);
            id_txtBox.Text = event_.id.ToString();
            type_txtBox.Text = event_.type;
            place_txtBox.Text = event_.place;
            date_txtBox.Text = event_.date.ToString("yyyy-MM-dd");
            time_txtBox.Text = event_.date.ToString("HH:mm");
        }

        private void UpdateEventForm_Load(object sender, EventArgs e)
        {

        }

        private void updateEvent_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(type_txtBox.Text) &&
                !string.IsNullOrWhiteSpace(place_txtBox.Text) &&
                !string.IsNullOrWhiteSpace(date_txtBox.Text) &&
                !string.IsNullOrWhiteSpace(time_txtBox.Text))
            {
                Error res = TransactionScripts.updateEvent(event_, type_txtBox.Text, place_txtBox.Text,
                                                           date_txtBox.Text, time_txtBox.Text);
                if (!res.error)
                {
                    mainF.update();
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

    }
}
