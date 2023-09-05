using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Relational or comparison operators 
//Relation operator make a comparision between two operands and return a boolean value, True of false
// ==, !=, >, <, >=, <=

namespace Relational
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            //bool c = a == b; when a = 10, b = 20, c = false
            //bool c = a == b; when a = 20, b = 20, c = true
            //bool c = a != b; when a = 20, b = 20, c = false
            //bool c = a > b; when a = 20, b = 20, c = false
            //bool c = a < b; when a = 20, b = 20, c = false
            //bool c = a > b; when a = 10, b = 20, c = false
            //bool c = a < b; when a = 10, b = 20, c = true
            //bool c = a <= b; when a = 10, b = 20, c = true
            //bool c = a >= b; when a = 10, b = 20, c = false
            bool c = a == b;
            Console.WriteLine(c);
        }
    }
}
