using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day: ");
            string Day = Console.ReadLine();
            switch (Day)
            {
                case "Saturday":
                    Console.WriteLine("It's Saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday");
                    break;
                case "Monday":
                    Console.WriteLine("It's Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday");
                    break;
                default :
                    Console.WriteLine(Day+"is not a day! ");
                    break;
            }

        }
    }
}
