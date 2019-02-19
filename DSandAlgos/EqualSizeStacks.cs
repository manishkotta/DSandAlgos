using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DSandAlgos
{

    public class Stack
    {
        public int _height = 0;
        public int _length;
        int[] _elements = null;
        public int index = 0;

        public Stack(int[] elements)
        {
            _length = elements.Length;
            _elements = elements;
            _height = GetHeight();
        }

        public int GetHeight()
        {
            int total = 0;
            for (int i = 0; i < this._elements.Length; i++)
            {
                total += this._elements[i];
            }
            return total;
        }

        public void Pop()
        {
            if (index < _length)
            {
                _height -= _elements[index];
                index++;
            }
        }

    }

    public class EqualSizeStacks
    {

        // Recursion appraoch
        static int getHeight(int[] h)
        {
            var total = 0;
            for (int i = 0; i < h.Length; i++)
            {
                total += h[i];
            }
            return total;
        }

        // Recurssion appraoch
        static int getPerfectHeight(int[] h1, int[] h2, int[] h3, int s1, int s2, int s3, int i1, int i2, int i3)
        {
            if (s1 == s2 && s2 == s3)
                return s1;
            else if (s1 == s2)
            {
                if (s2 < s3)
                {
                    var j = h3[i3];
                    s3 = s3 - j;
                    i3++;
                    return getPerfectHeight(h1, h2, h3, s1, s2, s3, i1, i2, i3);
                }
                else
                {
                    var i = h2[i2];
                    s2 = s2 - i;
                    i2++;
                    var j = h1[i1];
                    s1 = s1 - j;
                    i1++;
                    return getPerfectHeight(h1, h2, h3, s1, s2, s3, i1, i2, i3);
                }
            }
            else if (s2 == s3)
            {
                if (s3 < s1)
                {
                    var j = h1[i1];
                    s1 = s1 - j;
                    i1++;
                    return getPerfectHeight(h1, h2, h3, s1, s2, s3, i1, i2, i3);
                }
                else
                {
                    var i = h2[i2];
                    s2 = s2 - i;
                    i2++;
                    var j = h3[i3];
                    s3 = s3 - j;
                    i3++;
                    return getPerfectHeight(h1, h2, h3, s1, s2, s3, i1, i2, i3);

                }
            }
            else if (s3 == s1)
            {
                if (s3 < s2)
                {
                    var i = h2[i2];
                    s2 = s2 - i;
                    i2++;
                    return getPerfectHeight(h1, h2, h3, s1, s2, s3, i1, i2, i3);
                }
                else
                {
                    var i = h1[i1];
                    s1 = s1 - i;
                    i1++;
                    var j = h3[i3];
                    s3 = s3 - j;
                    i3++;
                    return getPerfectHeight(h1, h2, h3, s1, s2, s3, i1, i2, i3);
                }
            }
            else if (s1 < s2 && s1 < s3)
            {
                if (s2 > s3)
                {
                    var i = h2[i2];
                    s2 = s2 - i;
                    i2++;
                    return getPerfectHeight(h1, h2, h3, s1, s2, s3, i1, i2, i3);
                }
                else
                {
                    var j = h3[i3];
                    s3 = s3 - j;
                    i3++;
                    return getPerfectHeight(h1, h2, h3, s1, s2, s3, i1, i2, i3);
                }
            }
            else if (s2 < s1 && s2 < s3)
            {
                if (s1 > s3)
                {
                    var i = h1[i1];
                    s1 = s1 - i;
                    i1++;
                    return getPerfectHeight(h1, h2, h3, s1, s2, s3, i1, i2, i3);
                }
                else
                {
                    var j = h3[i3];
                    s3 = s3 - j;
                    i3++;
                    return getPerfectHeight(h1, h2, h3, s1, s2, s3, i1, i2, i3);
                }
            }
            else if (s3 < s1 && s3 < s2)
            {
                if (s2 > s1)
                {
                    var i = h2[i2];
                    s2 = s2 - i;
                    i2++;
                    return getPerfectHeight(h1, h2, h3, s1, s2, s3, i1, i2, i3);
                }
                else
                {
                    var j = h1[i1];
                    s1 = s1 - j;
                    i1++;
                    return getPerfectHeight(h1, h2, h3, s1, s2, s3, i1, i2, i3);
                }
            }
            return getPerfectHeight(h1, h2, h3, s1, s2, s3, i1, i2, i3);
        }

        /*
         * Complete the equalStacks function below.
         */
        static int equalStacks(int[] h1, int[] h2, int[] h3)
        {
            Stack s1 = new Stack(h1);
            Stack s2 = new Stack(h2);
            Stack s3 = new Stack(h3);

            bool isEqual = false;

            while (!isEqual)
            {
                if (s1._height == s2._height && s2._height == s3._height)
                {
                    isEqual = true;
                    return s1._height;
                }
                else if (s1._height > s2._height && s1._height > s3._height)
                    s1.Pop();
                else if (s2._height > s3._height)
                    s2.Pop();
                else
                    s3.Pop();
            }

            return 0;

        }

        static void Main(string[] args)
        {
            int[] h1 = new int[] { 3, 2, 1, 1, 1 };
            int[] h2 = new int[] { 4, 3, 2 };
            int[] h3 = new int[] { 1, 1, 4, 1 };


            var x = equalStacks(h1, h2, h3);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }

}
