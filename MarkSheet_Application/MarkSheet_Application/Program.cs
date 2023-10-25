using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MarkSheet_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name= Console.ReadLine();
            Console.Write("Enter your ID: ");
            string Id = Console.ReadLine();
            Console.Write("Enter your class: ");
            string Class = Console.ReadLine();

            Console.Write("Enter your IP marks: ");
            int IP = int.Parse(Console.ReadLine());
            Console.Write("Enter your Math marks: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Enter your Physics marks: ");
            int P = int.Parse(Console.ReadLine());
            Console.Write("Enter your English marks: ");
            int E = int.Parse(Console.ReadLine());
            Console.Write("Enter your OOP-1 marks: ");
            int O = int.Parse(Console.ReadLine());

            int ObtainMark = IP + M + P + E + O;
            int percentage = ObtainMark * 100 / 500;

            Console.WriteLine("--------MARKSHEET--------");
            Console.WriteLine("Your name is: "+name);
            Console.WriteLine("Your ID is: " + Id);
            Console.WriteLine("Your Class is: " + Class);
            Console.WriteLine();
            Console.WriteLine("Your obtain Mark is : "+ ObtainMark);
            Console.WriteLine("Your obtain Mark percentage is : " + percentage);

            //IF-ELSE-IF Statement

            if(percentage >= 90)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (percentage >= 85)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (percentage >= 75)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Grade: C+");
            }
            else if (percentage >= 65)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade: D+");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Grade: D");
            }
            else if (percentage <= 50)
            {
                Console.WriteLine("Grade: F");
            }

            //int supply = 0;
            //int ObtainMark = IP + M + P + E + O;

            if (IP < 50)
            {
                //supply++;
                Console.WriteLine("You have supply in IP");
            }
            if (M < 50)
            {
                //supply++;
                Console.WriteLine("You have supply in Math");
            }
            if (P < 50)
            {
                //supply++;
                Console.WriteLine("You have supply in Physics");
            }
            if (E < 50)
            {
                //supply++;
                Console.WriteLine("You have supply in English");
            }
            if (O < 50)
            {
                //supply++;
                Console.WriteLine("You have supply in OOP-1");
            }
            //Console.WriteLine("You are a failed in {0} subjects  "+supply);

        }
    }
}
