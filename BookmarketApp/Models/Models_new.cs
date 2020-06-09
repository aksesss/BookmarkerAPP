using BookmarketApp;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BookmarketApp
{
    public class Event:Model
    {
        public string name;
        public string place;
        public DateTime date;
        public string type;
        //private bool inDB = false;
        private DataTable asDT;

        public EventFlyweight shared_state;

        public Event(string shared_field)
        {
            EventFlyweightFactory factory = EventFlyweightFactory.getInstance();
            this.shared_state = factory.GetFlyweight(shared_field);
        }

        public Event(int id1)
        {
            DataTable dt = (DBConnection.getDT($"Select * from \"Event\" " +
                           $"WHERE \"ID\"={id1}"));
            asDT = dt;
            if (dt.Rows.Count != 0)
            {
                this.id = dt.Rows[0].Field<int>(0);
                this.name = dt.Rows[0].Field<String>(1);
                this.place = dt.Rows[0].Field<String>(2);
                this.date = dt.Rows[0].Field<DateTime>(3);
                this.type = dt.Rows[0].Field<String>(4);
                inDB = true;

                string type1 = dt.Rows[0].Field<String>(4);
                EventFlyweightFactory factory = EventFlyweightFactory.getInstance();
                this.shared_state = factory.GetFlyweight(type1);
            }
        }

        public void save()
        {
            this.shared_state.OperationSave(this.inDB, this.id, this.name, this.place, this.date);
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

    public class EventFlyweight
    {
        private string _type;
        public EventFlyweight(string type)
        {
            this._type = type;
        }
        public void Operation(string unique_state)
        {
            Console.WriteLine($"shared : {_type}\n" +
                              $"unique : {unique_state}");

        }

        public void OperationSave(bool inDB, int id, string name, string place, DateTime date)
        {
            string query = "";
            if (!inDB)
            {
                query = $"INSERT INTO \"Event\" " +
                        $"(\"name\", \"place\", \"date\", \"type\")" +
                        $"VALUES('{name}', " +
                               $"'{place}', " +
                               $"'{date.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                               $"'{_type}')";

            }
            else
            {
                query = $"UPDATE \"Event\" " +
                                $"SET \"name\" ='{name}'," +
                                    $"\"place\"='{place}'," +
                                    $"\"date\" ='{date.ToString("yyyy-MM-dd HH:mm")}'," +
                                    $"\"type\"='{_type}'" +
                                    $" WHERE \"ID\"={id.ToString()}";
            }
            DBConnection.execute(query);
        }
    }

    class EventFlyweightFactory
    {
        public Hashtable flyweights;

        private static EventFlyweightFactory instance;
        private EventFlyweightFactory()
        {
            flyweights = new Hashtable();
        }
        public static EventFlyweightFactory getInstance()
        {
            if (instance == null)
            {
                Console.WriteLine("Create new singletone factory");
                instance = new EventFlyweightFactory();
            }
            return instance;
        }

        public EventFlyweight GetFlyweight(string type)
        {
            if (!flyweights.ContainsKey(type))
            {
                //Console.WriteLine($"There is no flyweights with shared field: {type}");
                //Console.WriteLine("Creating a new one");
                flyweights.Add(type, new EventFlyweight(type));
            }
            return flyweights[type] as EventFlyweight;
        }

        public void listFlyweights()
        {
            var count = flyweights.Count;
            //Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in flyweights.Keys)
            {
                Console.WriteLine(flyweight);
            }
        }

    }
}
