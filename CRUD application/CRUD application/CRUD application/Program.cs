using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Transactions;

namespace CRUD_implementation
{
    //Abstraction
    abstract class database
    {
        protected static int Table_id=0;
        public abstract void tabel_ID();
    }
    //Inheritance
    class table :database
    {
        
        List<user> users;
        List<List<user>> table_data;
        private int table_id;
        public table()
        {
            tabel_ID();
            users = new List<user>();
            table_data = new List<List<user>>();
            hub();
        }
        private void hub()
        {
            while(true)
            {
                Console.WriteLine("choose the number of the method you want:\n1- create \n2- read\n3- update\n4- delete");
                int choosen_num= int.Parse(Console.ReadLine());
                switch (choosen_num)
                {
                    case 1:
                        create();
                        break;
                    case 2:
                        read();
                        break;
                    case 3:
                        update();
                        break;
                    case 4:
                        delete();
                        break;
                    default: 
                        Console.WriteLine("invalid number ):");
                        break;
                }
            }
        }
        //Polymorphism
        public override void tabel_ID()
        {
            this.table_id = Table_id;
            Table_id++;
        }
        public void create()
        {
            user u = new user();
            u.create_username();
            u.create_user_birth_date();
            u.create_user_salary();
            users.Add(u);
            Console.WriteLine($"the data has been created with id number: {u.get_id()}");
        }
        public void read()
        {
            Console.Write("\ncould you please enter user id:");
            int id = int.Parse(Console.ReadLine());
            if (users[id].is_deleted())
                Console.WriteLine("this user has been deleted ):");
            else
            {
                users[id].read_username();
                users[id].read_birth_year();
                users[id].read_salary();
            }
        }
        public void update()
        {
            Console.WriteLine("could you please enter user id:");
            int id = int.Parse (Console.ReadLine());
            if (users[id].is_deleted())
                Console.WriteLine("this user has been deleted ):");
            else
            {
                users[id].read_username();
                users[id].read_birth_year();
                users[id].read_salary();
                users[id].update_username();
                users[id].update_birth_year();
                users[id].update_salary();
                Console.WriteLine("the data has been updated successfully");
            }
        }
        public void delete()
        {
            Console.Write("\ncould you please enter user id:");
            int id = int.Parse(Console.ReadLine());
            if (users[id].is_deleted())
                Console.WriteLine("this user has been deleted ):");
            else
                users[id].delete_user();
        }
    }
    class user
    {
        List<string> table_row;
        private static int ID=0;
        private string fname;
        private string lname;
        private int birth_date_year;
        private int salary;
        private bool deleted=false;
        public user()
        {
            table_row = new List<string>();
            set_id();
        }
        //Encapsulation
        protected void set_id()
        {
            table_row.Add(ID.ToString());
            ID++;
        }
        public int get_id()
        {
            return int.Parse(this.table_row[0]);
        }
        //Encapsulation
        public void create_username()
        {
            Console.Write("\nCould you please enter your First name:");
            fname = Console.ReadLine();
            Console.Write("\n Your last name:");
            lname = Console.ReadLine();
        }
        //Encapsulation
        public void create_user_birth_date()
        {
            Console.Write("\ncould you please enter your birth date year:");
            birth_date_year = int.Parse(Console.ReadLine());            
        }
        public void create_user_salary()
        {
            Console.Write("\ncould you please enter your salary:");
            salary = int.Parse(Console.ReadLine());
        }
        public void read_username()
        {
            Console.WriteLine($"user name is :{fname} {lname}");
        }
        public void read_birth_year()
        {
            Console.WriteLine($"user birth year is : {birth_date_year}");
        }
        public void read_salary()
        {
            Console.WriteLine($"user salary is:{salary}");
        }
        public void update_username()
        {
            Console.Write("\nthe new first name is:");
            fname = Console.ReadLine();
            Console.Write("\nthe new last name is:");
            lname = Console.ReadLine();
        }
        public void update_birth_year()
        {
            Console.Write("\nthe new user birth year value is:");
            birth_date_year =int.Parse(Console.ReadLine());
        }
        public void update_salary()
        {
            Console.Write("\nthe new user salary is:");
            salary=int.Parse(Console.ReadLine());
        }
        public void delete_user()
        {
            deleted=true;
        }
        public bool is_deleted()
        {
            return deleted;
        }
    }
    class main_class
    {
        static void Main(string[] args)
        {
            table t= new table();
        }
    }
}
