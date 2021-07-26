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
                orderby n  //"ascending" is default 
                select n;

            //Lambda equivalent of the ascending query
            IEnumerable<int> sortAscendingLambda = nums.OrderBy(n => n);

            //Lambda equivalent of descending           
            IEnumerable<int> sortDescendingLambda = nums.OrderByDescending(n => n);


            // Query for descending sort.
            IEnumerable<int> sortDescendingQuery =
                from w in nums
                orderby w descending
                select w;

            // Execute the query.
            Console.WriteLine("Ascending:");
            foreach (int i in sortAscendingQuery)
            {
                Console.WriteLine(i);
            }

            // Execute the query.
            Console.WriteLine(Environment.NewLine + "Descending:");
            foreach (int i in sortDescendingQuery)
            {
                Console.WriteLine(i);
            }



            // Execute the query.
            Console.WriteLine("Ascending Lambda:");
            foreach (int i in sortAscendingLambda)
            {
                Console.WriteLine(i);
            }

            // Execute the query.
            Console.WriteLine(Environment.NewLine + "Descending Lambda:");
            foreach (int i in sortDescendingLambda)
            {
                Console.WriteLine(i);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
    

