using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace DSandAlgos
{
    class SelectionSort
    {
        static void Main(string[] args)
        {

            // Selection Sort
            int[] arr = new int[10000];
            Random st = new Random();
            for (int i=0; i<10000; i++)
            {
                arr[i] = st.Next(1, 10000);
            }

            Stopwatch s = new Stopwatch();

            s.Start();
            for (int j = 0; j < arr.Length; j++)
            {
                int arr_min = j;
                for (int i = j+1; i < arr.Length; i++)
                {
                    if (arr[arr_min] > arr[i])
                        arr_min = i;
                }

                int temp2 = arr[j];
                arr[j] = arr[arr_min];
                arr[arr_min] = temp2; 

            }
            s.Stop();

            Console.WriteLine($"Elapsed Milliseconds:{s.ElapsedMilliseconds}");
            Console.ReadLine();
        }
    }
}
