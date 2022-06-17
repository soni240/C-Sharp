// See https://aka.ms/new-console-template for more information

using _3_stock_account_management;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.IO;

namespace StockAccountManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Creating obj for StockManagement 
            StockManagement stockManagement = new StockManagement();
            //getting path of json file to load data
            string file = @"D:\VisualStudio\repos\StockAccountManagement\StockAccountManagement\stock.json";
            //DeserializeO Json file
            StockSupport stockSupport = JsonConvert.DeserializeObject<StockSupport>(File.ReadAllText(file));
            Console.WriteLine("Enter Your Option To Perform\n 1-Add a stock\n 2-Remove a stock\n3-Display Stocks");
            int num = Convert.ToInt32(Console.ReadLine());
            var fs = stockSupport.stocksList;
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
        }
    }
}
