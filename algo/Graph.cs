using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{

    class Vertex
    {
        public string Name { get; set; }
        public bool IsVisited { get; set; }
        public int Distance { get; set; }
        public int Predecessor { get; set; }
    }

    class Graph
    {
        int width;
        int heigh;
        int[][] board;
        Queue<int> queue;
        List<Vertex> vertexs;

        public Graph(int heigh, int width)
        {
            this.width = width;
            this.heigh = heigh;

            this.vertexs = new List<Vertex>();

            initGraph(heigh, width);

            queue = new Queue<int>();
        }

        private void initGraph(int heigh, int width)
        {
            board = new int[heigh][];
            for (int i = 0; i < heigh; i++)
            {
                board[i] = new int[width];
                //init default value = 0
                for (int j = 0; j < width; j++)
                {
                    board[i][j] = 0;
                }
            }
        }


        private int getUnVisitedAdjadencyVertex(int currentVertext)
        {
            for (int i = 0; i < width; i++)
            {
                if (board[currentVertext][i] == 1 && vertexs[i].IsVisited == false)
                {
                    return i;
                }
            }

            return -1;
        }

        private void resetGraph()
        {
            for (int i = 0; i < vertexs.Count(); i++)
            {
                vertexs[i].IsVisited = false;
            }
        }


        private void printVertext(int index)
        {
            System.Console.WriteLine(vertexs[index].Name);
        }

        public void addEdge(int from, int to)
        {
            board[from][to] = 1;
            board[to][from] = 1;
        }

        public void addVertex(string name)
        {
            Vertex vertex = new Vertex();
            vertex.Name = name;
            vertex.IsVisited = false;
            vertex.Distance = 0;

            vertexs.Add(vertex);
        }

        public void breathFirstSearch()
        {
            // mark first vertex visited
            vertexs[0].IsVisited = true;

            // enqueue the first vertex
            queue.Enqueue(0);

            // print it
            printVertext(0);


            int unvisitedVertex;

            while (queue.Count > 0)
            {
                int tempIndexVertext = queue.Dequeue();
                while ((unvisitedVertex = getUnVisitedAdjadencyVertex(tempIndexVertext)) != -1)
                {
                    vertexs[unvisitedVertex].IsVisited = true;
                    printVertext(unvisitedVertex);
                    queue.Enqueue(unvisitedVertex);
                }
            }


            // reset data in graph
            resetGraph();
        }

        public void breathFirstSearchWithDistance()
        {
            // innitially, set source vertex as visited and distance = 0
            vertexs[0].IsVisited = true;
            vertexs[0].Distance = 0;
            vertexs[0].Predecessor = -1;

            // enqueue source vertex
            queue.Enqueue(0);

            // print it
            printVertext(0);

            int unvisitedVertex;

            while(queue.Count() > 0)
            {

                int currentVertex = queue.Dequeue();
                int currentDistance = vertexs[currentVertex].Distance;

                while((unvisitedVertex = getUnVisitedAdjadencyVertex(currentVertex)) != -1)
                {
                    vertexs[unvisitedVertex].IsVisited = true;
                    vertexs[unvisitedVertex].Distance = currentDistance + 1;
                    vertexs[unvisitedVertex].Predecessor = currentVertex;
                    queue.Enqueue(unvisitedVertex);
                    printVertext(unvisitedVertex);
                }

            }


            for(int k = 0; k < vertexs.Count(); k++)
            {
                System.Console.WriteLine("Destination: " + vertexs[k].Name + " - Distance: " + vertexs[k].Distance + " ");
                printPath(vertexs[k]);
                System.Console.WriteLine();
            } 

        }

        private void printPath(Vertex v)
        {
            if(v.Predecessor == -1)
            {
                System.Console.Write("" + v.Name + "");
                return;
            }

            System.Console.Write("" + v.Name +  "->");

            printPath(vertexs[v.Predecessor]);

        }
    }
}
