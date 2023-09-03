using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine();

            Console.WriteLine("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your are " + age + " Old");
        }
    }
}
