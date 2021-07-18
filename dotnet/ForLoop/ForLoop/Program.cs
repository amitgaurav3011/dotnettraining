using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1,j=6;

            while (i <= 7 && j >= 0)
            {
                string s="";

                for(int x = 1; x <= i; x++)
                {
                    s += x;
                }
                for(int x = 1; x <= j; x++)
                {
                    s += "*";
                }

                i++;j--;
                Console.WriteLine("\n" + s);

            }

            Console.ReadLine();
        }
    }
}
