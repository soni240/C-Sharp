// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System;
using System.IO;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {

            StockManagement stockManagement = new StockManagement();
            //getting path of json
            string file = @"D:\VisualStudio\repos\Commercial-Data_Processing\Commercial-Data_Processing\stock.json";
            string acc = @"D:\VisualStudio\repos\Commercial-Data_Processing\Commercial-Data_Processing\Account.json";
            StockSupport stockSupport = JsonConvert.DeserializeObject<StockSupport>(File.ReadAllText(file));

            //Stock Mangement Methods
            Console.WriteLine("--------------------------##### STOCK MANAGEMENT METHODS  #####----------------------------\n");
            Console.WriteLine("Choose Your Option to perform on Stock Management\n 1.Add a Stock\n 2.Remove a Stock\n 3.Display Stocks");

            AccountSupport accountSupport = JsonConvert.DeserializeObject<AccountSupport>(File.ReadAllText(acc));
            int num = Convert.ToInt32(Console.ReadLine());
            var fs = stockSupport.stocksList;
            //stock  functions
            switch (num)
            {
                case 1:
                    stockManagement.AddStock(fs);
                    File.WriteAllText(file, JsonConvert.SerializeObject(stockSupport));
                    stockManagement.DisplayStocks(fs);
                    break;
                case 2:
                    stockManagement.DeleteInventory(fs);
                    File.WriteAllText(file, JsonConvert.SerializeObject(stockSupport));
                    stockManagement.DisplayStocks(fs);
                    break;
                case 3:
                    stockManagement.DisplayStocks(fs);
                    break;
            }

            Console.WriteLine("--------------------------- #### STOCK ACCOUNT METHODS  ####-------------------------\n ");

            // account  function
            string flag = "Y";
            while (flag == "Y")
            {
                Console.WriteLine("Please Enter  Your Option:\n1.Display user account\n2.To buy a share\n3.To sell a share\n4.To Display Account report");
                int ch = Convert.ToInt32(Console.ReadLine());
                var fs1 = accountSupport.AccountList;
                switch (ch)
                {
                    case 1:
                        stockManagement.StockAccount(acc);
                        break;
                    case 2:
                        Console.WriteLine("Enter amount: ");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter company name  which you want to Buy share: ");
                        string companyname = Console.ReadLine();
                        stockManagement.Buy(amount, companyname);


                        break;
                    case 3:
                        Console.WriteLine("Enter amount: ");
                        int amount1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter company name  which you want to Sell share: ");
                        string companyname1 = Console.ReadLine();
                        stockManagement.Sell(amount1, companyname1);

                        break;
                    case 4:
                        stockManagement.StockPurchased();
                        stockManagement.StockSold();
                        stockManagement.DateandTime();
                        break;


                }
                Console.WriteLine("\nDo You Want To Continue?(Y/N) -Case Sensitive");
                flag = Console.ReadLine();
            }


            // Console.WriteLine("Hello World!");
        }
    }
}

