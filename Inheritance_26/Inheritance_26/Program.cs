/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_26
{

    public class visitingEmployees : Employees
    {
        public int VisitingSalary;
        public int VisitingHours;
    }

    public class parmanentEmployees : Employees
    {
        public int parmanentSalary;
        public int parmanentHours;
    }

    public class Employees
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public int EmpContactNo;

        public void show()
        {
            Console.WriteLine("Base class called");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            parmanentEmployees P1 = new parmanentEmployees();
            P1.EmpId = 50;
            P1.show();

            visitingEmployees jalal = new visitingEmployees();
            jalal.EmpName = "JALAL";
            Console.WriteLine(P1.EmpId);
            Console.WriteLine(jalal.EmpName);
        }
    }
}
*/


/*
//Single Inheritance
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_26
{

    internal class Program
    {
        public class parents
        {
            public void DisplayParents()
            {
                Console.WriteLine("A and B are my parents ");
            }
        }

        public class son : parents
        {
            public void DisplaySon()
            {
                Console.WriteLine("I am the son C ");
            }
        }
        static void Main(string[] args)
        {
            son S = new son();
            S.DisplaySon();
            S.DisplayParents();
            
        }
    }
}
*/


/*
//Hierarchical Inheritance 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_26
{

    internal class Program
    {
        public class Parents
        {
            public void Display()
            {
                Console.WriteLine("A and B are my parents");
            }
        }

        public class sonC : Parents
        {
            public void DisplaySonC()
            {
                Console.WriteLine("I am the child C");
            }
        }

        public class sonD : Parents
        {
            public void DisplaySonD()
            {
                Console.WriteLine("I am the son D");
            }
        }
        static void Main(string[] args)
        {
            sonC s1 = new sonC();
            s1.DisplaySonC();
            s1.Display();

            sonD s2 = new sonD();
            s2.DisplaySonD();
            s2.Display();
        }
    }
}
*/




//Multilevel Inheritance
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_26
{

    internal class Program
    {
        public class GrandParents
        {
            public GrandParents()
            {
                Console.WriteLine("Construction call at Run-Time");
            }

            public void DisplayGrand()
            {
                Console.WriteLine("A and B are my Grandparents");
            }
        }

        public class Parents : GrandParents
        {
            public void DisplayParents()
            {
                Console.WriteLine("C and D are my Parents");
            }
        }

        public class Child : Parents
        {
            public void DisplayChild()
            {
                Console.WriteLine("I am the son Z");
            }
        }
        static void Main(string[] args)
        {
            Child C = new Child();
            C.DisplayChild();
            C.DisplayParents();
            C.DisplayGrand();
        }
    }
}