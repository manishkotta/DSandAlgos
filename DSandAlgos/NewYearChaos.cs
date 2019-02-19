using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgos
{
    public class NewYearChaos
    {
        static void minimumBribes(int[] q)
        {

            int swapCount;
            swapCount = 0;
            int i;
            for (i = 0; i < q.Length - 1; i++)
            {
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                for (int j = 0; j < q.Length - i - 1; j++)
                {
                    if (q[j] > q[j + 1])
                    {
                        int temp = q[j];
                        q[j] = q[j + 1];
                        q[j + 1] = temp;
                        swapCount = swapCount + 1;
                    }
                }
            }
            Console.WriteLine(swapCount);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter no of elements of an array");
            //int t = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter array elements with space");
            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());

            //    int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
            //    minimumBribes(q);

            //}
            //string s = "";
            //s.Reverse().ToString();

            var x = NewYearChaos.longestEvenWord("like You can do it the way you ");
            Console.WriteLine(x);
            Console.ReadLine();
        }

        public static string longestEvenWord(string sentence)
        {
            var count = 0;
            var maxCount = 0;
            var actualString = "";
            var temp = "";
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                if (sentence[i] == 32)
                {
                    if (count  >= maxCount && count % 2 == 0)
                    {
                        Console.WriteLine("{0} {1}", count, actualString);
                        actualString = temp;
                        temp = "";
                        maxCount = count;
                        count = 0;
                    }
                    else
                    {
                        temp = "";
                        count = 0;
                    }
                }
                else
                {
                    temp += sentence[i];
                    count += 1;
                }
            }
          

            for (int i = actualString.Length - 1; i >= 0; i--)
            {
                temp += actualString[i];
            }

            return temp;

        }

        public static List<string> missingWords(string s, string t)
        {

            var firstArray = s.Split(' ').ToList();
            var secondArray = t.Split(' ').ToList();
            var list = new List<string>();
            var count = 0;

            for (int i = 0; i < firstArray.Count; i++)
            {
                if (firstArray[i] != secondArray[count])
                {
                    list.Add(firstArray[i]);
                }
                else
                {
                    count += 1;
                }
            }

            return list;

        }

    }
}
