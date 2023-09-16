using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = 2;
            switch (num)
            {
                case 1:
                    Console.WriteLine("Saturday");
                    break;
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Thuesday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Thursday");
                    break;
                case 7:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Invalid week number ");
                    break;
            }
            */

            Console.WriteLine("Enter age for check for voting");
            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case 15:
                    Console.WriteLine("You are not eligible for vote");
                    break;
                case 16:
                    Console.WriteLine("You are not eligible for vote");
                    break;
                case 17:
                    Console.WriteLine("You are not eligible for vote");
                    break;
                case 18:
                    Console.WriteLine("You are eligible for vote");
                    break;
                default:
                    Console.WriteLine("Invlid age");
                    break;
            }
        }
    }
}
