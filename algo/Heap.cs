using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class Heap
    {
        int size = 0;
        int[] heap;
        int[] sortedHeap;

        public int[] getResult()
        {
            return heap;
        }

        public Heap(int[] input)
        {
            this.size = 0;
            this.heap = new int[input.Length + 1];
            this.heap[0] = Int32.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                insert(input[i]);
            }

            maxHeap();
        }

        public void buildMaxHeap(int[] input)
        {
            
            this.heap = new int[this.size+1];
            this.heap[0] = Int32.MaxValue;
            this.size = 0;
            for (int i = 1; i < heap.Length; i++)
            {
                insert(input[i]);
            }

            maxHeap();
        }

        private int parent(int pos)
        {
            return pos / 2;
        }

        private int leftChild(int pos)
        {
            return (2 * pos);
        }

        private int rightChild(int pos)
        {
            return (2 * pos) + 1;
        }

        private bool isLeaf(int pos)
        {
            if (pos >= (size / 2) && pos <= size)
            {
                return true;
            }
            return false;
        }

        private void swap(int pos1, int pos2)
        {
            int temp = this.heap[pos1];
            this.heap[pos1] = this.heap[pos2];
            this.heap[pos2] = temp;
        }

        public void insert(int element)
        {
            heap[++size] = element;
            int current = size;

            while (heap[current] > heap[parent(current)])
            {
                swap(current, parent(current));
                current = parent(current);
            }
        }

        public int[] sort()
        {
            if(this.sortedHeap == null)
            {
                this.sortedHeap = new int[this.heap.Length];
            }

            for(int i = (heap.Length - 1); i > 0; i--)
            {
                int largest = this.heap[1];
                this.heap[1] = heap[i];
                this.size--;              
                this.sortedHeap[i] = largest;
               
                buildMaxHeap(this.heap);                                       
            }

            return this.sortedHeap;
        }

        //public void print()
        //{
        //    for (int i = 1; i <= size / 2; i++)
        //    {
        //        System.Console.WriteLine(" PARENT : " + heap[i] + " LEFT CHILD : " + heap[2 * i]
        //              + " RIGHT CHILD :" + heap[2 * i + 1]);
        //        System.Console.WriteLine();
        //    }
        //}



        private void maxHeapify(int pos)
        {
            if (!isLeaf(pos))
            {
                if (heap[pos] < heap[leftChild(pos)] || heap[pos] < heap[rightChild(pos)])
                {
                    if (heap[leftChild(pos)] > heap[rightChild(pos)])
                    {
                        swap(pos, leftChild(pos));
                        maxHeapify(leftChild(pos));
                    }
                    else
                    {
                        swap(pos, rightChild(pos));
                        maxHeapify(rightChild(pos));
                    }
                }
            }
        }

        public void maxHeap()
        {             
            for (int pos = (size / 2); pos >= 1; pos--)
            {
                maxHeapify(pos);
            }
        }

    }
}
