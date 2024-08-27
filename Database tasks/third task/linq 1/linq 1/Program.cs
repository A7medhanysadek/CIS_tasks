using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;

namespace linq_1
{
    class main_class
    {
        static void Main(string[] args)
        {

            //1-Pure function:
            Console.WriteLine("=============={1}=============");
            List<int> l01 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> odd_numbers01 = l01.Odd_Numbers_Filter();
            Console.Write("odd numbers : ");
            foreach (var i in odd_numbers01)
            {
                Console.Write(i + " ");
            }
            Console.Write('\n');
            //2-Impure funcion:
            Console.WriteLine("=============={2}=============");
            int x02 = 5;
            Console.Write("x value before incrementing inside the impure function :" + x02 + '\n');
            incrementing_integers(ref x02);
            Console.Write("x value after incrementing inside the impure function :" + x02 + '\n');
            //3-Functional programing approach:
            // The most helpfull benefit of functional programing is the way to how minimize the code in the simplest form
            // The only drawback in my opinion is the complexity of tracking the code and searching for extensions or delegates and lambda expressions
            Console.WriteLine("=============={3}=============");
            List<string> user03 = new List<string> { "ahmed", "ali", "mohamed", "omar", "adel" };
            var s03 = user03.filter(i=> i[0]=='a');
            filter_print(s03);
            s03 = extentions.filter(user03, i=> i[0] == 'm' || i[0]=='o');
            filter_print(s03);
            //4-projection operations:
            Console.WriteLine("=============={4}=============");
            List<student> students04 = new() {
            new student
            {
                firstName="Ahmed",secondName="Hany",SubjectsAndDegrees=new(){new("Math",100),new("Arabic",100),new("English",100),new("science",100),new ("programing",40) }
            },
            new student
            {
                firstName="Ahmed",secondName="Wael",SubjectsAndDegrees=new(){new("Math",100),new("Arabic",90),new("English",80),new("science",95) }
            },
            new student
            {
                firstName="ali",secondName="osama",SubjectsAndDegrees=new(){new("Math",50),new("Arabic",40),new("English",80) }
            }
            };

            var result0401 = students04.Select(x => new studentDTO
            {
                Name = x.firstName + " " + x.secondName+"\n-----------------------\n",
                degrees = x.SubjectsAndDegrees[0].Item1 + " " + x.SubjectsAndDegrees[0].Item2 + '\n'+ x.SubjectsAndDegrees[1].Item1 + " " + x.SubjectsAndDegrees[1].Item2 + '\n'+x.SubjectsAndDegrees[2].Item1 + " " + x.SubjectsAndDegrees[2].Item2 + '\n'
            });
            foreach (var student in result0401)
                Console.WriteLine(student);
            var result0402 = students04.SelectMany(x => new string[] { x.firstName, x.secondName });
            //var result01 = from student in students
            //               select new string[] { student.firstName, student.secondName };
            foreach (var student in result0402)
                Console.WriteLine(student);
            var result0403 = students04[0].SubjectsAndDegrees.Zip(students04[1].SubjectsAndDegrees, (first, second) => $"{first.Item1} :{first.Item2} VS {second.Item1} :{second.Item2}");
            Console.WriteLine($"\n========{students04[0].firstName} {students04[0].secondName} VS {students04[1].firstName} {students04[1].secondName}==========\n");
            foreach(var student in result0403)
                Console.WriteLine("\n========"+student+"==========\n");
            //5-Sorting Data
            Console.WriteLine("=============={5}=============");
            Console.WriteLine("sorting in ascending order:");
            var students05 = students04;
            var result0501 = students05.OrderBy(x => x.Id);
            foreach(var student in students05)
                Console.WriteLine(student);
            Console.WriteLine("sorting in a descending order:");
            var result0502=students05.OrderByDescending(x => x.Id);
            foreach (var student in result0502)
                Console.WriteLine(student);
            Console.WriteLine("sorting with then by order:");
            var result0503 = students05.OrderBy(x => x.SubjectsAndDegrees[0].Item2).ThenBy(x => x.SubjectsAndDegrees[1].Item2).ThenBy(x => x.SubjectsAndDegrees[2].Item2);
            foreach (var student in result0503)
                Console.WriteLine(student);
            Console.WriteLine("sorting with reversed order:");
            string[] s05 = { "ahmed", "ali", "hossam", "mohamed", "omar" };
            var result0504 = s05.Reverse();
            foreach (var student in result0504)
                Console.WriteLine(student);
            Console.WriteLine("sorting with implementing compare function in Icomparer interface:");
            var result0505 = students05.OrderBy(x => x, new student_comparer());
            foreach(var student in result0505)
                Console.WriteLine(student);
            //sorting using Icomparer > sorting wiht then by > sorting with order by > reverse function in time complixty and also absloutly the same for the effecincy. 
            //6-Data Partitioning
            List<student> second = new()
            {
            new student
            {
                firstName="ali",secondName="mohamed",SubjectsAndDegrees=new(){new("Math",100),new("science",100),new ("programing",40) }
            },
            new student
            {
                firstName="Ahmed",secondName="alaa",SubjectsAndDegrees=new(){new("Math",100),new("Arabic",90),new("English",80),new("science",95),new("Operating system",85) }
            },
            new student
            {
                firstName="mohamed",secondName="mansour",SubjectsAndDegrees=new(){new("Math",50),new("Arabic",40),new("English",80),new ("Operating system",60),new("probability",80) }
            },
            new student
            {
                firstName="mohamed",secondName="mohsen",SubjectsAndDegrees=new(){new("Math",100),new("science",100),new ("programing",40) }
            },
            new student
            {
                firstName="omar",secondName="fathy",SubjectsAndDegrees=new(){new("Math",100),new("Arabic",90),new("English",80),new("science",95),new("Operating system",85) }
            },
            new student
            {
                firstName="osama",secondName="elshaarawy",SubjectsAndDegrees=new(){new("Math",50),new("Arabic",40),new("English",80),new ("Operating system",60),new("probability",80) }
            }
            };
            var students06= students04.Concat(second);
            Console.WriteLine("=============={6}=============");
            Console.WriteLine("====================================\nusing Skip:");
            var result0601 = students06.Skip(2);
            foreach (var student in result0601)
                Console.WriteLine(student);
            Console.WriteLine("====================================\nusing SkipWhile:");
            var result0602 = students06.SkipWhile(x=>x.SubjectsAndDegrees.Count==3);
            foreach (var student in result0602)
                Console.WriteLine(student);
            Console.WriteLine("====================================\nusing SkipLast:");
            var result0603 = students06.SkipLast(2);
            foreach (var student in result0603)
                Console.WriteLine(student);
            Console.WriteLine("====================================\nusing Take:");
            var result0604 = students06.Take(2);
            foreach (var student in result0604)
                Console.WriteLine(student);
            Console.WriteLine("====================================\nusing TakeWhile:");
            var result0605 = students06.TakeWhile(x=>x.SubjectsAndDegrees.Count!=4);
            foreach (var student in result0605)
                Console.WriteLine(student);
            Console.WriteLine("====================================\nusing TakeLast:");
            var result0606 = students06.TakeLast(2);
            foreach (var student in result0606)
                Console.WriteLine(student);
            Console.WriteLine("====================================\nusing chuncks and parallel processing:");
            var result0607 = students06.Chunk(3).ToList();
            Task t0601 = new Task(()=>PrintArrayOfStudents(result0607[0]));
            Task t0602 = new Task(()=>PrintArrayOfStudents(result0607[1]));
            Task t0603 = new Task(()=>PrintArrayOfStudents(result0607[2]));
            t0601.Start();t0602.Start();t0603.Start();
            t0601.GetAwaiter().GetResult(); t0602.GetAwaiter().GetResult(); t0603.GetAwaiter().GetResult();
            //the performance we can achieve from data partitioning is the ability to divide the whole data into smaller groups
            //to present, process or save them which will help us to enhance the performance by working on smaller groups not the whole data it self
            //7-Quantifiers
            List<student> students07 = new() {
            new student
            {
                firstName="mohamed",secondName="mansour",SubjectsAndDegrees=new(){new("Math",50),new("Arabic",40),new("English",80),new ("Operating system",60),new("probability",80) }
            },
            new student
            {
                firstName="omar",secondName="fathy",SubjectsAndDegrees=new(){new("Math",100),new("Arabic",90),new("English",80),new("science",95),new("Operating system",85) }
            },
            new student
            {
                firstName="osama",secondName="elshaarawy",SubjectsAndDegrees=new(){new("Math",50),new("Arabic",40),new("English",80),new ("Operating system",60),new("probability",80) }
            }
            };
            Console.WriteLine("=============={7}=============");
            Console.WriteLine($"the teacher of the class asked if all the students" +
                $" have registered in his subject(probability) and the answer is:{students07.All(x => x.SubjectsAndDegrees[4].Item1== "probability")}");
            Console.WriteLine($"the teacher of the class asked if any of the students" +
                $" has registered in his subject(probability) and the answer is:{students07.Any(x => x.SubjectsAndDegrees[4].Item1 == "probability")}");
            //8-Grouping Data
            Console.WriteLine("=============={8}=============");
            var result0801 = students06.GroupBy(x => x.SubjectsAndDegrees[2].Item1);
            //var result0802 = students06.ToLookup(x => x.SubjectsAndDegrees[2].Item1);
            foreach (var list in result0801)
            {
                Console.WriteLine($"{list.Count()} student\\s have the avrage: %{((double)list.Count()/students06.Count())*100} of all the students, and they have regesterd in {list.Key} subject:");
                foreach (var student in list)
                    Console.WriteLine(student);
            }
            //9-Join Operations
            Console.WriteLine("=============={9}=============");
            List<Department> departments= new() { 
                new Department{ 
                    Name="CS"
                },
                new Department{ 
                    Name="IT"
                },
                new Department{ 
                    Name="IS"
                }
            };
            List<student> students09 = new()
            {
                new student
                {
                    firstName="ahmed",
                    secondName="hany",
                    dep_id=0
                },
                new student
                {
                    firstName="ahmed",
                    secondName="wael",
                    dep_id=0
                },
                new student
                {
                    firstName="ahmed",
                    secondName="syam",
                    dep_id=-1
                },
                new student
                {
                    firstName="adham",
                    secondName="elsaady",
                    dep_id=0
                },
                new student
                {
                    firstName="moemen",
                    secondName="elsayed",
                    dep_id=1
                },
                new student
                {
                    firstName="ammar",
                    secondName="hashem",
                    dep_id=2
                },
                new student
                {
                    firstName="omar",
                    secondName="kamal",
                    dep_id=-1
                },
                new student
                {
                    firstName="ahmed",
                    secondName="elkhoreby",
                    dep_id=-1
                },
                new student
                {
                    firstName="eslam",
                    secondName="abbas",
                    dep_id=-1
                }
            };
            var result0901=students09.Join(departments,
                std => std.dep_id, dep => dep.Id,
                (std, dep) => new studentDTO
            {
                Name = std.firstName +" "+ std.secondName,
                Department = dep.Name
            });
            foreach (var student in result0901)
                Console.WriteLine(student.Name+" "+student.Department);
            Console.WriteLine("=========================================");
            var result0902 = from std in students09
                             join dep in departments on
                             std.dep_id equals dep.Id
                             select new studentDTO
                             {
                                 Name = std.firstName + " " + std.secondName,
                                 Department = dep.Name
                             };
            foreach (var student in result0902)
                Console.WriteLine(student.Name + " " + student.Department);
            var result0903 = from dep in departments
                             join std in students09
                             on dep.Id equals std.dep_id into stdgroup
                             select stdgroup;
            foreach (var student in result0903)
            {
                Console.WriteLine("==========department=========");
                foreach (var item in student)
                    Console.WriteLine(item);
            }
            var result0904 = students09.leftouterjoin(departments, std => std.dep_id, dep => dep.Id, std => new studentDTO
            {
                Name = std.firstName + " " + std.secondName
            });
            Console.WriteLine("the following students has no department yet:");
            foreach(var student in result0904)
                Console.WriteLine(student);
            var result0905 = (from std in students09
                             join dep in departments
                             on std.dep_id equals dep.Id into stdgroup
                             from dept in stdgroup.DefaultIfEmpty()
                             select new studentDTO
                             {
                                 Name = std.firstName + " " + std.secondName,
                                 Department = dept?.Name ?? "unknown"
                             }).Where(x=>x.Department == "unknown");
            Console.WriteLine("the following students has no department yet:");
            foreach (var student in result0905)
                Console.WriteLine(student);
            //10-Generation Operations
            Console.WriteLine("=============={10}=============");
            var result1001 = Enumerable.Range(0, students09.Count);
            foreach(var i in result1001)
                Console.Write($" {i}");
            Console.WriteLine("\n==============================");
            var result1002 = DateTime.Now.Daterange(DateTime.Now.AddDays(10));
            foreach (var date in result1002)
                Console.WriteLine(date);
        }
        static void PrintArrayOfStudents(student[] s)
        {
            foreach (var student in s)
                Console.WriteLine(student);
        }
        static void incrementing_integers(ref int val)
        { val++; }
        static void filter_print<T>(List<T> s)
        { 
            Console.WriteLine("filter function results:");
            foreach(var i in s) 
                Console.WriteLine(i);
            Console.WriteLine("--------------------");
        }
    }
    public static class extentions
    {
        public static List<DateTime> Daterange(this DateTime d1,DateTime d2)
        {
            List<DateTime> result = new List<DateTime>();
            while(d1.Month!=d2.Month|| d1.Day!= d2.Day)
            {
                    result.Add(d1);
                    d1=d1.AddDays(1);
            }
            return result;
        }
        public static List<studentDTO> leftouterjoin(this List<student> list1, List<Department> list2, Func<student, int> func1, Func<Department, int> func2, Func<student, studentDTO> result)
        {
            if (list1 == null && list2 == null)
                return new() { };
            List<studentDTO> resultlist = new List<studentDTO>();
            for (int i = 0;i<list1.Count;i++)
                for (int j = 0;j<list2.Count;j++)
                {
                    if (list1[i].dep_id == list2[j].Id)
                        break;
                    if(j== list2.Count-1)
                        resultlist.Add(result(list1[i]));
                }
            return resultlist;
        }
        public static List<int> Odd_Numbers_Filter(this List<int> l)
        {
            List<int> odd = new List<int>();
            foreach (int i in l)
            {
                if (i % 2 == 1)
                    odd.Add(i);
            }
            return odd;
        }
        public static List<string> filter(this IEnumerable<string> s,Func<string,bool> condition)
        {
            List<string> filtered_elements=new List<string>();
            foreach (var i in s)
            {
                if (condition(i))
                    filtered_elements.Add(i);
            }
            return filtered_elements;
        }

    }
}