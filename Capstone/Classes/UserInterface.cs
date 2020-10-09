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
                        try
                        {
                            decimal moneyAdd = Convert.ToDecimal(Console.ReadLine());


                            this.money.AddMoney(moneyAdd);
                            this.files.TransactionAuditLog("ADD MONEY: " + moneyAdd.ToString("C") + " " + money.CurrentBalance.ToString("C"));
                        }
                        catch (System.FormatException ex)
                        {
                            Console.WriteLine("Invalid input, please try again. " + ex.Message);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter the product code you would like to purchase");
                        string purchaseCode = Console.ReadLine();
                        CateringItem item = this.catering.FindCorrectItem(purchaseCode.ToUpper());
                        if (item == null)
                        {
                            Console.WriteLine("Product Not Found");
                        }
                        else if (item.Quantity == 0)
                        {
                            Console.WriteLine("Item is sold out, Please make another selection");
                        }
                        else
                        {

                            Console.WriteLine("Enter the quantity you would like to purchase");
                            try
                            {
                                int purchaseQuantity = Convert.ToInt32(Console.ReadLine());


                                if (money.CurrentBalance < (item.Price * purchaseQuantity))
                                {
                                    Console.WriteLine("You have insufficient funds for transaction, please add more money.");
                                }
                                else if (purchaseQuantity > item.Quantity)
                                {
                                    Console.WriteLine("There is insufficient stock to meet your request");
                                }
                                else
                                {
                                    this.catering.SubtractQuantity(item, purchaseQuantity);
                                    this.money.SubtractMoney(item.Price * purchaseQuantity);
                                    this.catering.Purchase(item);
                                    this.files.TransactionAuditLog(item.Quantity + " " + item.Name + " " + item.ProductCode + " " + (item.Price * purchaseQuantity).ToString("C") + " " + money.CurrentBalance.ToString("C"));
                                }
                            }
                            catch (System.FormatException ex)
                            {
                                Console.WriteLine("Invalid input, please try again. " + ex.Message);
                            }
                        }
                        break;

                    case "3":
                        decimal orderTotal = 0;

                        foreach (CateringItem purchasedItem in catering.PurchasedItems)
                        {
                            orderTotal += (purchasedItem.Price * (50 - purchasedItem.Quantity));
                            if (purchasedItem.Type == "B")
                            {
                                purchasedItem.Type = "Beverage";
                            }
                            else if (purchasedItem.Type == "E")
                            {
                                purchasedItem.Type = "Entree";
                            }
                            else if (purchasedItem.Type == "A")
                            {
                                purchasedItem.Type = "Appetizer";
                            }
                            else
                            {
                                purchasedItem.Type = "Dessert";
                            }

                            Console.WriteLine((50 - purchasedItem.Quantity) + " " + purchasedItem.Type + " " + purchasedItem.Name + " $" + purchasedItem.Price + " $" + purchasedItem.Price * (50 - purchasedItem.Quantity));
                        }

                        Console.WriteLine();
                        Console.WriteLine("Total: $" + orderTotal);


                        Console.WriteLine("Total Change: " + money.CurrentBalance.ToString("C") + " " + money.GiveChange());
                        this.files.TransactionAuditLog("GIVE CHANGE: " + money.CurrentBalance.ToString("C") + " $0.00");

                        this.money.CurrentBalance = 0;

                        donePurchasing = true;
                        break;



                }
            }
        }

        private void DisplayCateringItems()
        {
            Console.WriteLine("Our current catering options: ");

            foreach (CateringItem item in this.catering.AllCateringItems)
            {
                Console.WriteLine(item);
            }

        }



    }
}






