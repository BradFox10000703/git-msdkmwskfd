using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
               
    {
      /*  static bool Find(int [] arr , int val )

        {
            int upper, mid, lower;
            upper = arr.Length;
            lower = 0;
            while(lower <= upper)
            {
                mid = lower + (upper - lower) / 2;
                if (arr[mid] == val)
                    return true;
                else if (val < arr[mid])
                    upper = mid - 1;
                else lower = mid + 1;

            }




            return false;
        }*/


          public static int BinarySearch(int[] arr , int low , int high , int inq)
        {
            int mid = (low + high) / 2;
            if (arr == null || low > high) return -1;
            if (arr[mid] == inq) return mid;
            if (arr[mid] < inq )
            {
                return BinarySearch(arr, mid + 1, high, inq);

            }
            if (arr[mid] > inq)
            {
                return BinarySearch(arr, low, mid - 1, inq);
            }
            else return -1;
        }





        static void Main(string[] args)
        {
            Stopwatch st1 = new Stopwatch();
            int[] num = new int[1000000000];
            Random rand = new Random();
            st1.Start();
            for(int i = 0; i <num.Length; i++)
            {

                num[i] = rand.Next(100, 999);
                //Console.Write($"{num[i]} ");
            }
            Array.Sort(num);
            //for(int i = 0; i < 1000000; i++)
              //  Console.Write($"{num[i]} ");

            if (BinarySearch(num,0,num.Length,int.Parse(Console.ReadLine()))!=-1)
                Console.WriteLine("found");
            else
                Console.WriteLine("not found");
            st1.Stop();
            Console.WriteLine(st1.ElapsedMilliseconds);
        }

       /* static bool Search<T>(T[] arr, T val)
        {
            for (int i = 0; i< arr.Length; i ++)
            {
                if (arr[i].Equals(val))
                    return true;

            }

            return false;

        }*/
    }
}
