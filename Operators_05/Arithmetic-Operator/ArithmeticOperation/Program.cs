using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c, d, e, f;
            c = a + b;
            d = b - a;
            e = a * b;
            f = a / b;
            Console.WriteLine("Addition is: " + c);
            Console.WriteLine("Subtration is: " + d);
            Console.WriteLine("Multiplication is: " + e);
            Console.WriteLine("Devision is: " + f);


            //int Friends = 10;

            //Friends = Friends + 1;
            //Friends += 1;
            //Friends++;

            //Friends = Friends - 1;
            //Friends -= 1;
            //Friends--;

            //Friends = Friends * 2;
            //Friends *= 2;
            //Friends * *;

            //Friends = Friends / 2;
            //Friends /=2;

            //int reminder = Friends % 3;

            //Console.WriteLine(Friends);
            //Console.WriteLine(reminder);
        }
    }
}
