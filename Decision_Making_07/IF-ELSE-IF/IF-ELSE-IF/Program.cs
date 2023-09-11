using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your percentage: ");
            int Percentage = Convert.ToInt32(Console.ReadLine());

            if(Percentage >= 80)
            {
                Console.WriteLine("Grade is: A+");
            }
            else if (Percentage >= 70)
            {
                Console.WriteLine("Grade is: A");
            }
            else if (Percentage >= 60)
            {
                Console.WriteLine("Grade is: B");
            }
            else if (Percentage >= 50)
            {
                Console.WriteLine("Grade is: C");
            }
            else if (Percentage >= 40)
            {
                Console.WriteLine("Grade is: D");
            }
            else if (Percentage >= 30){ 
                Console.WriteLine("Grade is: E");
            }
            else
            {
                Console.WriteLine("Grade is: F (Fail)");
            }
        }
    }
}
