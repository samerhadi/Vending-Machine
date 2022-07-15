using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
     class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
   



        class Drinks : Product
        {
            public string Info { get; set; }
        }

        class Snacks : Product
        {
            public string Info { get; set; }
        }




    }
}
