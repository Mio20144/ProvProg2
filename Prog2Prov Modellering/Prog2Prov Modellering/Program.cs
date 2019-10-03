using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Prov_Modellering
{
    class Program
    {
        static void Main(string[] args)
        {

            Book b1 = new Book();
            List<string> names = new List<string>();
            Console.WriteLine("Please enter the book you are looking for");
            b1.GetName();
            b1.Evaluate();
            
            b1.PrintInfo();
            b1.IsCursed();

            Console.ReadLine();
            
            

        }
    }
}
