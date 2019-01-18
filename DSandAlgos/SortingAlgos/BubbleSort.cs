using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DSandAlgos.SortingAlgos
{
    class BubbleSort
    {

        static void Main(string[] args)
        {
            //Bubble Sort
            int[] arr = new int[10000];
            Random st = new Random();
            for (int i = 0; i < 10000; i++)
            {
                arr[i] = st.Next(1, 10000);
            }
            Stopwatch s = new Stopwatch();

            s.Start();
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j=0;j < arr.Length-i-1  ;j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            s.Stop();

            Console.WriteLine($"Elapsed Milliseconds:{s.ElapsedMilliseconds}");

            Console.ReadLine();
        }

        }
    }
