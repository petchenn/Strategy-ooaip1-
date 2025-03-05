using System;

namespace ooaip1
{
    class QuickSort : ISort
    {
        static void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }

        static int Partition(int[] array, int minInd, int maxInd)
        {
            int pivotValue = array[maxInd]; 
            int pivotIndex = minInd - 1;

            for (int i = minInd; i < maxInd; i++)
            {
                if (array[i] < pivotValue) 
                {
                    pivotIndex++;
                    Swap(ref array[pivotIndex], ref array[i]);
                }
            }
            pivotIndex++;
            Swap(ref array[pivotIndex], ref array[maxInd]); 
            return pivotIndex;
        }

        static void QuickSortInner(int[] array, int minInd, int maxInd)
        {
            if (minInd < maxInd)
            {
                int pivotIndex = Partition(array, minInd, maxInd);
                QuickSortInner(array, minInd, pivotIndex - 1);
                QuickSortInner(array, pivotIndex + 1, maxInd);
            }
        }

        public int[] Sort(int[] array, bool org)
        {
            if (array == null || array.Length == 0)
                return array;

            Console.WriteLine("QuickSort: \n");
            QuickSortInner(array, 0, array.Length - 1);
            return array;
        }
    }
}
