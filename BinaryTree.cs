using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree

{
    class BinaryTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinaryTree<T> LeftTree { get; set; }
        public BinaryTree<T> RightTree { get; set; }
        public BinaryTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        private bool result;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(item) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinaryTree<T>(item);
                else
                    this.LeftTree.Insert(item);
                     this.leftCount++;
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinaryTree<T>(item);
                else
                    this.RightTree.Insert(item);
                    this.rightCount++;
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
               
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
               
                this.RightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));

        }
        public bool Search(T element, BinaryTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in Binary Search Tree : " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in Binary Search Tree", node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                Search(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
               Search(element, node.RightTree);
            }
            return result;
        }
    }
}


