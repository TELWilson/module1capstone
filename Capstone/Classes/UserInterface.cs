using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    /// <summary>
    /// This class provides all user communications, but not much else.
    /// All the "work" of the application should be done elsewhere
    /// ALL instances of Console.ReadLine and Console.WriteLine should 
    /// be in this class.
    /// </summary>
    public class UserInterface
    {
        private Catering catering;
        private FileAccess files;
        private Money money;
        private CateringItem cateringItem;


        public UserInterface()
        {
            this.catering = new Catering();
            this.files = new FileAccess();
            this.money = new Money();
            //this.cateringItem = new CateringItem();
        }
       
        public void RunInterface()
        {
            files.LoadCateringItems(this.catering);     

            bool done = false;
            while (!done)
            {
                Console.WriteLine("Please select an option from the menu below");
                Console.WriteLine("(1) Display Catering Items");
                Console.WriteLine("(2) Order");
                Console.WriteLine("(3) Quit");

                string choiceMainMenu = Console.ReadLine();

                switch (choiceMainMenu)
                {
                    case "1":
                        this.DisplayCateringItems();
                        break;

                    case "2":
                        this.PurchasingMenu();
                        break;

                    case "3":
                        done = true;
                        break;

                }
            }

        }

        public void PurchasingMenu()
        {
            bool donePurchasing = false;
            while (!donePurchasing)
            {
                Console.WriteLine("Please select an option from the menu below");
                Console.WriteLine("(1) Add Money");
                Console.WriteLine("(2) Select Products");
                Console.WriteLine("(3) Complete Transaction");
                Console.WriteLine();
                Console.WriteLine("Current Account Balance: $" + money.CurrentBalance);

                string choicePurchasingMenu = Console.ReadLine();

                switch (choicePurchasingMenu)
                {
                    case "1":
                        Console.WriteLine("Please enter a whole number for the amount of money you would like to add up to $5000");
                        decimal moneyAdd = Convert.ToDecimal(Console.ReadLine());
                        this.money.AddMoney(moneyAdd);
                        
                        break;
                    case "2":
                        Console.WriteLine("Enter the product code you would like to purchase");
                        string purchaseCode = Console.ReadLine();
                        CateringItem item = this.catering.FindCorrectItem(purchaseCode);    // Pass result to Subtract Q if not null


                        Console.WriteLine("Enter the quantity you would like to purchase");
                        int purchaseQuantity = Convert.ToInt32(Console.ReadLine());

                        this.catering.SubtractQuantity(item, purchaseQuantity);
                        break;

                    case "3":
                        //this.CompleteTransaction();
                        donePurchasing = true;
                        break;

                }
            }
        }

        private void DisplayCateringItems()
        {
            Console.WriteLine("Our current catering options: ");

            foreach(CateringItem item in this.catering.AllCateringItems)
            {
                Console.WriteLine(item);
            }

        }

        

    }
}


// need to generate main menu
//need to generate sub menu when 2 Order is selected
//will need a swtich to turn the main menu on and off
// will need a switch to turn sub menu on and off
// see module 1 review user interface

//need to generate a report that shows users transaction history when transaction completed
//need item count, type, description, item price, and total for item as well as total for transaction
//display main menu