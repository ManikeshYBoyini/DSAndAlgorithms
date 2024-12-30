using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public static class MiniIndexDistArray
    {
        public static int MinDistance(int[] arr, int x, int y) //{,7,5,5,1,8,9}
        {
            if (arr.Contains(x) && arr.Contains(y))
            {
                int IndX = Array.FindIndex(arr, W => W == x);
                List<int> lstYIndex = new List<int>();

                foreach (int a in arr)
                {
                    if (a == y)
                        lstYIndex.Add(Array.FindIndex(arr, w => w == y));
                }

                int minDiff = int.MaxValue;
                foreach (int ind in lstYIndex)
                {
                    if (minDiff > Math.Abs(IndX - ind))
                        minDiff = Math.Abs(IndX - ind);
                }
                return minDiff;
            }
            return -1;
        }
    }
}
