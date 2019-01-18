using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgos.Arrays
{
    class ArrayRotation
    {

        public static void Main()
        {
            Console.WriteLine("Input Pipe seperated values as an Array");
            string userInput = Console.ReadLine();
            Console.WriteLine("Input Number of rotations should happen on a array");
            int numberOfRotations = Convert.ToInt32(Console.ReadLine());
            var array = userInput.Split('|');
            var convertedArray = array.Select(s => Convert.ToInt32(s)).ToArray();
            //foreach (int i in convertedArray)
            //{
            //    Console.Write(i + " ");
            //}

            var obj = new ArrayRotation();
            //obj.LeftRotateByOne(convertedArray);
            obj.ReverseAlgoToRotateAnArray(convertedArray, numberOfRotations, convertedArray.Length);

            obj.Print(convertedArray);

            Console.ReadLine();
        }

        public int[] RotateAnArray()
        {
            return null;
        }

        #region Left Rotate By One
        public void LeftRotateByOne(int[] array)
        {
            var temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
        }
        #endregion


        #region Reversal algorithm to rotate an array
        public int[] ReverseAlgoToRotateAnArray(int[] array, int rotations, int length)
        {
            ReverseArray(array, 0, rotations - 1);
            ReverseArray(array, rotations, length - 1);
            ReverseArray(array, 0, length - 1);
            return array;
        }

        public void ReverseArray(int[] arr, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        #endregion

        #region Block Swap Algorithm 


        #endregion



        public void Print(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

    }
}
