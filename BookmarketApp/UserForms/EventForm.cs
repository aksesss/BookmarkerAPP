﻿using System;
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
    public partial class EventForm : MetroForm
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

            DataTable dt = new DataTable();
            dt = TransactionScripts.getAllEvents();
            eventGridView1.DataSource = dt;
        }
        private void findEventById_Click(object sender, EventArgs e)
        {
            eventGridView1.DataSource = TransactionScripts.getEventById(Convert.ToInt32(eventID_txtBox.Text));
        }
        private void createEvent_btn_Click(object sender, EventArgs e)
        {
            CreateEventForm crEv = new CreateEventForm(this, 0, false);
            crEv.Show();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int p;
            try
            {
                p = Convert.ToInt32(eventGridView1[0, eventGridView1.CurrentRow.Index].Value.ToString());
                //p = Convert.ToInt32(eventGridView1.SelectedRows[0].ToString());
            }
            catch (Exception)
            {
                p = 0;
            }
            CreateEventForm ueF = new CreateEventForm(this, p, p != 0);
            ueF.Show();
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(eventGridView1[0, eventGridView1.CurrentRow.Index].Value.ToString());
            TransactionScripts.deleteEvent(p);
            refresh_btn.PerformClick();
        }



        private void showUsers_btn_Click(object sender, EventArgs e)
        {
            eventGridView1.DataSource = TransactionScripts.getAllUsers();
            //dataGridView1.DataSource = Users.showAll();
            createEvent_btn.Visible = false;
            delete_btn.Visible = false;
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



        private void eventGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.eventGridView1.Rows[e.RowIndex];
                //debug_txtBox.Text = row.Cells[0].Value.ToString();
                try
                {
                    int p = int.Parse(row.Cells[0].Value.ToString());
                    TransactionScripts.updateEvent(p,
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString());
                }
                catch (FormatException ex)
                {
                }

                //Name_txt.Text = row.Cells["First Name"].Value.ToString();
                //Surname_txt.Text = row.Cells["Last Name"].Value.ToString();
            }

        }
        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        private void updateBetType_btn_Click(object sender, EventArgs e)
        {
            betType_GridView.DataSource = BetType.showAll();
        }


        private void users_refresh_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = TransactionScripts.getAllUsers();
            userGridView.DataSource = dt;
        }


        private void betType_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.betType_GridView.Rows[e.RowIndex];
                debug_txtBox.Text = row.Cells[0].Value.ToString();
                try
                {
                    int p = int.Parse(row.Cells[1].Value.ToString());
                    Event ev = new Event(p);
                    ev_name_lbl.Text = ev.name;
                    ev_date_lbl.Text = ev.date.ToString();
                    ev_place_lbl.Text = ev.place.ToString();
                    ev_type_lbl.Text = ev.type.ToString();
                }
                catch (FormatException ex)
                {
                    ev_name_lbl.Text = "";
                    ev_date_lbl.Text = "";
                    ev_place_lbl.Text = "";
                    ev_type_lbl.Text = "";
                }

                //Name_txt.Text = row.Cells["First Name"].Value.ToString();
                //Surname_txt.Text = row.Cells["Last Name"].Value.ToString();
            }
        }

        private void betType_GridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.betType_GridView.Rows[e.RowIndex];
                debug_txtBox.Text = row.Cells[0].Value.ToString();
                try
                {
                    int p = int.Parse(row.Cells[1].Value.ToString());
                    Event ev = new Event(p);
                    ev_name_lbl.Text = ev.name;
                    ev_date_lbl.Text = ev.date.ToString();
                    ev_place_lbl.Text = ev.place.ToString();
                    ev_type_lbl.Text = ev.type.ToString();
                }
                catch (FormatException ex)
                {
                    ev_name_lbl.Text = "";
                    ev_date_lbl.Text = "";
                    ev_place_lbl.Text = "";
                    ev_type_lbl.Text = "";
                }
            }
        }
    }
}
