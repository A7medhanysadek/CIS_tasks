using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_1
{
    public class studentDTO
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string degrees { get; set; }
        public override string ToString()
        {
            return this.Name+" "+this.Department;
        }
    }
    
}
