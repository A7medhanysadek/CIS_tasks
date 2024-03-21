using CRUD_implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_application
{
    internal class CRUD:table
    {
        //event
        public event NewEventHandler New;
        public delegate void NewEventHandler(user usr);
        public void create_user()
        {
            user u = new user();
            u.create_user_info();
            u.create_user_birth_date();
            u.create_user_salary();
            users.Add(u);
            New?.Invoke(u);
            New += newuser;
            newuser(u);
        }
        public void newuser(user u)
        {
            Console.WriteLine($"new user has been created with id:{u.get_id}");
        }
        public void read_user()
        {
            Console.Write("\ncould you please enter user id:");
            int id = int.Parse(Console.ReadLine());
            if (users[id].is_deleted())
                Console.WriteLine("this user has been deleted ):");
            else
            {
                Console.WriteLine(users[id]);
            }
        }
        public void update_user()
        {
            Console.WriteLine("could you please enter user id:");
            int id = int.Parse(Console.ReadLine());
            if (users[id].is_deleted())
                Console.WriteLine("this user has been deleted ):");
            else
            {
                Console.WriteLine(users[id]);
                users[id].update_username();
                users[id].update_birth_year();
                users[id].update_salary();
                Console.WriteLine("the data has been updated successfully");
            }
        }
        public void delete_user()
        {
            Console.Write("\ncould you please enter user id:");
            int id = int.Parse(Console.ReadLine());
            if (users[id].is_deleted())
                Console.WriteLine("this user has been deleted ):");
            else
                users[id]=null;
        }
        public void create_table()
        {
            table t = new table();
            t.set_table_name();
            t.add_table();   
            DB.Add(t);
            Console.WriteLine($"the new table has been added with id:{t.get_id()-1}");
        }
        public void delete_table()
        {
            Console.Write("\ncould you please enter user id:");
            int id = int.Parse(Console.ReadLine());
            DB[id] = null;
        }
    }
}
