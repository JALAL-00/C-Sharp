using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Double to Intger
            double a = 3.14;
            int b = Convert.ToInt32(a);

            //intger To Double
            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;

            //Integer to string---> Can't covert
            int e = 5;
            string f = Convert.ToString(e);

            //String to Char
            string g = "$";
            char h = Convert.ToChar(g);

            //String to Boolean
            string i = "True";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b);
            Console.WriteLine(b.GetType());
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());
            Console.WriteLine(g);
            Console.WriteLine(g.GetType());
            Console.WriteLine(i);
            Console.WriteLine(i.GetType());
        }
    }
}
