using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GameOfTwoStacks
{

    public class Stack
    {
        int index = 0;
        int[] _elements = null;
        public int top = -1;
        int length;

        public Stack(int[] elements)
        {
            length = elements.Length;
            _elements = elements;
            if (length > 0)
                top = elements[0];
        }

        public int Pop()
        {
            if (index < length)
            {
                int temp = _elements[index];
                index++;
                top = _elements[index];
                return temp;
            }
            return 0;
        }
    }

    /*
     * Complete the twoStacks function below.
     */
    static int twoStacks(int x, int[] a, int[] b)
    {
        /*
         * Write your code here.
         */

        int sum = 0;
        int i = 0, j = 0;
        int loops = 0;

        while (sum < x)
        {
            if (a[i] <= b[j])
            {
                sum += a[i];
                i++;
            }
            else
            {
                sum += b[j];
                j++;
            }
          
             if(sum <= x)
                ++loops;
           
        }
        Console.WriteLine("sum:{0}", sum);
        Console.WriteLine($"{i},{j}");

        return loops;

    }

    static void Main(string[] args)
    {
        int[] h1 = new int[] { 3 ,8 ,12, 9, 17, 16, 13, 11, 2, 3, 2, 2, 8, 8, 1, 1, 18, 15 };
        int[] h2 = new int[] { 15, 12 ,6, 15, 5 ,0 ,7, 2, 3, 9, 11, 10, 0 ,14, 10 ,4, 15, 8, 0 ,9, 11, 14 ,4 ,5, 8 ,12 };


        var x = twoStacks(100, h1, h2);
        Console.WriteLine(x);
        Console.ReadLine();
    }
}
