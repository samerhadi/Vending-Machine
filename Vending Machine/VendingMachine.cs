using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    internal class VendingMachine : IVending
    {

        public void Purchase()
        {
            Console.WriteLine("hej");

        }

        public void ShowAll()
        {
            List<string> items = new List<string>();
            items.Add("Coca cola");
            items.Add("Fanta");
            items.Add("sprite");

            for(int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i]); 
            }

        }

        public void InsertMoney()
        {
            Console.WriteLine("Hur mycket pengar vill du sätta in?");
            int money = int.Parse(Console.ReadLine());


                Console.WriteLine("Du har " + money + " kr på ditt konto ");
            

        }

        public void EndTransaction()
        {
            Environment.Exit(0);
     
        }

    }
}
