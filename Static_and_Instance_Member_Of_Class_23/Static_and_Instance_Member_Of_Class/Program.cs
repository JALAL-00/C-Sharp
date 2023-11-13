
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_Instance_Member_Of_Class
{
    internal class Program
    {
        //class student
        //{
        //    public int rollno;
        //}
        //static void Main(string[] args)
        //{
        //    student s = new student();
        //    s.rollno = 1;
        //    student j = new student();
        //    j.rollno = 2;

        //    Console.WriteLine(s.rollno + " " + j.rollno);
        //}

        //********************************************//

        //Instance variable
        //class student
        //{
        //    public int rollno;
        //    public string name;
        //    public int age;
        //    public int Class;
        //}
        //static void Main(string[] args)
        //{
        //    student s = new student();
        //    s.rollno = 1;
        //    s.name = "sahed";
        //    s.age = 20;
        //    s.Class = 9;


        //    student j = new student();
        //    j.rollno = 2;
        //    j.name = "Jalal";
        //    j.age = 23;
        //    j.Class = 10;

        //    Console.WriteLine(s.rollno);
        //    Console.WriteLine(s.name);
        //    Console.WriteLine(s.age);
        //    Console.WriteLine(s.Class);

        //    Console.WriteLine("------------------------------");

        //    Console.WriteLine(j.rollno);
        //    Console.WriteLine(j.name);
        //    Console.WriteLine(j.age);
        //    Console.WriteLine(j.Class);
        //}

        //********************************************//

        ////Instance Method
        //class student
        //{

        //    public int rollno;
        //    public string FirstName;
        //    public string LastName;
        //    public int Class;

        //    public void PrintFullName()
        //    {
        //        string fullname = this.FirstName + " " + this.LastName;
        //        Console.WriteLine("Your full name is {0}", fullname);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    student s = new student();
        //    s.rollno = 1;
        //    s.FirstName = "sahed";
        //    s.LastName = "Khan";
        //    s.Class = 9;


        //    student j = new student();
        //    j.rollno = 2;
        //    j.FirstName = "Jalal";
        //    j.LastName = "Uddin";
        //    j.Class = 10;

        //    Console.WriteLine(s.rollno);
        //    Console.WriteLine(s.FirstName);
        //    Console.WriteLine(s.LastName);
        //    Console.WriteLine(s.Class);
        //    s.PrintFullName();

        //    Console.WriteLine("------------------------------");

        //    Console.WriteLine(j.rollno);
        //    Console.WriteLine(j.FirstName);
        //    Console.WriteLine(j.LastName);
        //    Console.WriteLine(j.Class);
        //    j.PrintFullName();
        //}


        //********************************************//

        ////static variable 
        //class student
        //{

        //    public int rollno;
        //    public string FirstName;
        //    public string LastName;
        //    public int Class;
        //    public static string SchoolName = "ABC SCHOOL";

        //    public void PrintFullName()
        //    {
        //        string fullname = this.FirstName + " " + this.LastName;
        //        Console.WriteLine("Your full name is {0}", fullname);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    student s = new student();
        //    s.rollno = 1;
        //    s.FirstName = "sahed";
        //    s.LastName = "Khan";
        //    s.Class = 9;


        //    student j = new student();
        //    j.rollno = 2;
        //    j.FirstName = "Jalal";
        //    j.LastName = "Uddin";
        //    j.Class = 10;

        //    Console.WriteLine(s.rollno);
        //    Console.WriteLine(s.FirstName);
        //    Console.WriteLine(s.LastName);
        //    Console.WriteLine(s.Class);
        //    s.PrintFullName();
        //    Console.WriteLine(student.SchoolName);

        //    Console.WriteLine("------------------------------");

        //    Console.WriteLine(j.rollno);
        //    Console.WriteLine(j.FirstName);
        //    Console.WriteLine(j.LastName);
        //    Console.WriteLine(j.Class);
        //    j.PrintFullName();
        //    Console.WriteLine(student.SchoolName);
        //}

        //********************************************//

        //static Method 
        class student
        {

            public int rollno;
            public string FirstName;
            public string LastName;
            public int Class;
            public static string SchoolName = "ABC SCHOOL";
            public static int fees= 4000;

            public void PrintFullName()
            {
                string fullname = this.FirstName + " " + this.LastName;
                Console.WriteLine("Your full name is {0}", fullname);
            }

            public static int getFees()
            {
                return fees;
            }
            public static int getFeesAnnualIncrement()
            {
                return fees / 10;
            }
            public static int getFeesAnnualIncrement(int fee)
            {
                return fee / 10;
            }
        }
        static void Main(string[] args)
        {
            student s = new student();
            s.rollno = 1;
            s.FirstName = "sahed";
            s.LastName = "Khan";
            s.Class = 9;


            student j = new student();
            j.rollno = 2;
            j.FirstName = "Jalal";
            j.LastName = "Uddin";
            j.Class = 10;

            Console.WriteLine(s.rollno);
            Console.WriteLine(s.FirstName);
            Console.WriteLine(s.LastName);
            Console.WriteLine(s.Class);
            s.PrintFullName();
            Console.WriteLine(student.SchoolName);
            Console.WriteLine(student.getFees());
            Console.WriteLine(student.getFeesAnnualIncrement());
            Console.WriteLine(student.getFeesAnnualIncrement(3000));

            Console.WriteLine("------------------------------");

            Console.WriteLine(j.rollno);
            Console.WriteLine(j.FirstName);
            Console.WriteLine(j.LastName);
            Console.WriteLine(j.Class);
            j.PrintFullName();
            Console.WriteLine(student.SchoolName);
            Console.WriteLine(student.getFees());
            Console.WriteLine(student.getFeesAnnualIncrement());
            Console.WriteLine(student.getFeesAnnualIncrement(3000));
        }
    }
}
