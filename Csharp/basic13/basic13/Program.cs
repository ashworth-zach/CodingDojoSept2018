using System;
using System.Collections.Generic;
namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // for(int i = 0; i<256;i++){
            //     Console.WriteLine(i);
            // }

            // for(int i = 0; i<256;i++){
            //     if(i%2!=0){
            //         Console.WriteLine(i);
            //     }
            // }

            // int sum=0;
            // for(int i = 0 ; i<256;i++){
            //     sum=sum+i;
            //     Console.WriteLine("sum: "+sum+"  new number: "+i);
            // }

            // int[] array = new int[5] {1,2,3,4,5};
            // foreach(int x in array){
            //     Console.WriteLine(x);
            // }

            // int[] array = new int[5] {-1,2,-3,-4,5};
            // int max=array[0];
            // foreach(int x in array){
            //     if(x>max){
            //         max=x;
            //     }
            // }
            // Console.WriteLine(max);

            // int[] array = new int[5] {1,2,3,4,5};
            // int sum=0;
            // int avg=0;
            // foreach(int x in array){
            //     sum=sum+x;
            // }
            // avg=sum/array.Length;
            // Console.WriteLine(avg);

            var y = new List<int>();
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 == 1)
                {
                    y.Add(i);
                }
            }

            Console.WriteLine("array y: ");
            foreach (var i in y)
            {
                Console.Write( + i +", ");
            }

            // int[] array = new int[5] {1,2,3,4,5};
            // int sum=0;
            // int y=0;
            // for(int i=0;i<array.Length;i++){
            //     if (array[i]>y){
            //         sum=sum+1;
            //     }
            // }
            // Console.WriteLine(sum);

            // int[] array = new int[5] {1,2,3,4,5};
            // for(int i = 0 ; i < array.Length ; i++){
            //     array[i]=array[i]*array[i];
            // }
            // foreach(int x in array){
            //     Console.WriteLine(x);
            // }

            // int[] array = new int[5] {1,2,3,-4,5};
            // for (int i = 0;i<array.Length;i++){
            //     if (array[i]<0){
            //         array[i]=0;
            //     }
            // }
            // foreach(int x in array){
            //     Console.WriteLine(x);
            // }

            // int[] array = new int[5] {1,2,3,-4,5};
            // int min=array[0];
            // int max=array[0];
            // int sum=0;
            // int avg=0;
            // for (int i = 0 ; i< array.Length;i++){
            //     if(array[i]<min){
            //         min=array[i];
            //     }
            //     if(array[i]>max){
            //         max=array[i];
            //     }
            //     sum=sum+array[i];
            // }
            // avg=sum/array.Length;
            // Console.WriteLine("min: "+ min+"  max: "+max+"  average: "+ avg);

            // int[] array = new int[5] {1,2,3,-4,5};
            // for (int i = 0; i<array.Length-1;i++){
            //     array[i]=array[i+1];
            // }
            // array[array.Length-1]=0;
            // foreach (int x in array){
            //     Console.WriteLine(x);
            // }

            // object[] array = new object[5] {1,2,3,-4,5};
            // for (int i = 0; i < array.Length; i++)
            // {
            //     if ((int)array[i] < 0)
            //     {
            //         array[i] = "Dojo";
            //     }
            // }
            // foreach (var item in array)
            // {
            //     Console.Write(item);
            // }

            // Console.WriteLine();
        }
    }
}
