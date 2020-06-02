using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Npgsql;

namespace BookmarketApp_another
{
    class DBConnection
    {
        private static string connection_str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\als\source\repos\mydz2_v2\mydz2_v2\Bookmark.mdf;Integrated Security=True";    //Строка подключения
        //private static string connection_str = "Server=127.0.0.1;User Id=postgres;" +
        //                        "Password=785941828;Database=lab1_chAA";
        public static SqlConnection con = new SqlConnection(connection_str);
        //   private string dbstr = ''
        public DBConnection()
        {
        }

        public static void execute(string query)
        {
            try
            {
                con.Open();
                SqlCommand sqlcommand = new SqlCommand(query, con);
                sqlcommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {

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
                SqlCommand sqlcommand = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch(Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }

        }
    }
}
