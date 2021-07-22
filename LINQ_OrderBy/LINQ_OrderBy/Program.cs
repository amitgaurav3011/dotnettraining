using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,23,34,12,67,78,27 };

            // Query for ascending sort.
            IEnumerable<int> sortAscendingQuery =
                from n in nums
                orderby n descending //"ascending" is default 
                select n;

            //Lambda equivalent of the ascending query
            IEnumerable<int> sortAscendingLambda = nums.OrderBy(n => n);

            //Lambda equivalent of descending           
            IEnumerable<int> sortDescendingLambda = nums.OrderByDescending(n => n);


            // Query for descending sort.
            IEnumerable<string> sortDescendingQuery =
                from w in fruits
                orderby w descending
                select w;

            // Execute the query.
            Console.WriteLine("Ascending:");
            foreach (string s in sortAscendingQuery)
            {
                Console.WriteLine(s);
            }

            // Execute the query.
            Console.WriteLine(Environment.NewLine + "Descending:");
            foreach (string s in sortDescendingQuery)
            {
                Console.WriteLine(s);
            }



            // Execute the query.
            Console.WriteLine("Ascending Lambda:");
            foreach (string s in sortAscendingLambda)
            {
                Console.WriteLine(s);
            }

            // Execute the query.
            Console.WriteLine(Environment.NewLine + "Descending Lambda:");
            foreach (string s in sortDescendingLambda)
            {
                Console.WriteLine(s);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
    

