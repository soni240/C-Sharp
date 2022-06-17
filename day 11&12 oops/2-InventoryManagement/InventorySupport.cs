using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_InventoryManagement
{
    public class InventorySupport
    {
        public List<Rice> RiceList { get; set; }
        public List<Wheat> WheatList { get; set; }
        public List<Pulse> PulseList { get; set; }

        public class Rice
        {
            public string name
            {
                get;
                set;
            }
            public int Kg
            {
                get;
                set;
            }
            public int price
            {
                get;
                set;
            }
        }
        public class Pulse
        {
            public string name
            {
                get;
                set;
            }
            public int Kg
            {
                get;
                set;
            }
            public int price
            {
                get;
                set;
            }
        }
        public class Wheat
        {
            public string name
            {
                get;
                set;
            }
            public int Kg
            {
                get;
                set;
            }
            public int price
            {
                get;
                set;
            }
        }
    }
}