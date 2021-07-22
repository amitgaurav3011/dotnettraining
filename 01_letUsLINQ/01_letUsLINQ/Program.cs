using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_letUsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = {"hsdghsd","dfgfg","we","wewrwrwr","dfd" };
            

            
            var numberOfExpectedValues = (from i in s
                                          where (i.Length > 3)
                                          select i).Count();

            var numberOfExpectedValuesLambda = s.Count(x => x.Length > 3);


            Console.WriteLine("The result of query expression " + numberOfExpectedValues);

            Console.WriteLine("The result of lambda expression " + numberOfExpectedValuesLambda);

            Console.ReadLine();
        }
    }
}
