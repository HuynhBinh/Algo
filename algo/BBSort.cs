using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class BBSort
    {
        private int[] numbers;
        bool isFinish = true;
        int length = 0;

        public void sort(int[] values)
        {
            if (values == null || values.Length == 0)
                return;

            this.numbers = values;
            length = values.Length;
            bbsort2();
        }


        private void bbsort()
        {
            isFinish = true;

            for(int i = 0; i < length - 1; i++)
            {
                if(numbers[i] < numbers[i+1])
                {
                    exchange(i, i + 1);
                    isFinish = false;
                }
            }

            if(isFinish == false)
            {
                bbsort();
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    System.Console.WriteLine(numbers[i]);
                }
            }

        }

        private void bbsort2()
        {
            while(isFinish)
            {
                isFinish = false;
                for(int i = 0; i < length - 1; i++)
                {
                    if(numbers[i] > numbers[i+1])
                    {
                        exchange(i, i + 1);
                        isFinish = true;                 
                    }
                }
            }


            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine(numbers[i]);
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
