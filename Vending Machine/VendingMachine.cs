using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unipluss.Sign.ExternalContract.Entities;

namespace Vending_Machine
{
     class VendingMachine : IVending
    {

        int moneyPool = 0;
        


        public void Purchase()
        {
            List<string> UserProducts = new List<string>();

            List<Product> products = new List<Product>();
              products.Add(new Product
     {
         Id = 1,
         Name = "Coca cola",
         Price = 15
     });

     products.Add(new Product
     {
         Id = 2,
         Name = "Fanta",
         Price = 15
     });

     products.Add(new Product
     {
         Id= 3,
         Name = "Chips",
         Price = 50
     });

     products.Add(new Product
     {
         Id  = 4,
         Name = "Choklad",
         Price = 30
     });
   
            InsertMoney();

            ShowAll();

            
            Console.Write("Välj en product Nummer! ");
            int productId = int.Parse(Console.ReadLine());



            foreach(var product in products)    

           if(productId == product.Id &&  moneyPool > product.Price)
            {
              UserProducts.Add(product.Name);
              int newPrice = moneyPool - product.Price;

                    foreach (var item in UserProducts)
                    {
                        Console.WriteLine("Du har köpt " + item + " Du har kvar "  + newPrice + " kr på ditt konto");
                       
                        return;
                        
                    }
                 

                  
                   
                   
             }

        
            else if (moneyPool < product.Price)
                Console.WriteLine("Du har inte tillräckligt med pengar på ditt konto, Vill du lägga till pengar? y/n");
                string continue_string = Console.ReadLine();
                if (continue_string == "y")
                {
                Purchase();
               
                }

                else if (continue_string == "n")
                {
                EndTransaction(); 
                
                }

            }

        public void ShowAll()
        {
            List<Product> products = new List<Product>();


           products.Add(new Product
            {
                Id = 1,
                Name = "Coca cola",
                Price = 15
            });

            products.Add(new Product
            {
                Id = 2,
                Name = "Fanta",
                Price = 15
            });

            products.Add(new Product
            {
                Id= 3,
                Name = "Chips",
                Price = 50
            });

            products.Add(new Product
            {
                Id  = 4,
                Name = "Choklad",
                Price = 30
            });
        
            foreach (var prduct in products)
            {
                Console.WriteLine("Product Id " + prduct.Id);
                Console.WriteLine(prduct.Name);
                Console.WriteLine(prduct.Price + " kr");
                Console.WriteLine("************************");

            }


        }

        public void InsertMoney()
        {
            

            Console.WriteLine("Hur mycket pengar vill du sätta in?");
            Console.WriteLine("****************************************");
            int money = int.Parse(Console.ReadLine());

            if(money > 0)
            {
                moneyPool = money;
                Console.WriteLine("Du har " + moneyPool + " Kr på ditt konto");
            }
           
            

        }

        public void EndTransaction()
        {
            Console.WriteLine("Du får tillbaks din växel som är " + moneyPool + " kr");
            Console.WriteLine("Tack för din köp!");
            Console.WriteLine("************************************");

            Console.WriteLine("Om du vill försätta tryck '1' annars tryck '2' för och avsluta");



        }



    }
}
