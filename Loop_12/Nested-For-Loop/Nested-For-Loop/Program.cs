using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i =0; i<3; i++)
            {
                Console.WriteLine("Hello");
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Hay");
                }
            }
            
        }
    }
}
