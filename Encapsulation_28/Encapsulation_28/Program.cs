/*
Public Access Modifier
using System;

namespace Encapsulation_28
{
    internal class Program
    {
        public class Ractengle
        {
            public double length;
            public double weigth;

            public double getArea()
            {
                return length * weigth;
            }

            public void Display()
            {
                Console.WriteLine("Lenth is "+ length);
                Console.WriteLine("weigth is " + weigth);
                Console.WriteLine("Area is " + getArea());
            }
        }
        static void Main(string[] args)
        {
            Ractengle R = new Ractengle();
            R.length = 4.5;
            R.weigth = 3.5;
            R.Display();
        }
    }
}
*/


/*
Private Access Modifier
using System;

namespace Encapsulation_28
{
    internal class Program
    {
        public class Ractengle
        {
            private double length;
            private double weigth;

            public void AcceptDetails()
            {
                Console.Write("Enter length: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter weigth: ");
                weigth = Convert.ToDouble(Console.ReadLine());
            }
            public double getArea()
            {
                return length * weigth;
            }

            public void Display()
            {
                Console.WriteLine("Lenth is " + length);
                Console.WriteLine("weigth is " + weigth);
                Console.WriteLine("Area is " + getArea());
            }
        }
        static void Main(string[] args)
        {
            Ractengle R = new Ractengle();
            R.AcceptDetails();
            R.Display();
        }
    }
}
*/


using System;

namespace Encapsulation_28
{
    internal class Program
    {
        public class Ractengle
        {
            public double length;
            public double weigth;

            double getArea()
            {
                return length * weigth;
            }

            public void Display()
            {
                Console.WriteLine("Lenth is " + length);
                Console.WriteLine("weigth is " + weigth);
                Console.WriteLine("Area is " + getArea());
            }
        }
        static void Main(string[] args)
        {
            Ractengle R = new Ractengle();
            R.length = 4.5;
            R.weigth = 3.5;
            R.Display();
        }
    }
}

/*
SIn the preceding example, notice that the member function GetArea()
is not declared with any access specifier.
Then what would be the default access specifier of a class member
if we don't mention any? It is private.
*/