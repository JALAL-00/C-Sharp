using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor_24
{
    class person
    {
        public static string PersonName;
        public static int PersonAge;

        static person()
        {
            PersonName = "Jalal";
            PersonAge = 23;
            Console.WriteLine("Static constructor invoked!!");
        }
        public person()
        {
            Console.WriteLine("default constructor invoked!!");
        }
        public void getDetails()
        {
            Console.WriteLine("person name is: "+ PersonName);
            Console.WriteLine("person age is: " + PersonAge);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person jalal = new person();
            jalal.getDetails();
        }
    }
}
