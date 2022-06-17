using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2_InventoryManagement.InventorySupport;

namespace _2_InventoryManagement
{
    public class InventoryManager
    {
        public void DisplayInventory(List<InventorySupport.Rice> ricelist)
        {
            Console.WriteLine("--------------DISPLAYING RICE INVENTORY--------------");
            foreach (InventorySupport.Rice i in ricelist)
            {
                Console.WriteLine("Name: {0} \nWeight: {1} \nPrice: {2} \n", i.name, i.Kg, i.price);
            }

        }
        public void DisplayInventory(List<InventorySupport.Pulse> pulseList)
        {
            Console.WriteLine("--------------DISPLAYING PULSE INVENTORY--------------");
            foreach (InventorySupport.Pulse i in pulseList)
            {
                Console.WriteLine("Name: {0} \nWeight: {1} \nPrice: {2} \n", i.name, i.Kg, i.price);
            }
        }

        public void DisplayInventory(List<InventorySupport.Wheat> wheatList)
        {
            Console.WriteLine("--------------DISPLAYING WHEAT INVENTORY--------------");
            foreach (InventorySupport.Wheat i in wheatList)
            {
                Console.WriteLine("Name: {0} \nWeight: {1} \nPrice: {2} \n", i.name, i.Kg, i.price);
            }
        }
        //Add To Inventory
        //Add Rice Details 
        public void AddInventory(List<Rice> ricelist)
        {
            Rice rice = new Rice();
            Console.WriteLine("Enter the rice name: ");
            rice.name = Console.ReadLine();
            Console.WriteLine("Enter the rice price: ");
            rice.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rice weight (kg): ");
            rice.Kg = Convert.ToInt32(Console.ReadLine());
            ricelist.Add(rice);

        }
        //Add Pulse 
        public void AddInventory(List<Pulse> pulseList)
        {
            Pulse pulse = new Pulse();
            Console.WriteLine("Enter the pulse name: ");
            pulse.name = Console.ReadLine();
            Console.WriteLine("Enter the pulse price: ");
            pulse.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the pulse weight(in kg): ");
            pulse.Kg = Convert.ToInt32(Console.ReadLine());
            pulseList.Add(pulse);

        }
        //Add Wheat Method
        public void AddInventory(List<Wheat> wheatList)
        {
            Wheat wheat = new Wheat();
            Console.WriteLine("Enter the wheat name: ");
            wheat.name = Console.ReadLine();
            Console.WriteLine("Enter the wheat price: ");
            wheat.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the wheat weight(in kg): ");
            wheat.Kg = Convert.ToInt32(Console.ReadLine());
            wheatList.Add(wheat);


        }
        public void DeleteInventory(List<Rice> riceList)
        {

            Console.WriteLine("Enter rice name to be deleted");
            string temp = Console.ReadLine();
            riceList.Remove(riceList.Find(result => result.name.Equals(temp)));
        }
        //Delete Pulse Type
        public void DeleteInventory(List<Pulse> pulseList)
        {

            Console.WriteLine("Enter rice name to be deleted");
            string temp = Console.ReadLine();
            pulseList.Remove(pulseList.Find(result => result.name.Equals(temp)));
        }
        //Delete Wheat Type
        public void DeleteInventory(List<Wheat> wheatList)
        {

            Console.WriteLine("Enter rice name to be deleted");
            string temp = Console.ReadLine();
            wheatList.Remove(wheatList.Find(result => result.name.Equals(temp)));
        }

    }
}

    

