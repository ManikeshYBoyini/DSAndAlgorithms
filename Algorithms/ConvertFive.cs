using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class ConvertFive
    {
        public static void ConverZeroToFive(int num) //2504523  //2554523
        {
            if (num != 0)
            {
                List<int> listOfNums = new List<int>();
                while (num > 0)
                {
                    listOfNums.Add(num % 10);
                    num = num / 10;
                }
                listOfNums.Reverse();
                for (int i = 0; i < listOfNums.Count; i++)
                {
                    if (listOfNums[i] == 0)
                    {
                        Console.Write(5);
                        continue;
                    }
                    Console.Write(listOfNums[i]);
                }
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}
