using System;
using System.Collections.Generic;
namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            array = new int[] {0,1,2,3,4,5,6,7,8,9};
            string[] myCars = new string[4] { "tim", "martin", "mickey", "sarah"};
            bool[] array1;
            array1 = new bool[] {true,false,true,false,true,false,true,false,true,false};
            List<string> flavors = new List<string>();
            Dictionary<string,string> users = new Dictionary<string,string>();
            flavors.Add("chocolate");
            flavors.Add("peanut butter");
            flavors.Add("vanilla");
            flavors.Add("strawberry");
            flavors.Add("banana");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);
            users.Add("zach",null);
            users.Add("zach1",null);
            users.Add("zach2",null);
            users.Add("zach3",null);
            Random rand = new Random();
            users["zach"]=flavors[rand.Next(0,4)];
            users["zach1"]=flavors[rand.Next(0,4)];            
            users["zach2"]=flavors[rand.Next(0,4)];
            users["zach3"]=flavors[rand.Next(0,4)];
            users["zach4"]=flavors[rand.Next(0,4)];

            foreach (KeyValuePair<string,string> entry in users)
            {
            Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
