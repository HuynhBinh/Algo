using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class BinarySearch
    {

        int[] numbers;
        int number;
        int length = 0;
        int NoOfCompare = 0;

        public void search(int[] values, int value)
        {
            this.numbers = values;
            this.length = values.Length;
            this.number = value;
            //biSearch(0, length-1);
            biSearch2();

        }

        private void biSearch(int low1, int high1)
        {
            NoOfCompare++;
            int low = low1;
            int high = high1;
            int middle = low + (high - low) / 2;

            if (numbers[middle] > number)
            {
                high = middle - 1;
            }

            if (numbers[middle] < number)
            {
                low = middle + 1;
            }

            if (numbers[middle] != number)
            {
                if(low <= high)
                {
                    biSearch(low, high);
                }
                else
                {
                    System.Console.WriteLine("cannot find");
                }           
            }
            else
            {         
                System.Console.WriteLine("No of compare: " + NoOfCompare);
                System.Console.WriteLine("low: " + low);
                System.Console.WriteLine("high: " + high);

            }

        }

       

        private void biSearch2()
        {
            NoOfCompare++;
            int low = 0;
            int high = length;
            int middle = low + (high - low) / 2;

            while (numbers[middle] != number && low <= high)
            {
                if (numbers[middle] > number)
                {
                    high = middle - 1;
                }

                if (numbers[middle] < number)
                {
                    low = middle + 1;
                }           
                middle = (high - low) / 2;
            }

            if(low <= high)
            {
                System.Console.WriteLine("No of compare: " + NoOfCompare);
                System.Console.WriteLine("low: " + low);
                System.Console.WriteLine("high: " + high);
            }
            else
            {
                System.Console.WriteLine("cannot find");
            }



        }


        public int biSearchWhile(int[] data, int key)
        {
            int min = 0;
            int max = data.Length - 1;
            int guess;

            while(min <= max)
            {
                guess = min + (max - min) / 2;

                if(data[guess] == key)
                {
                    return guess;
                }

                if(data[guess] < key)
                {
                    min = guess + 1;                       
                }
                else
                {
                    max = guess - 1;
                }
            }

            return -1;
        }



    }
}
