using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = x + y;
            int age = 23;
            double height = 300.5;
            bool alive = true;
            char symbol = '@';
            string name = "JALAL";
            
            System.Console.WriteLine("Your age is: " + age);
            System.Console.WriteLine("Your height is: " + height + "cm");
            System.Console.WriteLine("Are you alive: " + alive);
            System.Console.WriteLine("Your symbol is: " + symbol);
            System.Console.WriteLine("Your name is: " + name);
            System.Console.WriteLine("Total sum is: " + z);
        }
    }
}
