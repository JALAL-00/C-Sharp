/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Read/Write Properties
namespace Properties_25
{
    
    public class student
    {
        private int StudentID;
        private string StudentName;

        public int STDID
        {
            set
            {
                this.StudentID = value;
            }
            get
            {
                return this.StudentID;
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student S1 = new student();
            S1.STDID = 23;
            Console.WriteLine(S1.STDID);
            

        }
    }
    


    public class student
    {
        private int StudentID;
        private string StudentName;

        public int STDID
        {
            set
            {
                this.StudentID = value;
            }
            get
            {
                return this.StudentID;
            }

        }

        public string STDName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Enter your name: ");
                }
                else
                {
                    this.STDName = value;
                }
            }
            get
            {
                return this.StudentName;
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student S1 = new student();
            S1.STDID = 23;
            S1.STDName = null;
            Console.WriteLine(S1.STDName);
            Console.WriteLine(S1.STDID);
            Console.ReadLine();


        }
    }
}
*/

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Read only Properties
namespace Properties_25
{
    public class student
    {
        private int StudentID;
        private string StudentName;
        private int STDTotal = 100;

        public int STDTo
        {
            get
            {
                return this.STDTotal;
            }

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student S1 = new student();
            Console.WriteLine(S1.STDTo);

            Console.ReadLine();


        }
    }
}
*/

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write only Properties
namespace Properties_25
{
    public class student
    {
        private int StudentID;
        private string StudentName;
        private int STDTotal = 100;

        public int STDTo
        {
            set
            {
                this.STDTotal = STDTotal;
            }

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student S1 = new student();
            S1.STDTo=150;

            Console.ReadLine();


        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Auto implemented Properties
namespace Properties_25
{
    public class student
    {
        public int StdID { get; set; }
        public string StdName { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.StdID = 50;
            s1.StdName = "JALAL";
            Console.WriteLine("ID is: "+ s1.StdID);
            Console.WriteLine("Name is: "+ s1.StdName);
        }
    }
}