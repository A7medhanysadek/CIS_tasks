using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_1
{
    public class Department
    {
        private static int ID=-1;
        public int Id { get; set; }
        public string Name { get; set; }
        public Department()
        {
            this.Id = ++ID;
        }
    }
}
