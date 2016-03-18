using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class BinaryTree
    {
        int key;
        BinaryTree left;
        BinaryTree right;

        public BinaryTree(int key)
        {
            this.key = key;
            left = null;
            right = null;
        }


        public void addNode(int value)
        {
            if(value < this.key)
            {
                if(this.left == null)
                {
                    this.left = new BinaryTree(value);
                }
                else
                {
                    this.left.addNode(value);
                }
            }
            else
            {
                if(this.right == null)
                {
                    this.right = new BinaryTree(value);
                }
                else
                {
                    this.right.addNode(value);
                }

            }
        }

        public void inOrder()
        {
            if(this.left != null)
            {
                this.left.inOrder();
            }

            System.Console.WriteLine(this.key);

            if(this.right != null)
            {
                this.right.inOrder();
            }
        }

        public void postOrder()
        {
            if(this.right != null)
            {
                this.right.postOrder();
            }

            System.Console.WriteLine(this.key);

            if(this.left != null)
            {
                this.left.postOrder();
            }

        }

        public void search(int number)
        {
            if(number == this.key)
            {
                System.Console.WriteLine("find");
            }

            if(number < this.key)
            {

            }
        }


    }
}
