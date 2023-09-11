using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 20;

            if(x > 10)
            {
                Console.WriteLine("Yes! it is true");
            }
            else
            {
                Console.WriteLine("It is false");
            }
            */

            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            if (name == "JALAL")
            {
                Console.WriteLine("Welcome JALAL");
            }
            else
            {
                Console.WriteLine("Who are you ?");
            }
            */

            Console.Write("Enter username: ");
            string UserName = Console.ReadLine();
            Console.Write("Enter password: ");
            string Password = Console.ReadLine();

            if (UserName == "JALAL" && Password == "123JALAL")
            {
                Console.WriteLine("Log in sucessfull");
            }
            else
            {
                Console.WriteLine("Incorrect username & password");
            }


        }
    }
}
