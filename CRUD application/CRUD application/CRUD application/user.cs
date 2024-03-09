using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace CRUD_implementation
{
    //generics
    public struct dateofbirth<T>
    {
        public T day;
        public T month;
        public T year;
    }
    class user
    {
        dateofbirth<int> d;
        List<string> table_row;
        private static int ID = 0;
        private string fname;
        private string lname;
        private int salary;
        private string gender;
        public user()
        {
            table_row = new List<string>();
            d =new dateofbirth<int>();
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
        public void create_user_info()
        {
            Console.Write("\nCould you please enter your First name:");
            fname = Console.ReadLine();
            Console.Write("\n Your last name:");
            lname = Console.ReadLine();
            Console.Write("\nCould you please choose your gender\n1-male\n2-female\n");
            int chosen_num=int.Parse(Console.ReadLine());
            if (chosen_num == 1)
                gender = "male";
            else if (chosen_num == 2)
                gender = "female";
            else
                Console.WriteLine("invalid number");
        }
        //Encapsulation
        public void create_user_birth_date()
        {
            
            Console.Write("\ncould you please enter your birth date day:");
            d.day= int.Parse(Console.ReadLine());            
            Console.Write("\ncould you please enter your birth date month:");
            d.month= int.Parse(Console.ReadLine());            
            Console.Write("\ncould you please enter your birth date year:");
            d.year= int.Parse(Console.ReadLine());    
            
        }
        public void create_user_salary()
        {
            Console.Write("\ncould you please enter your salary:");
            salary = int.Parse(Console.ReadLine());
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
            Console.Write("\nthe new user birth day value is:");
            d.day =int.Parse(Console.ReadLine());
            Console.Write("\nthe new user birth month value is:");
            d.month =int.Parse(Console.ReadLine());
            Console.Write("\nthe new user birth year value is:");
            d.year =int.Parse(Console.ReadLine());
        }
        public void update_salary()
        {
            Console.Write("\nthe new user salary is:");
            salary=int.Parse(Console.ReadLine());
        }
        public bool is_deleted()
        {
            return this == null;
        }
        //polymorphism
        public override string ToString()
        {
            return $"\nuser name:{fname} {lname}\nuser age:{System.DateTime.Now.Year-d.year}\ngender:{gender}\nuser salary:{salary}.";
        }
    }
}
