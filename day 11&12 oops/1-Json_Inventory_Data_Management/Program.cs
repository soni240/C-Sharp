// See https://aka.ms/new-console-template for more information
using System;

namespace JsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FetchJsonForRice fetchJsonForRicw = new FetchJsonForRice();

            Rice ricedata = fetchJsonForRicw.ReadTheJsonFile("D:/Bridgelab Tests/repos/Practice_problems/JsonFile/JsonFile/new 1.json");
            Console.WriteLine(ricedata);
            Console.WriteLine("|--------------------------- ## Inventory management ##------------------------|");
            Console.WriteLine("|-----------------------------------------------------------------------|");
            Console.WriteLine("*******************Inventory For Rice***********************");
            for (int i = 0; i < ricedata.typeOfRice.Count; i++)
            {
                Console.WriteLine(ricedata.typeOfRice[i].name);
                Console.WriteLine(ricedata.typeOfRice[i].weight);
                Console.WriteLine(ricedata.typeOfRice[i].price);
                //int total = ricedata.typeOfRice[i].weight *ricedata.typeOfRice[i].price;
                //Console.WriteLine(total);

                Console.WriteLine("Total Price of {0}={1}", ricedata.typeOfRice[i].name, ricedata.typeOfRice[i].price);

            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("*******************Inventory For Pulses***********************");

            for (int i = 0; i < ricedata.typeofPulses.Count; i++)
            {
                Console.WriteLine(ricedata.typeofPulses[i].name);
                Console.WriteLine(ricedata.typeofPulses[i].weight);
                Console.WriteLine(ricedata.typeofPulses[i].price);

                Console.WriteLine("Total Price of {0}={1}", ricedata.typeofPulses[i].name, ricedata.typeofPulses[i].price);


            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("*******************Inventory For Wheat***********************");
            for (int i = 0; i < ricedata.typeofWheats.Count; i++)
            {
                Console.WriteLine(ricedata.typeofWheats[i].name);
                Console.WriteLine(ricedata.typeofWheats[i].weight);
                Console.WriteLine(ricedata.typeofWheats[i].price);

                Console.WriteLine("Total Price of {0}={1}", ricedata.typeofWheats[i].name, ricedata.typeofWheats[i].price);

            }
        }

    }
}

