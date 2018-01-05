using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DSandAlgos
{
    class InsertionSort
    {
        static void Main(string[] args)
        {

            // Insertion Sort
            int[] arr = new int[10000];
            Random st = new Random();
            for (int i = 0; i < 10000; i++)
            {
                arr[i] = st.Next(1, 10000);
            }

            Stopwatch s = new Stopwatch();
            s.Start();

            for(int i=0; i < arr.Length - 1; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while(j>=0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;

            }
            s.Stop();

            Console.WriteLine($"Elapsed Milliseconds:{s.ElapsedMilliseconds}");

            Console.ReadLine();
        }
        }
}
