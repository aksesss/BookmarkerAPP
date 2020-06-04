using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BookmarketApp
{
    public struct Error
    {
        public bool error;
        public string message;
    }
    public static class TransactionScripts
    {

        public static Error createUser(string login, string fname, string lname, string email, string password)
        {
            Error res;
            DataTable dt = User.findByValue("login", $"'{login}'");
            if (dt.Rows.Count == 0)
            {
                User us = new User();
                us.login = login;
                us.fname = fname;
                us.lname = lname;
                us.email = email;
                string hash = encryption.HashPassword(password);
                us.password = hash;
                //string debug = us.getQuery();
                us.save();

                res.error = false;
                res.message = "Даныне добавлены в БД";
            }
            else
            {
                res.error = true;
                res.message = "Данный логин уже существует";
            }

            return res;
        }
        public static Error auth(string login, string password)
        {
            Error result;
            result.error = true;

            User us = new User(login);
            if (us.isInDB())
            {
                if (encryption.VerifyHashedPassword(us.password, password))
                {
                    result.error = false;
                    result.message = "Авторизация прошла успешно";
                }
                else
                    result.message = "Пароль не совпал";
            }
            else
                result.message = "Нет такого пользователя";

            return result;
        }
        public static int getUserId(string login) {
            User user = new User(login);
            return user.id;
        }
        public static DataTable getAllUsers()
        {
            return User.showAll();
        }
        public static DataTable getEventById(int id)
        {
            if (id <= 0)
            {
                return new DataTable();
            }

            Event ev = new Event(id);
            if (ev.isInDB()) 
            { 
                return ev.asDataTable();
            }
            else
            {
                return new DataTable();
            }
        }
        public static DataTable getAllEvents()
        {
            return Event.showAll();
        }
        public static Error createEvent(string name, string eventType, string place, 
                string date, string time) 
        {
            Error res;
            DateTime dtime;
            Event ev = new Event(eventType);
            try
            {
                DateTime.TryParse(
                        $"{date} {time}",
                        System.Globalization.CultureInfo.CurrentCulture,
                        System.Globalization.DateTimeStyles.AssumeLocal,
                        out dtime
                    );

                ev.name = name;
                //ev.type = eventType;
                ev.place = place;
                ev.date = dtime;

                ev.save();

                res.error = false;
                res.message = "Событие успешно добавлено";
            }
            catch (Exception e)
            {
                res.error = true;
                res.message = e.ToString();
            }
            return res;
        }
        public static Error deleteEvent(int event_id)
        {
            Error er;

            Event ev = new Event(event_id);
            if (ev.isInDB())
            {
                ev.delete();
                er.error = false;
                er.message = "Ok";
            }
            else
            {
                er.error = true;
                er.message = "Данного события не существует";
            }
            return er;
        }
        public static Error updateEvent(Event ev, string name, string eventType, string place, 
                                                  string date, string time)
        {
            DateTime dtime;
            DateTime.TryParse(
                $"{date} {time}",
                System.Globalization.CultureInfo.CurrentCulture,
                System.Globalization.DateTimeStyles.AssumeLocal,
                out dtime);

            Error result;
            result.error = false;
            string update_fields = "";
            ev.name = name;

            //EventFlyweightFactory fact = EventFlyweightFactory.getInstance();
            if (ev.place != place)
            {
                ev.place = place;
                update_fields = update_fields + "Место ";
            }
           
            
            if (ev.date.ToString("yyyy-MM-dd") != dtime.ToString("yyyy-MM-dd"))
            {
                update_fields = update_fields + "Дата  ";
            }
            if (ev.date.ToString("HH-mm") != dtime.ToString("HH-mm"))
            {
                update_fields = update_fields + "Время  ";
                ev.date = dtime;
            }
            

            try
            {
                if(update_fields != "") 
                { 
                    ev.save();
                    result.message = $"Поля обновлены: {update_fields}";
                }
                else
                {
                    result.message = "Нечего обновлять";
                }
                result.error = false;
                return result;
            }
            catch(Exception e)
            {
                result.error = true;
                result.message = e.ToString();
                return result;
            }
        }
        public static Error updateEvent(int ev_id, string name, string place, 
                                                  string date, string eventType)
        {
            Error res = new Error();
            res.error = false;

            try
            {
                Event ev1 = new Event(ev_id);
                
//                ev1.id = ev_id;
                ev1.name = name;
                ev1.place = place;
                DateTime dtime;
                DateTime.TryParse(
                    $"{date}",
                    System.Globalization.CultureInfo.CurrentCulture,
                    System.Globalization.DateTimeStyles.AssumeLocal,
                    out dtime);
                ev1.date = dtime;
                ev1.save();
            }
            catch (Exception e)
            {
                res.error = true;
                res.message = e.ToString();
            }
            return res;
        }
    }
}
