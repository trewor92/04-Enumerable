using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Task target = new Task();

            var b = target.GetCommonChars(new string[]  { "ab", "ac", "ad" } );

            foreach (char a in b)
                Console.WriteLine(a);
          /*      
            var e= (new[] { 1, 2, 3 }).Intersect(new[] { 2, 3, 4 });
            foreach (int c in e)
                Console.WriteLine(c);
                */
            Console.ReadLine();

        }

    
    }
}
