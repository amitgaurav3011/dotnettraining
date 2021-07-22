using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LINQ_SQO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings1 = {"jasd","sdsd","sdsd","jsds","jasas","scvdf" };

            List<string> strings = new List<string>();
            strings.AddRange(strings1);

            var stringGroups =
                from s in strings
                group s by s[0] into g
                select new { FirstAlphabet = g.Key, word = g };

            //The Lambda equivalent
            var stringGroupsLambda =
                strings.GroupBy(s => s[0])
                        .Select(g => new { FirstAlphabet = g.Key, word = g });

            foreach (var x in stringGroups)
            {
                Console.WriteLine("strings starting with {0} :", x.FirstAlphabet);
                foreach (var n in x.word)
                {
                    Console.WriteLine(n);
                }
            }

            Console.WriteLine("Using Lambda Expression");
            foreach (var y in stringGroupsLambda)
            {
                Console.WriteLine("strings starting with {0} :", y.FirstAlphabet);
                foreach (var n in y.word)
                {
                    Console.WriteLine(n);
                }
            }



            Console.ReadLine();
        }
    }
}
    

