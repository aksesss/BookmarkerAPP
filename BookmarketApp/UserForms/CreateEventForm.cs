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
        private bool update;
        private Event event_;
        private EventForm mainF;
        public CreateEventForm(EventForm mainForm, int id, bool update)
        {
            InitializeComponent();
            this.update = update;
            mainF = mainForm;
            if (update)
            {
                event_ = new Event(id);
                //id_txtBox.Text = event_.id.ToString();

                name_txtBox.Text = event_.name;
                type_txtBox.Text = event_.type;
                place_txtBox.Text = event_.place;
                date_txtBox.Text = event_.date.ToString("yyyy-MM-dd");
                time_txtBox.Text = event_.date.ToString("HH:mm");
            }
            //InitializeComponent();

        }

        private void createEvent_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(name_txtBox.Text) &&
                !string.IsNullOrWhiteSpace(type_txtBox.Text) &&
                !string.IsNullOrWhiteSpace(place_txtBox.Text) &&
                !string.IsNullOrWhiteSpace(date_txtBox.Text) &&
                !string.IsNullOrWhiteSpace(time_txtBox.Text))
            {
                Error res = new Error();
                if (!update)
                {
                    res = TransactionScripts.createEvent(name_txtBox.Text,
                                                               type_txtBox.Text, place_txtBox.Text,
                                                               date_txtBox.Text, time_txtBox.Text);
                }
                else
                {
                    res = TransactionScripts.updateEvent(event_, name_txtBox.Text,
                                                               type_txtBox.Text, place_txtBox.Text,
                                                               date_txtBox.Text, time_txtBox.Text);
                }
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
