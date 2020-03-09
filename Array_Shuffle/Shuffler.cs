using System;
using System.Collections.Generic;

namespace ArrayShuffle
{
    public class Shuffler
    {
        public static IList<int> ShuffleArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Random rnd = new Random();
                int randomInt = rnd.Next(array.Length);
                Swap(ref array[i], ref array[randomInt]);
            }
            return array;
        }

        private static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}