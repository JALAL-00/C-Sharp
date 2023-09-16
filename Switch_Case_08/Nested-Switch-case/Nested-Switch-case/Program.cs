using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your pizza flavour: ");
            string pizza = Console.ReadLine();

            switch (pizza)
            {
                case "Fajita":
                    Console.WriteLine("You have selected Fajita pizza");
                    break;
                case "Supreme":
                    Console.WriteLine("You have selected Supreme pizza");
                    break;
                case "Cheese":
                    Console.WriteLine("You have selected Fajita Cheese");
                    break;
                case "Vegetable":
                    Console.Write("Enter your Vegetable: ");
                    string veg = Console.ReadLine();

                    switch (veg)
                    {
                        case "Olives":
                            Console.WriteLine("ou have selected Olives in your pizza");
                            break;
                        case "Onions":
                            Console.WriteLine("ou have selected Onions in your pizza");
                            break;
                        case "Mushrooms":
                            Console.WriteLine("ou have selected Mushrooms in your pizza");
                            break;
                        default:
                            Console.WriteLine();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Pizza Flavour not available");
                    break;
            }
        }
    }
}
