using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //public Program()
        //{
        //    Console.WriteLine("default constructor invoks !!");
        //}
        //static void main(string[] args)
        //{
        //    Program p = new Program();

        //}

        //Parameterize Constructor

        int id;
        string name;
        int age;
        public Program(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public int getId()
        {
            return this.id;
        }
        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }

        static void Main(string[] args)
        {
            Program Jalal = new Program(12, "Jalal", 23);
            Console.WriteLine(Jalal.getId());
            Console.WriteLine(Jalal.getName());
            Console.WriteLine(Jalal.getAge());
        }
    }
}
