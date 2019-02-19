
using System.IO;
using System;

class Solution
{

    // Complete the maxDifference function below.
    static int maxDifference(int[] a)
    {
        int max = a[0];
        int min = a[0];
        int maxIndex = -1;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
                maxIndex = i;
            }
        }
        for (int i = 0; i < maxIndex; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
            }
        }

        if (min == max)
            return -1;
        else
            return max - min;
    }


    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int aCount = Convert.ToInt32(Console.ReadLine());

        int[] a = new int[aCount];

        for (int i = 0; i < aCount; i++)
        {
            int aItem = Convert.ToInt32(Console.ReadLine());
            a[i] = aItem;
        }

        int res = maxDifference(a);

        Console.WriteLine("result :",res);

        //textWriter.WriteLine(res);

        //textWriter.Flush();
        //textWriter.Close();
        Console.ReadLine();
    }
}