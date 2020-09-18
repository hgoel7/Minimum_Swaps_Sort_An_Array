using System;

namespace Minimmun_Swaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int res = minimumSwaps(arr);
            Console.WriteLine("Result : " + res );

        }

        static int minimumSwaps(int[] arr) {
            int count = 0;
            for(int i = 0; i < arr.Length ; i++)
            {
                if( arr[i] != i+1 )
                {
                    while( arr[i] != i+1 ) {
                        int val = 0;
                        val = arr[arr[i] - 1];
                        arr[arr[i] - 1] = arr[i];
                        arr[i] = val;
                        count++;
                    }
                }
            }
            return count ;
        }
    }
}
