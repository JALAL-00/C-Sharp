using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] {{ 1,2,3},{2,3,4 },{5,6,7}};
            for(int i =0; i<3; i++)
            {
                for(int j =0; j<3; j++)
                {
                    Console.WriteLine(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
