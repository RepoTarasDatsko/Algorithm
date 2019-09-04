using System;
using System.Collections.Generic;

namespace SelecrionSortAlgoritm
{
    class Program
    {
        public static List<int> SelectArg(List<int> seq)
        {
            for (int i = 0; i < seq.Count; i++) 
            {
                int minindex = select(seq, i);
                int temp = seq[i];
                seq[i] = seq[minindex];
                seq[minindex] = temp;

            }
            return seq;
        }
        public static int select(List<int> seq, int start)
        {
            int minindex = start; 
            for (int y = start + 1; y < seq.Count; y++)
            {
                if (seq[minindex] < seq[y])
                {
                    minindex = y;
                }
            }
            return minindex;
        }
        static void Main(string[] args)
        {
            var list = new List<int>() { 2, 5, 3, 6, 7, 8 ,9 , 4, 1};
            Console.WriteLine(string.Join(",",SelectArg(list)));
        }
    }
}
