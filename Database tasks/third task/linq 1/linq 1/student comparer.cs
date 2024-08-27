using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_1
{
    internal class student_comparer : IComparer<student>
    {
        public int Compare(student? s1, student? s2)
        {
            return s1!.secondName.CompareTo(s2!.secondName);
        }
    }
}
