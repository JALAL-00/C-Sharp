using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_OR_Function
{
    internal class Program
    {
        //public void show() // Declaring method. //Non static - Instance method
        //{
        //    Console.WriteLine("Hello this is my first Method call");
        //    Console.WriteLine("i hope it will work");
        //}
        //---------------------------------------------------------------------------//

        //public static void show1() // Declaring method. // static 
        //{
        //    Console.WriteLine("Hello this is my first Method call");
        //    Console.WriteLine("i hope it will work");
        //}
        //---------------------------------------------------------------------------//

        //public static void Add(int a, int b) // Perameterize Method -1 
        //{
        //    int result = a + b;
        //    Console.WriteLine("The Addition is: "+ result);
        //}
        //---------------------------------------------------------------------------//


        //public static void Name(string name) // Perameterize Method -2
        //{
        //    Console.WriteLine("Your name is: "+name);
        //}
        //---------------------------------------------------------------------------//

        //public static void Name(string name="Rakib") //Defult Perameterize Method -3
        //{
        //    Console.WriteLine("Your name is: " + name);
        //}
        //---------------------------------------------------------------------------//

        //public static void Show_Name_Age(String name, int age) // Name Age argument
        //{
        //    Console.WriteLine("Your name is: "+ name);
        //    Console.WriteLine("Your age is: " + age);

        //}
        //---------------------------------------------------------------------------//

        //Return type Method

        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static void Main(string[] args)
        {
            //Program P1 = new Program(); //Object creation // For non-static 
            //P1.show(); //call
            //--------------------------------------//

            //Program.show1(); //Call For static // In static don't need make Object
            //--------------------------------------//

            //Program.Add(10, 20); //Call For Perameterize Method
            //Program.Add(100, 200);
            //--------------------------------------//

            //Console.Write("Enter first number: ");
            //int First = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second number: ");
            //int Second = int.Parse(Console.ReadLine());
            //Program.Add(First, Second); //Call For Perameterize Method -1
            //--------------------------------------//

            //Program.Name("JALAL"); //Call For Perameterize Method -2
            //--------------------------------------//

            //Program.Name(); //Defult Perameterize Method -3
            //--------------------------------------//

            //Program.Show_Name_Age("Jalal", 23); //Call Name Age argument
            //Program.Show_Name_Age(age: 23, name: "Jalal"); // If i swap data Value
            //--------------------------------------//

            int z = Program.Add(10, 20)
            Console.WriteLine("Addition is: "+ z);


        }
    }
}
