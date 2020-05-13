using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListofObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://dzone.com/articles/different-ways-of-creating-list-of-objects-in-c
            //declare a list of object and add existing object to list
            var stdlist = new List<Student>();

            //simple used, initialize a new instance
            Console.WriteLine("==Ex1: Simple used, initialize a new instance");
            Student student1 = new Student()
            {
                StudentID = 1,
                StudentName = "Bill",
                Age = 20,
                Address = "New York"
            };

            Console.WriteLine("ID: " + student1.StudentID);
            Console.WriteLine("Name: " + student1.StudentName);
            Console.WriteLine("Age: " + student1.Age);
            Console.WriteLine("Add: " + student1.Address);

            stdlist.Add(student1);

            Console.WriteLine("ID: " + stdlist[0].StudentID);
            Console.WriteLine("Name: " + stdlist[0].StudentName);
            Console.WriteLine("Age: " + stdlist[0].Age);
            Console.WriteLine("Add: " + stdlist[0].Address);

            //
            Console.WriteLine("==Ex2: initialize a new instance");
            var student2 = new Student() { StudentID = 2, StudentName = "John" };
            var student3 = new Student() { StudentID = 3, StudentName = "Steve" };
            var student4 = new Student() { StudentID = 4, StudentName = "Harry" };
            var student5 = new Student() { StudentID = 5, StudentName = "Lion" };
            var student6 = new Student() { StudentID = 6, StudentName = "Ron" };

            stdlist = new List<Student>() {
                                            student2,
                                            student3,
                                            student4,
                                            student5,
                                            student6
                                        };

            for (int i = 0; i < stdlist.Count(); i++)
            {
                Console.WriteLine("ID: " + stdlist[i].StudentID);
                Console.WriteLine("Name: " + stdlist[i].StudentName);
                Console.WriteLine("Age: " + stdlist[i].Age);
                Console.WriteLine("Add: " + stdlist[i].Address);
            }

            //create manual instance of object, using AddRange
            Console.WriteLine("==Ex3: Create manual instance of object, using AddRange");
            stdlist.AddRange(new[] {
                    new Student(),  //empty instance
                    new Student()
            });

            stdlist.AddRange(new[] {
                    new Student(){ StudentID = 6, StudentName = "Tomy" },       //instance with value
                    new Student(){ StudentID = 7, StudentName = "Hennry" }
            });

            for (int i = 0; i < stdlist.Count(); i++)
            {
                Console.WriteLine("ID: " + stdlist[i].StudentID);
                Console.WriteLine("Name: " + stdlist[i].StudentName);
                Console.WriteLine("Age: " + stdlist[i].Age);
                Console.WriteLine("Add: " + stdlist[i].Address);
            }

            //create 5 instance of object, using loop for
            Console.WriteLine("==Ex4: Create 5 instance of object, using loop for");
            int listlen = stdlist.Count();
            for (int i= listlen; i<listlen+5; i++)
            {
                stdlist.Add(new Student());
                stdlist[i].StudentID = 1000 + i;
                stdlist[i].StudentName = "Name" + Convert.ToString(i);
                stdlist[i].Age = 1990 + i;
                stdlist[i].Address = "Address-" + Convert.ToString(i);
            }

            for (int i = 0; i < stdlist.Count(); i++)
            {
                Console.WriteLine("ID: " + stdlist[i].StudentID);
                Console.WriteLine("Name: " + stdlist[i].StudentName);
                Console.WriteLine("Age: " + stdlist[i].Age);
                Console.WriteLine("Add: " + stdlist[i].Address);
            }

            // Create 4 instance of object, using Enumerable.Repeat
            // It will OVERWRITE the list. the first argument is the object we want to create or repeat. The second argument is the number of times we need to repeat the object.
            Console.WriteLine("==Ex5: Create 4 instance of object, using Enumerable.Repeat");
            stdlist = Enumerable.Repeat(new Student(), 4).ToList();
            for (int i = 0; i < stdlist.Count(); i++)
            {
                Console.WriteLine("ID: " + stdlist[i].StudentID);
                Console.WriteLine("Name: " + stdlist[i].StudentName);
                Console.WriteLine("Age: " + stdlist[i].Age);
                Console.WriteLine("Add: " + stdlist[i].Address);
            }

            // and another one is Enumerable.Repeat
            //Range(start, count)
            stdlist = Enumerable.Range(1, 2).Select(i => new Student()).ToList();
            for (int i = 0; i < stdlist.Count(); i++)
            {
                Console.WriteLine("ID: " + stdlist[i].StudentID);
                Console.WriteLine("Name: " + stdlist[i].StudentName);
                Console.WriteLine("Age: " + stdlist[i].Age);
                Console.WriteLine("Add: " + stdlist[i].Address);
            }

        }
}

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

}
