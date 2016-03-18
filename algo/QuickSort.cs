using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class QuickSort
    {
        private int[] numbers;
        private int length;

        public void sort(int[] values)
        {
            if (values == null || values.Length == 0)
                return;

            this.numbers = values;
            this.length = values.Length;
            quickSort(0, length - 1);
        }

        private void quickSort(int low, int high)
        {
            int i = low;
            int j = high;

            int middle = low + (high - low) / 2;
            int pivotNumber = this.numbers[middle];

            while(i < j)
            {
                while(this.numbers[i] < pivotNumber)
                {
                    i++;
                }

                while(this.numbers[j] > pivotNumber)
                {
                    j--;
                }


                if(i <= j)
                {
                    exchange(i, j);
                    i++;
                    j--;
                }
            }


            // Recursion
            if (low < j)
                quickSort(low, j);
            if (i < high)
                quickSort(i, high);

        }


        private void exchange(int i, int j)
        {
            int temp = this.numbers[i];
            this.numbers[i] = this.numbers[j];
            this.numbers[j] = temp;
        }




    }
}
