using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcccessSpecifier
{    
    class Bicycle
    {
        private int wheels = 2;

        protected internal int Wheels
        {
            get { return wheels; }
        }
    }

    class C1
    {
        public int n;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();
            Console.WriteLine("No of Wheels =" + bicycle.Wheels);

            C1 c = new C1();
            c.n = 23;
            int m = c.n;

            ArrayList list = new ArrayList();
            list.Add(m);

            Console.WriteLine(list[0]);
            m = (int)list[0];

            Console.WriteLine(m);
            Console.ReadLine();
        }
    }
}
