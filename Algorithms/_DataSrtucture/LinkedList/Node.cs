using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms._DataSrtucture.LinkedList
{
    public class Node
    {
        public Node Next { get; set; }
        public Node Previous { get; set; }
        public int? Value { get; set; }

        public Node() { }

        public Node(int value): this(value, null)
        {
        }

        public Node(int value, Node next)
        {
            Value = value;
            Next = next;
        }

    }
}
