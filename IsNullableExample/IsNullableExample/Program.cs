using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNullableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double? pi = 3.14;
            char? letter = 'a';

            int m2 = 10;
            int? m = m2;

            bool? flag = null;

            // An array of a nullable value type:
            int?[] arr = new int?[10];

            //Examination of an instance of a nullable value type
            int? a = null;
            if (a is int valueOfA)
            {
                Console.WriteLine($"a is {valueOfA}");
            }
            else
            {
                Console.WriteLine("a does not have a value");
            }

            //using hasvalue
            int? b = 12;
            if (b.HasValue)
            {
                Console.WriteLine($"b is {b.Value}");
            }
            else
            {
                Console.WriteLine("b does not have a value");
            }

            //you can also use null
            int? c = 7;
            if (c != null)
            {
                Console.WriteLine($"c is {c.Value}");
            }
            else
            {
                Console.WriteLine("c does not have a value");
            }
            // Output:
            // c is 7

            //Conversion from nullable value type to an underlying type
            //?? coalesce operator
            int? a1 = 28;
            int b1 = a1 ?? -1;
            Console.WriteLine($"b1 is {b1}");  // output: b1 is 28

            int? c1 = null;
            int d = c1 ?? -1;
            Console.WriteLine($"d is {d}");  // output: d is -1

            //How to identify nullable type
            Console.WriteLine($"int? is {(IsNullable(typeof(int?)) ? "nullable" : "non nullable")} value type");
            Console.WriteLine($"int is {(IsNullable(typeof(int)) ? "nullable" : "non-nullable")} value type");

            bool IsNullable(Type type) => Nullable.GetUnderlyingType(type) != null;

            // Output:
            // int? is nullable value type
            // int is non-nullable value type

            Console.ReadLine();
        }
    }
}
