using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESTED_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 2;
            if (a > 5)
            {
                if(a == 10)
                {
                    Console.WriteLine("A is equal to 10");
                }
                else
                {
                    Console.WriteLine("A is not equal to 10");
                }
            }
            else
            {
                if( a == 3)
                {
                    Console.WriteLine("A is 3");
                }
                else
                {
                    Console.WriteLine("A is not 3");
                }
            }
            */
            //Log in system

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            if(email == "jalal012@gmail.com")
            {
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                if(password == "jalal1234")
                {
                    Console.WriteLine("Log in sucessfull");
                }
                else
                {
                    Console.WriteLine("Invalid password");
                }
            }
            else
            {
                Console.WriteLine("Invalid email");
            }
        }
    }
}
