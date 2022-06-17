using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_InventoryManagement
{
    public class MethodManager
    {
        // Interface Class Display methods
        void DisplayInventory(List<Rice> ricelist);
        void DisplayInventory(List<Wheat> wheatList);
        void DisplayInventory(List<Pulse> pulseList);
        //Add Methods
        void AddInventory(List<Wheat> wheatList);
        void AddInventory(List<Pulse> pulseList);
        void AddInventory(List<Rice> ricelist);
        //Delete Methods
        void DeleteInventory(List<Rice> riceList);
        void DeleteInventory(List<Pulse> pulseList);
        void DeleteInventory(List<Wheat> wheatList);
    }
}

    

