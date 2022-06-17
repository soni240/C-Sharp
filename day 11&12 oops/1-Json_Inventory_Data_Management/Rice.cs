using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Json_Inventory_Data_Management
{
    public class Rice
    {
        public List<TypeofRice> typeOfRice;
        public List<TypeofPulses> typeofPulses;
        public List<TypeofWheats> typeofWheats;



    }
    public class TypeofRice
    {
        public string name;
        public string weight;
        public int price;


    }
    public class TypeofPulses
    {
        public string name;
        public string weight;
        public int price;
    }
    public class TypeofWheats
    {
        public string name;
        public string weight;
        public int price;

    }
}





    

