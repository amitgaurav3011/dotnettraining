using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsIsoperator
{ 
    class Apples { }
    class Orenges { }
    class Program
    {
        static void Main(string[] args)
        {
            object[] obj = new object[5];
            obj[0] = new Apples();
            obj[1] = new Orenges();
            obj[2] = "Hello";
            obj[3] = null;
            obj[4] = 134.45;

            for(int i = 0; i < 5; i++)
            {
                string s = obj[i] as string;

                if(s is string)
                {
                    Console.WriteLine(" string "+ s );
                }
                else
                {
                    Console.WriteLine("not a string");
                }
            }

            Console.ReadLine();



        }
    }
}
