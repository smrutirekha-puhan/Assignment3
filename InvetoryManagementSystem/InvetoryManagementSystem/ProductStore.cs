﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvetoryManagementSystem
{
    public class ProductStore
    {
       
        public string Name;
        public double Price;
        public int Quantity;
        public string type;

      

        public ProductStore(string Name, double Price, int Quantity, string type)
        {
            this.Name=Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.type = type;
        }

    }

}
