using Algorithms._DataSrtucture.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tree
{
    public class BinaryTreeAlgorithms
    {
        String resultString;

        /// <summary>
        /// in odrer traverse (left -> node -> right)
        /// </summary>
        /// <param name="node">root node</param>
        public string InOrderTraverse(TreeNode node)
        {
            if (node == null)
                return "";

            // first recur on left chiled
            InOrderTraverse(node.Left);

            // then print the data of node
            resultString += node.Data + " ";

            // now recur on right child
            InOrderTraverse(node.Right);

            return resultString;
        }

        /// <summary>
        /// pre order traverse (node -> left -> right)
        /// </summary>
        /// <param name="node">root node</param>
        public string PreOrderTraverse(TreeNode node)
        {
            if (node == null)
                return "";

            // first print data of the node
            resultString += node.Data + " ";

            // then recur on left subtree
            PreOrderTraverse(node.Left);

            // now recur on right subtree
            PreOrderTraverse(node.Right);

            return resultString;
        }

        /// <summary>
        /// post order traverse (left -> right -> node)
        /// </summary>
        /// <param name="node">root node</param>
        public string PostOrderTraverse(TreeNode node)
        {
            if (node == null)
                return "";

            // first recur on left subtree
            PostOrderTraverse(node.Left);

            // then resuc on right subtree
            PostOrderTraverse(node.Right);

            // now print data of the node
            resultString += node.Data + " ";

            return resultString;
        }

        public string TraverseNoRecurtion(TreeNode node)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            while (queue.Any())
            {
                var item = queue.Dequeue();

                if (item.Left != null)
                    queue.Enqueue(item.Left);

                if (item.Right != null)
                    queue.Enqueue(item.Right);

                resultString += item.Data + " ";
            }

            return resultString;
        }

        /// <summary>
        /// compute the height of a tree
        /// </summary>
        /// <param name="node">root node</param>
        /// <returns>tree hight</returns>
        public int GetTreeHeight(TreeNode node)
        {
            if (node == null)
                return 0;

            int lHeigh = GetTreeHeight(node.Left);
            int rHeigh = GetTreeHeight(node.Right);

            if (lHeigh > rHeigh)
            {
                return lHeigh + 1;
            }
            else
            {
                return rHeigh + 1;
            }
        }

        /// <summary>
        /// depth-first search
        /// </summary>
        /// <param name="node"></param>
        /// <param name="data"></param>
        /// <returns>tree node</returns>
        public TreeNode Search(TreeNode node, int data)
        {
            while (node.Data != data)
            {
                if (node != null)
                {
                    if (node.Data > data)
                    {
                        node = node.Left;
                    }
                    else
                    {
                        node = node.Right;
                    }

                    if (node == null)
                        return null;
                }
                
            }

            return node;
        }

        /// <summary>
        /// insert element into a binary tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="date"></param>
        public void Insert(TreeNode root, int data)
        {
            var newNode = new TreeNode(data);

            // if tree is empty
            if (root == null)
            {
                root = newNode;
                return;
            }

            var current = root;
            TreeNode parent = null;

            while(true)
            {
                parent = current;

                if (data < parent.Data)
                {
                    current = current.Left;

                    if (current == null)
                    {
                        parent.Left = newNode;
                        return;
                    }
                }
                else
                {
                    current = current.Right;

                    if (current == null)
                    {
                        parent.Right = newNode;
                        return;
                    }
                }
            }
        }
    }
}
