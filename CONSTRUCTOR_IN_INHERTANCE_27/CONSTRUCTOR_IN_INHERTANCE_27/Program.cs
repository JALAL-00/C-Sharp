/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR_IN_INHERTANCE_27
{
    internal class Program
    {
        public class Parents
        {
            public Parents()
            {
                Console.WriteLine("Base Constructor is called");
            }
        }

        public class Childs : Parents
        {
            public Childs()
            {
                Console.WriteLine("Derive Constructor is called");
            }
        }
        static void Main(string[] args)
        {
            Childs C = new Childs();

        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR_IN_INHERTANCE_27
{
    internal class Program
    {
        public class Parents
        {
            public Parents(string massage)
            {
                Console.WriteLine(massage);
            }
        }

        public class Childs : Parents
        {
            public Childs() : base("Base Constructor")
            {
                Console.WriteLine("Derive Constructor is called");
            }
        }
        static void Main(string[] args)
        {
            Childs C = new Childs();

        }
    }
}