﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    /// <summary>
    /// This class should contain the definition for one catering item
    /// </summary>
    public class CateringItem
    {
        public CateringItem(string productCode, string name, decimal price, string type)
            {
                this.ProductCode = productCode;
                this.Name = name;
                this.Price = price;
                this.Type = type;
            }

        public string ProductCode { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return this.ProductCode + " " + this.Name + " " + this.Price + " " + this.Type;
        }
        //need beverage, entree, appetizer, and dessert??

        // constructor with name, price, item number, and type?



        // See interview question for sample
    }
}
