using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class InsertionSort
    {

        int[] numbers;

        public void sort(int[] num)
        {
            this.numbers = num;
            int i;                     // the number of items sorted so far

            for (i = 1; i < num.Length; i++)    // Start with 1 (not 0)
            {
                for (int j = i; (j > 0) ; j--)   // Smaller values are moving up
                {
                    if(num[j] < num[j - 1])
                    {
                        exchange(j, j - 1);
                    }                               
                }              
            }


            for (int ik = 0; ik < num.Length; ik++)
            {
                System.Console.WriteLine(num[ik]);
            }

        }


        private void exchange(int i, int j)
        {
            int temp = this.numbers[i];
            this.numbers[i] = this.numbers[j];
            this.numbers[j] = temp;
        }
    }
}
