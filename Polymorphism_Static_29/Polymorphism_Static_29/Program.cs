/*
Method overloading
using System;

namespace Polymorphism_Static_29
{
    public class PrintData
    {
        public void Print(int i)
        {
            Console.WriteLine("Print int: " + i);
        }

        public void Print(double f)
        {
            Console.WriteLine("Print float: " + f);
        }

        public void Print(string s)
        {
            Console.WriteLine("Print string: " + s);
        }
        static void Main(string[] args)
        {
            PrintData P = new PrintData();
            P.Print(10);

            P.Print(3.10);

            P.Print("JALAL");
        }
    }
}
*/



//Operator Overloading
using System;

namespace Polymorphism_Static_29
{
    public class PrintData
    {
        public string str;
        public int num;

        public static PrintData operator +(PrintData obj1 , PrintData obj2)
        {
            PrintData obj3 = new PrintData();
            obj3.str = obj1.str +" "+ obj2.str;
            obj3.num = obj1.num + obj2.num;
            return obj3;
        }
        static void Main(string[] args)
        {
            PrintData obj1 = new PrintData();
            obj1.str = "Mohammad";
            obj1.num = 20;

            PrintData obj2 = new PrintData();
            obj2.str = "Jalal";
            obj2.num = 30;

            PrintData obj3 = new PrintData();
            obj3 = obj1 + obj2;

            Console.WriteLine(obj3.str);
            Console.WriteLine(obj3.num);
        }
    }
}


