using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            string b = (a > 10) ? "A is greater " : "A is lesser";
            Console.WriteLine(b);
        }
    }
}
