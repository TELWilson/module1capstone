using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    /// <summary>
    /// This class should contain all the "work" for a catering system
    /// </summary>
    public class Catering
    {
        private List<CateringItem> items = new List<CateringItem>();

        //private string filePath = @"C:\Catering"; // You will likely need to create this folder on your machine

        public List<CateringItem> AllCateringItems
        {
            get
            {
                return this.items;
            }
        }

        public void Add(CateringItem item)
        {
            this.items.Add(item);
        }
   
        //sample Question Manager for help
        // empty constructor
        //property AllCateringItems that returns the private list items
        //Will need a method for adding catering items 


        // each item starts with qty 50 and will be deducted as users purchase items
        // when item has run out, need to return "SOLD OUT"
        //If product code is invalid, return to purchase menu, might be a good place for a try catch. "invalid code entered"
        //If product is sold out, return to purchase menu (could be part of try catch) "sold out"
        //If there is not enough product, return to purchase menu ("") "insufficient stock"
        //If everything is good, will need to deduct from item quantity and money from balance and return to purchase menu.


        // Will need money property and method to add and subtract money from user account
        //Balance cannot exceed 5000 or go below 0
        //Once money is added, they need to return to purchasing menu where they can then add money, select products, etc.
        //method to remove inventory from item qty starting at 50
        //Will need to print out current balance at the bottom of purchasing menu (value of money property)

        //Completing transaction needs generate a report to user interface
        //??Need to figure out number of 20s, 10s, 5s, 1s, quarters, dimes, nickels to return for change
        // need to update current balance to 0 when transaction is complete

        //will need to write a line to log.txt when money is added, change is given, number of product ordered
        //datetime formatting shared in slack also for currency
        

    }
}
