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
            //skapar en ny bok
            Book b1 = new Book();
            //skapar en ny kund
            Customer c1 = new Customer();
            //Lista med tillgängliga böcker
            List<string> books = new List<string>() { "Harry potter", "The Bible", "Guinnes book of world records" };
            //Lista med kategorier
            List<string> category = new List<string>() { "Fantasy", "Religious", "Fun Facts" };
            Console.WriteLine("Here is a book for you");
            b1.GetName();
            b1.Evaluate();
            b1.PrintInfo();
            b1.IsCursed();

            c1.CanAfford();

            Console.ReadLine();
            
            

        }
    }
}
