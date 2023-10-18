using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[5] { 1, 2, 3, 4, 5 };
            arr[1] = new int[3] { 1, 2, 3 };

            for(int i =0; i< arr.Length; i++)
            {
                for(int j = 0; j< arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
