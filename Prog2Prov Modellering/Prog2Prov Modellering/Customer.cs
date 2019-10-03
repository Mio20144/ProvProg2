using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Prov_Modellering
{
    class Customer
    {
        //värde på hur mycket pengar kunden har
        private int money;
        //bool som avgör om kunden tror på de övernaturliga eller inte. Om de gör det så köper de inte en book som är cursed
        private bool superstitious;
        Random generator = new Random();

        //metod som undersöker om kunden har råd med boken
        public void CanAfford()
        {
            money = generator.Next(50, 200);
            
        }

    }
}
