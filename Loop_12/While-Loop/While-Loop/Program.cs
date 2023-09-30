using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0; //Initialization
            //while (i < 10) //Condition
            //{
            //    Console.WriteLine(i);
            //    i++; //Increment
            //}
            //Console.WriteLine("While loop terminate");

            //int num = 2;
            //int i = 0;
            //while(i < 10)
            //{
            //    Console.WriteLine(num + " X " + i + " = " + num * i );
            //    i++;
            //}
            //Console.WriteLine("While loop terminate");

            int i = 1;
            while( i < 0)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
