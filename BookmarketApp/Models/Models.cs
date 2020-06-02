using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BookmarketApp
{
    public class Model
    {
        protected bool inDB = false;
        public int id;

        protected Model()
        {
        }

        public void delete()
        {
            string query = $"Delete from \"{this.GetType().Name}\" WHERE \"ID\" = {id}";
            DBConnection.execute(query);
            inDB = false;
        }
        public bool isInDB() { return inDB; }

    }

    public class User:Model
    {
        public string debug;

        public string login;
        public string fname;
        public string lname;
        public string email;
        private float cash = 0;
        private bool super_user = false;
        public string password;

        public User() {
      
        }
        public User(int id1)
        {
            DataTable dt = (DBConnection.getDT($"Select * from \"User\" " +
                                               $"WHERE id={id1}"));
            if (dt.Rows.Count != 0)
            {
                id = dt.Rows[0].Field<int>(0);
                login = dt.Rows[0].Field<String>(1);
                password = dt.Rows[0].Field<String>(2);
                fname = dt.Rows[0].Field<String>(3);
                lname = dt.Rows[0].Field<String>(4);
                email = dt.Rows[0].Field<String>(5);
                super_user = dt.Rows[0].Field<bool>(6);
                cash = dt.Rows[0].Field<int>(7);

                inDB = true;
            }
        }
        public User(string login1)
        {
            DataTable dt = (DBConnection.getDT($"Select * from \"User\" " +
                                       $"WHERE login='{login1}'"));
            if (dt.Rows.Count != 0)
            {
                id = dt.Rows[0].Field<int>(0);
                login = dt.Rows[0].Field<String>(1);
                fname = dt.Rows[0].Field<String>(2);
                lname = dt.Rows[0].Field<String>(3);
                email = dt.Rows[0].Field<String>(4);
                cash = dt.Rows[0].Field<float>(5);
                super_user = dt.Rows[0].Field<bool>(6);
                password = dt.Rows[0].Field<String>(7);
                inDB = true;
            }
        }

        public void save()
        {
            string query = "";
            if (!inDB)
            {
                query = $"INSERT INTO \"{this.GetType().Name}\" " +
                    $"(login, password, fname, lname, email)" +
                    $"VALUES('{login}', '{password}', " +
                    $"'{fname}', '{lname}', '{email}')";
                debug = query;
                inDB = true;
            }
            else
            {
                query = $"UPDATE TABLE \"{this.GetType().Name}\" SET ($login ={login}," +
                                                                $"password={password}" +
                                                                $"fist_name= '{fname}'," +
                                                                $"last_name= '{lname}'," +
                                                                $"email={email}," +
                                                                $"super_user=0" +
                                                                $"cash= 0" +
                                                            $") WHERE \"ID\"={id.ToString()}";
            }
            DBConnection.execute(query);
        }
        public static DataTable showAll()
        {
            return (DBConnection.getDT($"Select ID,login, fname, lname, email, super_user, cash " +
                                       $"from \"User\""));
        }
        public static DataTable findByValue(string column, string value)
        {
            return (DBConnection.getDT($"Select login, fname, lname, email, super_user, cash " +
                                       $"from \"User\" " +
                                       $"WHERE {column}={value}"));
        }
        public bool isSuperUser() { return super_user; }
    }

    public class Event:Model
    {
        public string name;
        public string place;
        public DateTime date;
        public string type;
        //private bool inDB = false;
        private DataTable asDT;

        public Event() { }
        public Event(int id1)
        {
            DataTable dt = (DBConnection.getDT($"Select * from \"Event\" " +
                           $"WHERE \"ID\"={id1}"));
            asDT = dt;
            if (dt.Rows.Count != 0)
            {
                id = dt.Rows[0].Field<int>(0);
                name = dt.Rows[0].Field<String>(1);
                place = dt.Rows[0].Field<String>(2);
                date = dt.Rows[0].Field<DateTime>(3);
                type = dt.Rows[0].Field<String>(4);
                inDB = true;
            }
        }
        public void save()
        {
            string query = "";
            if (!inDB)
            {
                query = $"INSERT INTO \"{this.GetType().Name}\" " +
                        $"\"name\", \"place\", \"date\", \"type\")" +
                        $"VALUES('{name}', " +
                               $"'{place}', " +
                               $"'{date.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                               $"'{type}')";

            }
            else
            {
                query = $"UPDATE \"{this.GetType().Name}\" " +
                                $"SET \"name\" ='{name}'," +
                                    $"\"place\"='{place}'," +
                                    $"\"date\" ='{date.ToString("yyyy-MM-dd HH:mm")}'" +
                                    $"\"type\"='{type}'," +
                                    $" WHERE id={id.ToString()}";
            }
            DBConnection.execute(query);
            inDB = true;
        }
       
        public static DataTable showAll()
        {
            DataTable dt = DBConnection.getDT($"Select * from \"Event\"");
            return dt;
        }

        public DataTable asDataTable()
        {
            return asDT;
        }

    }

    public class BetType
    {
     
    }
    class Test
    {
        public int id;
        public string name;
        private bool inDB = false;

        public Test(){}
        public Test(string name_)
        {
            name = name_;
        }

        public void save()
        {
            string query = "";
            if (!inDB)
            {
                query = $"INSERT INTO TEST VALUES('{name}')";
                inDB = true;
            }
            else
            {
                query = @"ALTER TABLE TEST SET name= '" + name + @"') WHERE id=" + id.ToString();
            }
            //string query = @"INSERT INTO TEST VALUES(""als"")";
            DBConnection.execute(query);
        }
        public void delete()
        {
            string query = $"Delete from {this.GetType().Name} WHERE id = {id}";
            DBConnection.execute(query);
        }
        public static DataTable showAll()
        {
            return (DBConnection.getDT(@"Select * from [Test]"));
        }

    }
}
