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
        private List<CateringItem> purchasedItems = new List<CateringItem>();

        //private string filePath = @"C:\Catering"; // You will likely need to create this folder on your machine

        public List<CateringItem> AllCateringItems
        {
            get
            {
                return this.items;
            }
        }

        public void AddNew(CateringItem item)
        {
            this.items.Add(item);
        }

        public void Purchase(CateringItem item)
        {
            this.purchasedItems.Add(item);
        }
        public List<CateringItem> PurchasedItems
        {
            get
            {
                return this.purchasedItems;
            }
        }

        // Method to take in product code and return a Catering Item
        public CateringItem FindCorrectItem(string productCode)
        {
            
            foreach (CateringItem item in items)
            {
                if (item.ProductCode == productCode)
                {
                    return item;
                }
            }
            return null;
        }
        public int SubtractQuantity(CateringItem selectedItem, int purchaseQuantity)
        {
            return selectedItem.Quantity -= purchaseQuantity;
            
        }



       



        
        
        
        
        
        


        
        
        

        

        //will need to write a line to log.txt when money is added, change is given, number of product ordered
        //datetime formatting shared in slack also for currency


    }
}
