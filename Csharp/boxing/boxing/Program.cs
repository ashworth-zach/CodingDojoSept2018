using System;
using System.Collections.Generic;
using System.Text;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> stuff = new List<object>();
            stuff.Add(7);
            stuff.Add(28);
            stuff.Add(-1);
            stuff.Add(true);
            stuff.Add("chair");
            int sum = 0;
            foreach(object x in stuff){
                if(x is int){
                    int y = (int)x;
                    Console.WriteLine(x);
                    sum=sum+y;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
