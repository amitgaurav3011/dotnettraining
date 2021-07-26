using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetAsync();
            Console.ReadLine();
        }

        static async void GreetAsync()
        {
            Console.WriteLine("Before GetGreet Method");

            Task<string> task = GetGreetingsAsync();
            

            Console.WriteLine("please Wait....");

            string s = await task;

            Console.WriteLine(s);

            
        }

        public async static Task<string> GetGreetingsAsync()
        {
            Console.WriteLine("start of GetGreetings");
            //simulate long running process
            await Task.Delay(10000);
            Console.WriteLine("GetGreetings is about to return");
            return "Welcome to Async C# Demo!";
        }
    }
}
