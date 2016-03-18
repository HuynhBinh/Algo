using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 100, 4, 32, 33, 45, 1, 12, 0, 17, 500, 1000, 45, 12, 54, 67, 87, 11, 9 };
            //QuickSort qs = new QuickSort();
            //qs.sort(values);

            //for (int i = 0; i < values.Length; i++)
            //{
            //    System.Console.WriteLine(values[i]);
            //}

            //BBSort bbsort = new BBSort();
            //bbsort.sort(values);

            //BinarySearch biSearch = new BinarySearch();
            //biSearch.search(values, 0);
            // MergeSort mSort = new MergeSort();

            //mSort.sort(values);

            //InsertionSort iSort = new InsertionSort();
            //iSort.sort(values);



            //Heap heap = new Heap(values);
            ////eap.buildMaxHeap(values);
            //int[] result = heap.getResult();

            //int[] result1 = heap.sort();

            //for (int i = 0; i < result1.Length; i++)
            //{
            //    System.Console.WriteLine(result1[i]);
            //}
            ////heap.print();


            //BinaryTree binaryTree = new BinaryTree(34);
            //binaryTree.addNode(12);
            //binaryTree.addNode(37);
            //binaryTree.addNode(100);
            //binaryTree.addNode(28);
            //binaryTree.addNode(19);
            //binaryTree.addNode(23);
            //binaryTree.addNode(355);
            //binaryTree.addNode(7);
            //binaryTree.addNode(1);
            //binaryTree.addNode(55);

            //binaryTree.postOrder();


            //BinarySearch bs = new BinarySearch();
            //int result = bs.biSearchWhile(values, 999);
            //System.Console.WriteLine(result);

            //SelectionSort ss = new SelectionSort();
            //ss.sort(values);

            //Factorial fac = new Factorial();
            //int res = fac.interativeFactorial(0);

            //Palindrome pa = new Palindrome();
            //bool check = pa.isPalinddrome("rotor");
            //System.Console.WriteLine(check);

            //Factorial fac = new Factorial();
            //int res = fac.recursiveFactorial(3);
            //System.Console.WriteLine(res);
            //TowerOfHN town = new TowerOfHN();
            //town.move(3, "A", "B", "C");

            //Graph graph = new Graph(10, 10);
            //graph.addEdge(0, 1);
            //graph.addEdge(1, 2);
            //graph.addEdge(2, 3);
            //graph.addEdge(3, 4);
            //graph.addEdge(4, 5);
            //graph.addEdge(5, 6);
            //graph.addEdge(6, 7);
            //graph.addEdge(7, 8);
            //graph.addEdge(8, 9);

            //graph.addEdge(2, 5);
            //graph.addEdge(2, 7);
            //graph.addEdge(2, 8);
            //graph.addEdge(2, 0);

            //graph.addEdge(3, 6);
            //graph.addEdge(3, 1);
            //graph.addEdge(3, 9);


            //graph.addEdge(5, 7);
            //graph.addEdge(5, 1);
            //graph.addEdge(5, 3);

            //graph.printGraph();

            Graph graph = new Graph(10, 10);

            graph.addVertex("S"); // 0
            graph.addVertex("A");//1
            graph.addVertex("B");//2
            graph.addVertex("C");//3
            graph.addVertex("D");//4
            graph.addVertex("E");//5
            graph.addVertex("F");//6
            graph.addVertex("G");//7
            graph.addVertex("H");//8
            graph.addVertex("I");//9
            graph.addVertex("J");//10

            graph.addEdge(0, 1);
            graph.addEdge(0, 2);
            graph.addEdge(0, 3);
            graph.addEdge(1, 10);
            graph.addEdge(10, 4);
            graph.addEdge(4, 7);

            graph.addEdge(2, 5);
            graph.addEdge(5, 7);

            graph.addEdge(3, 6);
            graph.addEdge(6, 7);

            graph.addEdge(7, 8);
            graph.addEdge(8, 9);

            graph.breathFirstSearchWithDistance();


        }
    }
}
