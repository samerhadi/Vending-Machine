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

                Console.WriteLine("(1) Purchse");
                Console.WriteLine("(2) Exit");
                int mainMenuChoise = int.Parse(Console.ReadLine());


                if (mainMenuChoise.Equals(1))
                {
                    VendingMachine machine = new VendingMachine();
                    machine.Purchase();

                }

                else if (mainMenuChoise.Equals(2))
                {
                    Environment.Exit(0);   
                }

                else
                {
                    Console.WriteLine("du måste välja en av dessa två val");
                }

            }
           

            Console.ReadKey();




         

        }
    }
}
