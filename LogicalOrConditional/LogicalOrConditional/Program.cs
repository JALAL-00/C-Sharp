using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Logical operators perform boolean logical operations on both the operands. They return a boolean value based on the logical operator used 
//Conditional AND (&&)
//Conditional OR (||)
namespace LogicalOrConditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30, b = 20;
            //bool c = (a > b) && (b < a); //when a = 10, b = 20; false it should two conditon true
            //bool c = (a > b) && (b < a);  //when a = 30, b = 20; True
            bool c = (a < b) || (a > b); // if one condition true then true 
            Console.WriteLine(c);
        }
    }
}
