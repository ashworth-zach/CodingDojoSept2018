using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(tossmultiplecoins(44));
            names();
        }
        public static void randomarray(){
            int[] array = new int[10];
            Random rand = new Random();
            int max=array[0];
            int sum=0;
            for(int i = 0; i< array.Length;i++){
                array[i]=rand.Next(5,25);
            }
            int min=array[0];
            for(int i = 0; i< array.Length;i++){
                if (array[i]>max){
                    max=array[i];
                }
                if (array[i]<min){
                    min=array[i];
                }
                sum=sum+array[i];
            }
            foreach(int x in array){
                Console.WriteLine(x);
            }
            Console.WriteLine("sum: "+sum+"  max: "+ max+"  Min: "+min);
            
        }
        public static string tosscoin(){
            Console.WriteLine("tossing a coin...");
            Random rand= new Random();
            string str="";
            int num=rand.Next(0,20);
            if(num%2==0){
                str="heads";
                Console.WriteLine(str);
                return str;
            }
            else{
                str="tails";
                Console.WriteLine(str);
                return str;
            }
        }
        public static double tossmultiplecoins(int num){
            int heads =0;
            int tails =0;
            for(int i = 0; i< num;i++){
                string x=tosscoin();
                if(x == "heads"){
                    heads=heads+1;
                }
                else{
                    tails=tails+1;
                }
            }
            
            double ratio=heads/tails;
            Console.WriteLine(ratio);
            return ratio;
        }
        public static string[] names(){
            string[] Names = new string[5] {"todd","tiffany","geneva","sydney","charlie"};
            Random rand = new Random();
            for (int i = 0; i < Names.Length; i++)
            {
                int idx = rand.Next(Names.Length);
                string temp = Names[idx];
                Names[idx] = Names[i];
                Names[i] = temp;
            }
            List<string> OverFive = new List<string>();
            foreach (var name in Names)
            {
                Console.WriteLine(name);
                if (name.Length > 5)
                {
                    OverFive.Add(name);
                }
            }

            foreach (var person in OverFive)
            {
                Console.WriteLine(person);
            }
            return OverFive.ToArray();
        }
    }
}
