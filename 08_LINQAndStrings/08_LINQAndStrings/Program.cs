using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_LINQAndStrings
{
    class CountWords
    {
        static void Main()
        {
            string text = "Welcome to LINQ. LINQ provides lots of features";

            char  searchitem= 'e';

            //Convert the string into an array of words 
            
            // Create the query.  Use ToLowerInvariant to match "data" and "Data"  
            var matchQuery = from char ch in text
                             where ch==searchitem
                             select ch;

            var matchQueryLambda = text.Where(ch => ch==searchitem);

            // Count the matches, which executes the query. 
            int charCount = matchQuery.Count();
            Console.WriteLine(charCount);

            //foreach (string w in matchQuery)
            //{
             //   Console.WriteLine(w);
            //}

            // Count the matched, with the Lambda query
            int charCountLambda = matchQueryLambda.Count();

            Console.WriteLine("using lambda query: "+charCountLambda);

            // Keep console window open in debug mode
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
