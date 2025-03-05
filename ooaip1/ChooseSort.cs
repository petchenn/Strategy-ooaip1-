using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooaip1
{
    class ChooseSort : ISort
    {
        public int[] Sort(int[] array, bool org)
        {
            Console.WriteLine("ChooseSort: \n");

            for(int i = 0; i< array.Length - 1; i++)
            {
                int min = i;
                for(int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
            return array;
        }
    }
}
