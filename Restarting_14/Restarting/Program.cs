using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restarting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string confirm;
            //do
            //{
            //    Console.Write("Enter 1st no: ");
            //    int no1 = int.Parse(Console.ReadLine());
            //    Console.Write("Enter 2nd no: ");
            //    int no2 = int.Parse(Console.ReadLine());
            //    int add = no1 + no2;
            //    Console.WriteLine("Addition is: " + add);
            //    Console.Write("Do you want to reapeat ur program? YES/NO: ");
            //    confirm = Console.ReadLine().ToLower();
            //}
            //while (confirm == "yes");

            while (true)
            {
                Console.Write("Enter 1st no: ");
                int no1 = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd no: ");
                int no2 = int.Parse(Console.ReadLine());
                int add = no1 + no2;
                Console.WriteLine("Addition is: " + add);
                Console.Write("Do you want to reapeat ur program? YES/NO: ");
                string confirm = Console.ReadLine().ToLower();

                if(confirm == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            
        }
    }
}
