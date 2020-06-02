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
    public partial class EventForm : Form
    {
        private MainForm authForm;
        private User this_user;

        public EventForm(User us, MainForm mnF)
        {
            InitializeComponent();
            this_user = us;
            authForm = mnF;

            if (this_user.isSuperUser())
            {
                createEvent_btn.Visible = true;
                showUsers_btn.Visible = true;
                delete_btn.Visible = true;
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            if (this_user.isSuperUser())
            {
                createEvent_btn.Visible = true;
                delete_btn.Visible = true;
            }

            DataTable dt = TransactionScripts.getAllEvents();
            dataGridView1.DataSource = dt;
        }
        private void findEventById_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TransactionScripts.getEventById(Convert.ToInt32(eventID_txtBox.Text));
        }
        private void createEvent_btn_Click(object sender, EventArgs e)
        {
            CreateEventForm crEv = new CreateEventForm(this, 0, false);
            crEv.Show();
        }
        private void showUsers_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TransactionScripts.getAllUsers();
            //dataGridView1.DataSource = Users.showAll();
            createEvent_btn.Visible = false;
            delete_btn.Visible = false;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int p;
            try
            {
                p = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            }
            catch (Exception)
            {
                p = 0;
            }
            CreateEventForm ueF = new CreateEventForm(this, p, p!=0);
            ueF.Show();
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            TransactionScripts.deleteEvent(p);
            refresh_btn.PerformClick();
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            authForm.Show();
            this.Close();
        }


        public void update()
        {
            refresh_btn.PerformClick();
        }



        private void EventForm_Load(object sender, EventArgs e)
        {

        }

    }
}
