using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    /// <summary>
    /// This class should contain any and all details of access to files
    /// </summary>
    public class FileAccess
    {
        private string filePath = @"C:\Catering\cateringsystem.csv";


        public void LoadCateringItems(Catering groupOfCateringItems)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    string[] parts = line.Split("|");

                    string productCode = parts[0];  // code, name, price, type
                    string name = parts[1];
                    decimal price = decimal.Parse(parts[2]);
                    string type = parts[3];


                    CateringItem item = new CateringItem(productCode, name, price, type);
                    groupOfCateringItems.Add(item);
                }
            }
        }
        

        

        

        // call an instance of the catering class, use string array to create new catering items to add back to catering class

        //Readme part 8
        //StreamWriter to Log.txt, File Path should return to catering directory
    }
}
