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
        private string logFilePath = @"C:\Catering\Log.txt";


        public void LoadCateringItems(Catering groupOfCateringItems)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    string[] parts = line.Split("|");

                    string productCode = parts[0];  
                    string name = parts[1];
                    decimal price = decimal.Parse(parts[2]);
                    string type = parts[3];


                    CateringItem item = new CateringItem(productCode, name, price, type);
                    groupOfCateringItems.AddNew(item);
                }
            }
        }
        
        public void TransactionAuditLog (string message)
        {

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(DateTime.Now + " " + message);
                

            }
        }

        

        

        

        //Readme part 8
        //StreamWriter to Log.txt, File Path should return to catering directory
    }
}
