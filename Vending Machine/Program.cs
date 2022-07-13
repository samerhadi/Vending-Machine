using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool running = false;

          while(!running)
            {


                Console.WriteLine("(1) Display vending machine items");
                Console.WriteLine("(2) Purchse");
                Console.WriteLine("(3) Insert money");
                Console.WriteLine("(4) Exit");
                int mainMenuChoise = int.Parse(Console.ReadLine());


                if (mainMenuChoise.Equals(1))
                {
                    VendingMachine machine = new VendingMachine();
                    machine.ShowAll();
                }


                if (mainMenuChoise.Equals(2))
                {
                    VendingMachine machine = new VendingMachine();
                    machine.Purchase();
                }

                if (mainMenuChoise.Equals(3))
                {
                    VendingMachine machine = new VendingMachine();
                    machine.InsertMoney();
                }

                if (mainMenuChoise.Equals(4))
                {
                    VendingMachine machine = new VendingMachine();
                    machine.EndTransaction();
                }


            }


            Console.ReadKey();



        }
    }
}
