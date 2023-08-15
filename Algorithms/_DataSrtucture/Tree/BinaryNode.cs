using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms._DataSrtucture.Tree
{
    public class BinaryNode
    {
        public int Value { get; set; }
        public BinaryNode LeftChild { get; set; }
        public BinaryNode RightChild { get; set; }

        public BinaryNode(int name)
        {
            this.Value = name;
        }

        public void TraversePreorder(BinaryNode node)
        {
            Console.WriteLine(node.Value);

            if (node.LeftChild != null)
                TraversePreorder(node.LeftChild);

            if (node.RightChild != null)
                TraversePreorder(node.RightChild);
        }

        public void TraverseInorder(BinaryNode node)
        {
            if (node.LeftChild != null)
                TraverseInorder(node.LeftChild);

            Console.WriteLine(node.Value);

            if (node.RightChild != null)
                TraverseInorder(node.RightChild);
        }

        public void TraversePostorder(BinaryNode node)
        {
            if (node.LeftChild != null)
                TraversePostorder(node.LeftChild);

            if (node.RightChild != null)
                TraversePostorder(node.RightChild);

            Console.WriteLine(node.Value);
        }

        public void TraverseDepthFirst(BinaryNode root)
        {
            Queue<BinaryNode> children = new Queue<BinaryNode>();

            children.Enqueue(root);

            while (children.Count > 0)
            {
                BinaryNode child = children.Dequeue();

                Console.WriteLine(child.Value);

                if (child.LeftChild != null)
                    children.Enqueue(child.LeftChild);

                if (child.RightChild != null)
                    children.Enqueue(child.RightChild);
            }
        }

        public void AddNode(int value)
        {
            if (value < Value)
            {
                if (LeftChild == null)
                    LeftChild = new BinaryNode(value);
                else
                    LeftChild.AddNode(value);
            }
            else
            {
                if (RightChild == null)
                    RightChild = new BinaryNode(value);
                else
                    RightChild.AddNode(value);
            }
        }

        public BinaryNode FindNode(int target)
        {
            if (target == Value)
                return this;

            if (target < Value)
            {
                if (LeftChild == null)
                    return null;

                return LeftChild.FindNode(target);
            }
            else
            {
                if (RightChild == null)
                    return null;

                return RightChild.FindNode(target);
            }
        }
    }
}
