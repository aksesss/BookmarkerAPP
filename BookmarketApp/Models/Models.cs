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
                                               $"WHERE \"ID\"={id1}"));
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
                                       $"WHERE \"login\"='{login1}'"));
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
                    $"(\"login\", \"password\", \"fname\", \"lname\", \"email\")" +
                    $"VALUES('{login}', '{password}', " +
                    $"'{fname}', '{lname}', '{email}')";
                debug = query;
                inDB = true;
            }
            else
            {
                query = $"UPDATE \"{this.GetType().Name}\" SET \"login\" = '{login}' ," +
                                                                $"\"password\" = '{password}', " +
                                                                $"\"fname\" = '{fname}', " +
                                                                $"\"lname\" = '{lname}', " +
                                                                $"\"email\" = '{email}'," +
                                                                $"\"super_user\" = {this.isSuperUser()}, " +
                                                                $"\"cash\" = {this.cash}" +
                                                            $" WHERE \"ID\"={id.ToString()}";
            }
            DBConnection.execute(query);
        }
        public static DataTable showAll()
        {
            return (DBConnection.getDT($"Select \"ID\",\"login\", \"fname\"," +
                                             $" \"lname\", \"email\", \"super_user\"," +
                                             $" \"cash\" " +
                                       $"from \"User\""));
        }
        public static DataTable findByValue(string column, string value)
        {
            return (DBConnection.getDT($"Select \"login\", \"fname\", \"lname\"," +
                                             $" \"email\", \"super_user\", \"cash\" " +
                                       $"from \"User\" " +
                                       $"WHERE {column}={value}"));
        }
        public bool isSuperUser() { return super_user; }
        public float getCash()
        {
            return this.cash;
        }
        public void reduceCash(float value)
        {
            this.cash = this.cash - value;
            this.save();
        }
    }

