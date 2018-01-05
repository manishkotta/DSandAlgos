using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgos
{
    class MergeSort
    {


        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 30, 20 };

            MergeSortMethod(arr, 0, arr.Length-1);

            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        public static void MergeSortMethod(int[] arr,int l,int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;

                MergeSortMethod(arr, l, m);
                MergeSortMethod(arr, m + 1, r);

                Merge(arr, l, m, r);

            }
        }

        public static void Merge(int[] arr,int l,int m,int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] l1 = new int[n1];
            int[] r1 = new int[n2];

            for (int i = 0; i < n1; i++)
                l1[i] = arr[l+i];
            for (int i = 0; i < n2; i++)
                r1[i] = arr[m + 1 + i];

            int a=0, d = 0;
            int k = l;

            while(a < n1 && d < n2)
            {
                if (arr[a] < arr[d])
                {
                    arr[k] = arr[a];
                    a++;
                }
                else
                {
                    arr[k] = arr[d];
                    d++;
                }
                k++;
            }

            while (a < n1)
            {
                arr[k] = arr[a];
                k++;
                a++; 
            }
                
            while(d < n2)
            {
                arr[k] = arr[d];
                k++;
                d++;
            } 

        }

    }
}
