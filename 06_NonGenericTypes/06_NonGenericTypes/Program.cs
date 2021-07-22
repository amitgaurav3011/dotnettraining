using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_NonGenericTypes
{
    using System;
    using System.Collections;
    using System.Linq;

    namespace NonGenericLINQ
    {
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int[] Scores { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                ArrayList arrList = new ArrayList();
                arrList.Add(
                    new Student
                    {
                        FirstName = "Svetlana",
                        LastName = "Omelchenko",
                        Scores = new int[] { 98, 92, 81, 60 }
                    });
                arrList.Add(
                    new Student
                    {
                        FirstName = "Claire",
                        LastName = "O’Donnell",
                        Scores = new int[] { 75, 84, 91, 39 }
                    });
                arrList.Add(
                    new Student
                    {
                        FirstName = "Sven",
                        LastName = "Mortensen",
                        Scores = new int[] { 88, 94, 65, 91 }
                    });
                arrList.Add(
                    new Student
                    {
                        FirstName = "Cesar",
                        LastName = "Garcia",
                        Scores = new int[] { 97, 89, 85, 82 }
                    });

                var query = from Student student in arrList
                            where student.LastName[0] =='O'
                            select student;


                foreach (Student s in query)
                    Console.WriteLine(s.FirstName + " " + s.LastName);

                //If you are determined to use Lambda expression this is the way to go
                var subSetList = (arrList.Cast<Student>()
                                                      .Where(s => s.LastName[0] == 'O')
                                                      .ToList());

                Console.WriteLine("Let us see things the lambda way");

                foreach (Student s in subSetList)
                    Console.WriteLine(s.FirstName + " " + s.LastName);

                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