/*    public class Event:Model
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
                        $"(\"name\", \"place\", \"date\", \"type\")" +
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
                                    $"\"date\" ='{date.ToString("yyyy-MM-dd HH:mm")}'," +
                                    $"\"type\"='{type}'" +
                                    $" WHERE \"ID\"={id.ToString()}";
            }
            DBConnection.execute(query);
            inDB = true;
        }
       
        public static DataTable showAll()
        {
            //DataTable dt = new DataTable()
            DataTable dt = DBConnection.getDT($"Select * from \"Event\"");
            return dt;
        }

        public DataTable asDataTable()
        {
            return asDT;
        }

    }
*/
    public class BetType:Model
    {
        //public Event event_;
        public int eventid;
        public string description;
        public string[] coef;

        public BetType() { }
        public BetType(int id1)
        {
            DataTable dt = (DBConnection.getDT($"Select \"ID\", \"event\", \"description\"," +
                           $"array_to_string(\"coef1\", ',', '*')" +
                           $"from \"BetType\" " +
                           $"WHERE \"ID\"={id1}"));
            if (dt.Rows.Count != 0)
            {
                this.id = dt.Rows[0].Field<int>(0);
                this.eventid = dt.Rows[0].Field<int>(1);
                //this.event_ = new Event(eventid);
                this.description = dt.Rows[0].Field<String>(2);
                String coef_string = dt.Rows[0].Field<String>(3);
                String[] smth = coef_string.Split(',');
                this.inDB = true;
            }
        }
        public static DataTable showAll()
        {
            DataTable dt = DBConnection.getDT($"Select \"ID\", \"event\", \"description\", " +
                                              $"array_to_string(\"coef1\", ',', '*') AS coefs " +
                                              $"from \"BetType\"");
            return dt;
        }
        public static DataTable showAllByEvent(int event_id)
        {
            DataTable dt = DBConnection.getDT($"Select \"ID\", \"event\", \"description\", " +
                                              $"coef1[array_length(coef1, 1)] as coef " +
                                              $"from \"BetType\" " +
                                              $"WHERE \"event\" = {event_id}");
            return dt;
        }
        public void save()
        {
            string query = "";
            if (!inDB)
            {
                query = $"INSERT INTO \"{this.GetType().Name}\" " +
                        $"(\"event\", \"description\", \"coef1\")" +
                        $"VALUES('{eventid}', " +
                               $"'{description}', " +
                               $"'{String.Join(",", coef)}' )";

            }
            else
            {
               query = $"UPDATE \"{this.GetType().Name}\" " +
                                $"SET \"event\" ='{eventid}'," +
                                    $"\"description\"='{description}'," +
                                    $"\"coef1\"='{{ {String.Join(",", coef)} }}'" +
                                    $" WHERE \"ID\"={id.ToString()}";
            }
            DBConnection.execute(query);
            inDB = true;
        }

        public static float getLastCoefByID(int btid)
        {
            DataTable dt = DBConnection.getDT($"Select coef1[array_length(coef1, 1)] as coef " +
                                              $"from \"BetType\" " +
                                              $"WHERE \"ID\" = {btid}");
            return dt.Rows[0].Field<float>(0);

        }
    }

    public class Bet:Model
    {
        public int client_id;
        public int bet_type_id;
        public float bet_coef;
        public float cost;
        public DateTime date;
        public bool status;


        public Bet() { }

        public Bet(int id1)
        {
            DataTable dt = (DBConnection.getDT($"Select \"ID\", \"client\", \"bet_type\"," +
                           $"\"bet_coef\", \"cost\", \"date\", \"status\" " +
                           $"from \"Bet\" " +
                           $"WHERE \"ID\"={id1}"));
            if (dt.Rows.Count != 0)
            {
                this.id = dt.Rows[0].Field<int>(0);
                this.client_id = dt.Rows[0].Field<int>(1);
                this.bet_type_id = dt.Rows[0].Field<int>(2);
                this.bet_coef = dt.Rows[0].Field<float>(3);
                this.cost = dt.Rows[0].Field<float>(4);
                this.date = dt.Rows[0].Field<DateTime>(5);
                this.inDB = true;
            }
            else
            {
                inDB = false;
            }
        }
        public static DataTable showAll()
        {
            DataTable dt = DBConnection.getDT($"Select \"ID\", \"client\", \"bet_type\"," +
                           $"\"bet_coef\", \"cost\", \"date\", \"status\" " +
                           $"from \"Bet\" ");
            return dt;
        }
        public void save()
        {
            string query = "";
            if (!inDB)
            {
                query = $"INSERT INTO \"{this.GetType().Name}\" " +
                        $"(\"client\", \"bet_type\",  " +
                           $"\"bet_coef\", \"cost\", \"date\") " +
                        $"VALUES('{this.client_id}', " +
                               $"'{this.bet_type_id}', " +
                               $"{this.bet_coef.ToString().Replace(',', '.')} , " +
                               $"{this.cost}, " +
                               $"'{this.date.ToString()}' )";

            }
            else
            {
                query = $"UPDATE \"{this.GetType().Name}\" " +
                                 $"SET \"client\" ='{this.client_id}'," +
                                     $"\"bet_type\"='{this.bet_type_id}'," +
                                     $"\"bet_coef\"='{this.bet_coef.ToString().Replace(',', '.')}'," +
                                     $"\"cost\"='{this.cost}'," +
                                     $"\"date\"='{this.date.ToString()}', " +
                                     $"\"status\"='{this.status}' " +
                                     $" WHERE \"ID\"={id.ToString()}";
            }
            DBConnection.execute(query);
            inDB = true;
        }
        public static DataTable showAllByUID(int uid)
        {
            string query = $"SELECT * FROM \"Bet\" WHERE \"client\" = {uid}";
            DataTable dt = DBConnection.getDT(query);
            return (dt);
        }


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
                //query = $ "ALTER TABLE TEST SET name= '" + name + @"') WHERE id=" + id.ToString();
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
