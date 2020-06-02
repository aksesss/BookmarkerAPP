using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace BookmarketApp
{
    class DBConnection
    {
        private static string connection_str = "Server=127.0.0.1;" +
                                               "User Id=postgres;" +
                                               "Password=785941828;" +
                                               "Database=vin_dz2";
        public static NpgsqlConnection con = new NpgsqlConnection(connection_str);
        //   private string dbstr = ''
        private static DataSet ds = new DataSet();
        private static DataTable dt = new DataTable();

        private DBConnection()
        {
        }

        public static void execute(string query)
        {
            try
            {
                con.Open();
                //SqlCommand sqlcommand = new SqlCommand(query, con);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
                ds.Reset();
                da.Fill(dt);
                //dt = ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(query + "\n\n" + e.ToString());
            }
            finally
            {
                con.Close();
            }
            
            //SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            //da.Fill();


        }

        public static DataTable getDT(string query)
        {
            try
            {
                con.Open();
                //SqlCommand sqlcommand = new SqlCommand(query, con);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
                ds.Reset();

                da.Fill(ds);
                dt = ds.Tables[0];
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(query + "\n\n" + e.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
