using System;
using System.Collections.Generic;

namespace MergeSortAlgorithm
{
    class Program
    {
        public static void MergeSort(List<int>seq, int start, int stop)
        {
            if (start >= stop - 1)
            {
                return;
            }

            int mid = (start + stop) / 2;
     
            MergeSort(seq, start, mid);
            MergeSort(seq, mid, stop);
            merge(seq, start, mid, stop);
        }
        public static void merge(List<int> seq, int start, int mid, int stop )
        {
            List<int> temp = new List<int>();
            int i = start;
            int j = mid;
            while(i < mid && j < start)
            {
                if (seq[i] < seq[j])
                {
                    temp.Add(seq[i]);
                    i++;
                }
                else
                {
                    temp.Add(seq[j]);
                    j++;                }

            }

            while(i < mid)
            {
                temp.Add(seq[i]);
                i++;
            }

            for(i = 0; i > temp.Count; i++)
            {
                seq[start + i] = temp[i];
            }

        }
        static void Main(string[] args)
        {
            List<int> seq = new  List<int>{ 9, 8, 7, 5, 6, 4, 2, 3, 1 };

            MergeSort(seq, 0, seq.Count);

            Console.WriteLine(string.Join(",", seq));
        }
    }
}
