using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Break statements

            //for(int i =0; i< 10; i++)
            //{
            //    if(i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Loop Terminate");

            //--------------------------------------//

            //Continue statements

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Loop Terminate");

            //-----------------------------------------//

            //Odd no check

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Loop Terminate");

            //-------------------------------------------//

            //even no check
            //for (int i = 1; i < 10; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Loop Terminate");

            //------------------------------------------//
            //goto statements
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    goto stop;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Loop Terminate");

            stop:
            Console.WriteLine("Program exit");

        }
    }
}
