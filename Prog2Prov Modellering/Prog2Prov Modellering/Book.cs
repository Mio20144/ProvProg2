using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Prov_Modellering
{
    class Book
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        Random generator = new Random();
        //skriver ut namnet och värdet på boken, samt hur sällsynt den är
        public void PrintInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine("The value for this book is " + actualValue);
            Console.WriteLine("The rarity for this book is " + rarity);
            
        }
        public string GetCategory()
        {
            return category;
        }
        //tar emot bokens namn
        public string GetName()
        {
            name = Console.ReadLine();
            return name;
        }
        //värdesätter boken baserad på slumpmässig kostnad och sällsynthet
        public int Evaluate()
        {
            
            
            actualValue *= rarity;
            /*double multiplier = generator.NextDouble(0.5 , 1.5);
            int newMultiplier = Convert.ToInt32(multiplier);
            actualValue *= newMultiplier;*/
            return actualValue;

        }
        //slumpar fram om boken är cursed eller inte
        public bool IsCursed()
        {
            int cursingPower = generator.Next(0, 11);
            if (cursingPower >= 3)
            {
                cursed = false;
                Console.WriteLine("This book is not cursed");

            }
            else
            {
                cursed = true;
                Console.WriteLine("This book is cursed");
            }
            return cursed;
        }
        //metod som beräknar alla värden på book
        public Book()
        {
            actualValue = generator.Next(10, 100);
            rarity = generator.Next(1, 4);
            int cursing = generator.Next(0, 1);
            if (cursing == 0)
            {
                cursed = false;

            }
            else
            {
                cursed = true;
            }
            int book = generator.Next(0, 3);
            
        }
    }
    
    
    
}
