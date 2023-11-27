/*
using System;

namespace Dynamic_Polymorphism_30
{
    internal class Program
    {
        abstract class Shape
        {
            public abstract int Area();
        }
        class Rectangle : Shape
        {
            private int length;
            private int weigth;

            public Rectangle(int a, int b)
            {
                length = a;
                weigth = b;
            }
            public override int Area()
            {
                Console.WriteLine("Rectangle class Area: ");
                return (weigth * length);
            }

        }
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle(10, 7);
            double a = R.Area();
            Console.WriteLine("Area: "+ a);
        }
    }
}
*/


using System;

namespace PolymorphismApplication
{
    class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int area()
        {
            Console.WriteLine("Parent class area :");
            return 0;
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }
    }
    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        public override int area()
        {
            Console.WriteLine("Triangle class area :");
            return (width * height / 2);
        }
    }
    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);

            c.CallArea(r);
            c.CallArea(t);
            Console.ReadKey();
        }
    }
}