using System;
namespace exercise
{
    public static class Exercises
    {
        public static object AboveBelow(int[] ints, int pivot)
        {
            int[] a = ints;
            int p = pivot;

            int abv = 0, bel = 0, len = a.Length;

            for (int i = 0; i < len; ++i)
            {
                if (a[i] < p)
                {
                    ++bel;
                }
                else if (a[i] > p)
                {
                    ++abv;
                }
            }

            var result = new { above = abv, below = bel };

            return result;
        }

        public static string StringRotation(string original, int rotation)
        {
            char[] og = original.ToCharArray();
            int len = original.Length, r = rotation;
            char[] newArr = new char[len];

            for (int i = 0; i < len; ++i)
            {
                newArr[i] = og[(len - r + i) % len];
            }

            string result = new string(newArr);

            return result;
        }
    }
}
