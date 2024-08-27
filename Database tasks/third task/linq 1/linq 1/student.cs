using System;
using System.Runtime.InteropServices;

namespace linq_1
{
    public class student
    {
        static private int ID = -1;
        public string firstName { get; set; }
        public string secondName { get; set; }
        public int Id { get; }
        public int dep_id { get; set; }
        public List<Tuple<string, int>> SubjectsAndDegrees=new List<Tuple<string, int>>();
        public student()
        {
            this.Id = ++ID;
        }
        public override string ToString()
        {
            string student= $"student with id:{this.Id} and name: {firstName} {secondName} has the following degrees:\n";
            foreach (var SubjectAndDegree in this.SubjectsAndDegrees)
                student += SubjectAndDegree.Item1 + ": " + SubjectAndDegree.Item2 + '\n';
            return student ;
        }
    }
}
