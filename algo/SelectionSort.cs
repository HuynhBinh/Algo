using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class SelectionSort
    {
        private void swap(int[] array, int pos1, int pos2)
        {
            int temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;
        }

        private int indexOfMininum(int[] array, int startPos)
        {
            int min = array[startPos];
            int minIndex = startPos;

            for(int i = startPos + 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }


        public void sort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int minIndex = indexOfMininum(array, i);
                swap(array, minIndex, i);
            }

            print(array);
        }

        public void print(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }
    }
}
