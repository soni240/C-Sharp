// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System;
using System.IO;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager manager = new InventoryManager();
            string file = @"D:\VisualStudio\repos\InventoryManagement\InventoryManagement\inventoryJson.json";
            InventorySupport inventory = JsonConvert.DeserializeObject<InventorySupport>(File.ReadAllText(file));
            Console.WriteLine("-----------------Display Inventory Rice,Pulse,Wheat------------------------------");
            Console.WriteLine("Display Inventory Press\n 1.Rice Inventory\n 2.Pulse Inventory \n 3.Wheat Inventory");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    //Rice Inventory operations
                    var fs = inventory.RiceList;
                    Console.WriteLine("Enter Option  to Perform\n 1-Add to Inventory\n 2-Delete from inventory\n3-Display Inventory");
                    int num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            manager.AddInventory(fs);
                            File.WriteAllText(file, JsonConvert.SerializeObject(inventory));
                            manager.DisplayInventory(fs);
                            break;
                        case 2:
                            manager.DeleteInventory(fs);
                            File.WriteAllText(file, JsonConvert.SerializeObject(inventory));
                            manager.DisplayInventory(fs);
                            break;
                        case 3:
                            manager.DisplayInventory(fs);
                            break;
                    }

                    break;
                case 2:
                    //Wheat Inventory operations
                    var fs1 = inventory.WheatList;
                    Console.WriteLine("Enter Option which operation to Perform\n 1-Add to Inventory\n 2-Remove from inventory\n3-Display Inventory");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    switch (num1)
                    {
                        case 1:
                            manager.AddInventory(fs1);
                            File.WriteAllText(file, JsonConvert.SerializeObject(inventory));
                            manager.DisplayInventory(fs1);
                            break;
                        case 2:
                            manager.DeleteInventory(fs1);
                            File.WriteAllText(file, JsonConvert.SerializeObject(inventory));
                            manager.DisplayInventory(fs1);
                            break;
                        case 3:
                            manager.DisplayInventory(fs1);
                            break;
                    }
                    break;
                case 3:
                    //Pulse Inventory operations
                    var fs2 = inventory.PulseList;
                    Console.WriteLine("Enter which operation to perform\n 1-Add to Inventory\n 2-Remove from inventory\n 3-Display Inventory");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    switch (num2)
                    {
                        case 1:
                            manager.AddInventory(fs2);
                            File.WriteAllText(file, JsonConvert.SerializeObject(inventory));
                            manager.DisplayInventory(fs2);
                            break;
                        case 2:
                            manager.DeleteInventory(fs2);
                            File.WriteAllText(file, JsonConvert.SerializeObject(inventory));
                            manager.DisplayInventory(fs2);
                            break;
                        case 3:
                            manager.DisplayInventory(fs2);
                            break;
                    }
                    break;

            }

            //Console.WriteLine("Hello World!");
        }
    }
}

