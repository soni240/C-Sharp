﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_stock_account_management
{
    public class StockManagement
    {
        int totalshare;
        //Display Stock Details
        public void DisplayStocks(List<StockSupport.Stocks> stocksList)
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("------------- ##### DISPLAYING STOCK DETAILS ##### --------------\n");
            foreach (var i in stocksList)
            {
                Console.WriteLine("Stock name is: {0} \nStock share is: {1} \nStock Price is: {2}", i.StockName, i.shares, i.Price);
                int temp = i.shares * i.Price;
                totalshare += temp;
                Console.WriteLine("Total stock price for {0} is : {1}", i.StockName, temp);
                Console.WriteLine("------------------------------------------");
            }
            Console.WriteLine("Total store is : {0}", totalshare);


        }
        public void AddStock(List<StockSupport.Stocks> stocks)
        {
            Stocks stocks1 = new Stocks();
            Console.WriteLine("Enter the stock name: ");
            stocks1.StockName = Console.ReadLine();
            Console.WriteLine("Enter number of shares ");
            stocks1.shares = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the stock price: ");
            stocks1.Price = Convert.ToInt32(Console.ReadLine());
            stocks.Add(stocks1);
        }
        public void DeleteInventory(List<StockSupport.Stocks> stocks)
        {
            Console.WriteLine("Enter the stock name to be deleted: ");
            string temp = Console.ReadLine();
            stocks.Remove(stocks.Find(result => result.StockName.Equals(temp)));
        }


    }
}

    

