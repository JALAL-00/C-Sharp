using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Jalal code";
            string PhoneNumber = "123-456-789";
            FullName = FullName.ToUpper();
            FullName = FullName.ToLower();
            PhoneNumber = PhoneNumber.Replace("-", "/");
            string UserName = FullName.Insert(0, "Mr.");
            string FirstName = FullName.Substring(0, 5);
            string LastName = FullName.Substring(6, 4);

            Console.WriteLine(FullName);
            Console.WriteLine(FullName);
            Console.WriteLine(PhoneNumber);
            Console.WriteLine(UserName);
            Console.WriteLine(FullName.Length);
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);

        }
    }
}
