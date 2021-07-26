using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    /*class Program
    {
        static void Main(string[] args)
        {

        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello.My name is Jeff");
            sb.Replace(".", "!");
            Int32 index = sb.IndexOf('!');
            Console.WriteLine(index);


            int i = 15;
            int j = 34;
            if (i.isLessThan(j))
            {
                Console.WriteLine("\ni is less than j");
            }
            else
            {
                Console.WriteLine("\ni is not less than j");
            }
            Console.ReadLine();


        }
    }

    public static class StringBuilderExtensions
    {
        public static int IndexOf(this StringBuilder sb, Char value)
        {
            for (int index = 0; index < sb.Length; index++)
            {
                if (sb[index] == value) return index;


            }
            return -1;
        }
    }

    public static class intExtension
    {
        public static bool isLessThan(this int i,int v)
        {
            if (i < v)
            {
                return true;
            }
            else return false;
        }
    }

}
