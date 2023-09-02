using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Decrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            //Console.WriteLine(a++); // Post increment, Output = 5
            //Console.WriteLine(a); // Output 6

            //Console.WriteLine(a--); // Post Decrement, Output = 5 CZ 1st no change 
            //Console.WriteLine(a); // Output 4

            //Console.WriteLine(++a); // pre increment, Output = 6;
            //Console.WriteLine(a); // Output = 6, CZ already Increment 

            Console.WriteLine(--a); // pre Decrement, Output = 4;
            Console.WriteLine(a); // Output = 4, CZ already Increment
        }
    }
}
