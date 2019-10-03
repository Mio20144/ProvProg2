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
        private bool cursed = false;
        Random generator = new Random();
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
        public string GetName()
        {
            name = Console.ReadLine();
            return name;
        }
        public int Evaluate()
        {
            actualValue = generator.Next(10, 100);
            rarity = generator.Next(1, 4);
            actualValue *= rarity;
            /*double multiplier = generator.NextDouble(0.5 , 1.5);
            int newMultiplier = Convert.ToInt32(multiplier);
            actualValue *= newMultiplier;*/
            return actualValue;

        }
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
    }
    
    
    
}
