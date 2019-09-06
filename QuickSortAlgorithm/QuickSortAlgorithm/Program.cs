using System;
using System.Collections.Generic;

namespace QuickSortAlgorithm
{
    class Program
    {
        public static int partition(List<int> seq, int start, int stop)
        {
            int indexPivot = start;
            int pivot = seq[indexPivot];
            int i = start + 1;
            int j = stop - 1;

            while (i <= j)
            {
                while (i <= j && !(pivot < seq[i]))
                {
                    i++;
                }
                while (i <= j && pivot < seq[j])
                {
                    j--;
                }
                if (i < j)
                {
                    int temp = seq[i];
                    seq[i] = seq[j];
                    seq[j] = temp;
                    i++;
                    j--;
                }
            }
            seq[indexPivot] = seq[j];
            seq[j] = pivot;

            return j;
        }

        public static void QuickSort(List<int> seq, int start, int stop)
        {
            if (start >= stop - 1)
            {
                return;
            }
            int indexPivot = partition(seq, start, stop);
            QuickSort(seq, start, indexPivot);
            QuickSort(seq, indexPivot + 1, stop);
            
        }

        static void Main(string[] args)
        {
            List<int> seq = new List<int>() { 2, 3, 6, 5, 1, 8, 9, 4, 7 };
            QuickSort(seq, 0, seq.Count);
            Console.WriteLine(string.Join(",", seq));
        }
    }
}
