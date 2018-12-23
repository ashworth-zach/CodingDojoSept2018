using System;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            for(x=0;x<255;x++){
                Console.WriteLine(x);
            }
            int z=0;
            bool flag=false;
            for(z=0;z<101;z++){
                flag=false;
                if (z%3==0||z%5==0){
                    if (z%3==0&&z%5==0){
                        flag=true;
                    }
                    if (flag == false){
                        Console.WriteLine(z);
                    }
                }
            }
            int i=0;
            bool marker=false;
            for(i=0;i<101;i++){
                marker=false;
                if(i%5==0&&i%3==0){
                    marker=true;
                    Console.WriteLine("FIZZBUZZ");
                }
                if(i%5==0&& marker==false){
                    Console.WriteLine("buzz");
                }
                if(i%3==0&&marker==false){
                    Console.WriteLine("fizz");
                }
            }
        }
    }
}
