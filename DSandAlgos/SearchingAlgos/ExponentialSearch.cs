using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgos.SearchingAlgos
{
    public class ExponentialSearch
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
            int i = 1;
            while(arr[i] < key)
            {
                i += i * 2;
            }            

            return -1;
        }
    }
}
