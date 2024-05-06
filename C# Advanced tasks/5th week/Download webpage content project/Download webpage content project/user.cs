using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Download_webpage_content_project
{
    public class user
    {
        public string? UserName=null;
        int? UserAge=null;
        static int Id=0;
        int UserId;
        public user()
        {
            this.UserId = Id;
            Id++;
            GetUserInfo();
        }
        void GetUserInfo()
        {
            Console.Write("could you please enter your name:");
            UserName = Console.ReadLine();
            Console.Write("age:");
            string? age= Console.ReadLine();
            if (!int.TryParse(age, out int ignor))
                age =null;
            int? agevalue=null;
            if (age != null)
                agevalue = int.Parse(age);
            UserAge =  agevalue?? 0;
        }
    }
}
