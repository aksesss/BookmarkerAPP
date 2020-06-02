using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace BookmarketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

// SqlConnection con = new DBConnection().con;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private void fillData_Click(object sender, EventArgs e)
        {
            string connection_str = "Server=localhost;User Id=postgres;" +
                        "Password=785941828;Database=lab1_chAA";
            NpgsqlConnection conn = new NpgsqlConnection(connection_str);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM \"Events\"";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
            }
            finally
            {
                conn.Close();
            }



            //DataTable dt = Users.showAll();
            //dataGridView1.DataSource = dt;

            //DataTable dt1 = Test.showAll();
            //dataGridView2.DataSource = dt1;

            //dataGridView2.DataSource = TransactionScripts.getAllUsers();
        }

    private void showFormCreateEvent_btn_Click(object sender, EventArgs e)
        {
            CreateEventForm cef = new CreateEventForm();
            cef.Show();
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            //debug_lbl.Text = dataGridView1.Rows[1].ToString();
            DateTime dtime;
            DateTime.TryParse(
                "2012-12-13 15:20",
                System.Globalization.CultureInfo.CurrentCulture,
                System.Globalization.DateTimeStyles.AssumeLocal,
                out dtime
            );
            debug_lbl.Text = dtime.ToString("yyyy-MM-dd HH:mm");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int p = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            debug_lbl.Text = p.ToString();
            // debug_lbl.Text = dataGridView1.SelectedCells[0].Value.ToString();
            //debug_lbl.Text = dataGridView1.SelectedRows[0].ToString();

        }

        private void deleteEvent_btn_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            Test test = new Test();
            test.id = p;
            test.delete();

            this.fillData_btn.PerformClick();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Error res = TransactionScripts.createUser("alsalsals", "al", "che", "a@a.ru", "qweqweqwe");
            // label1.Text = res.message;
            // Debug.Text = res.error.ToString();
            //DataTable dt = Users.findByValue("login", $"'als'");
            //label1.Text = (dt.ToString() == null).ToString();
            
            DataTable dt = (DBConnection.getDT($"Select * from \"User\" " + 
                                                $"WHERE id=1"));

            int number = dt.Rows[0].Field<int>(0);
            debug_lbl.Text = number.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            debug_lbl.Text = p.ToString();
            User us = new User(p);
            us.delete();
            this.fillData_btn.PerformClick();
        }
    }
}
