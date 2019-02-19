using System;
using System.Linq;

namespace DSandAlgos.SearchingAlgos
{
    public class JumpSearch
    {
        public static void Main()
        {
            Console.WriteLine("Input space seperated values as an Array");
            string userInput = Console.ReadLine();
            Console.WriteLine("Input key to search");
            int key = Convert.ToInt32(Console.ReadLine());
            var array = userInput.Split(' ');
            var convertedArray = array.Select(s => Convert.ToInt32(s)).ToArray();
            var objJumpSearch = new JumpSearch();
            var result = objJumpSearch.Search(convertedArray, convertedArray.Length, key);

            Console.WriteLine("Index : {0}", result);
            Console.ReadKey();
        }


        public int Search(int[] arr,int n,int key)
        {
            int step = (int)Math.Floor(Math.Sqrt(n));

            int prev = 0;
            while (arr[Math.Min(step,n)-1] < key)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }

            while(arr[prev] < key)
            {
                prev++;
                if (prev == Math.Min(step, n))
                    return -1;
            }

            if (arr[prev] == key)
                return prev;
            else
                return -1; 
        }
    }
}
