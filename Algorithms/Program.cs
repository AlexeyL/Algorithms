using Algorithms.Numerical;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Security.Authentication.ExtendedProtection;
using System.Collections.Generic;
using System.Collections;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ccrab = new CoconutCrab();
            //var res = ((Crab) ccrab).PinchClaws();
            //Console.WriteLine(res);

            //LinkedList<String> myList = new LinkedList<String>();

            //myList.AddLast("Zoya");
            //myList.AddLast("Shilpa");

            //Console.WriteLine(myList.First.Next.Value);

            //Console.ReadLine();

            LinkedList1 list = new LinkedList1();
            list.Push(3);
            list.Push(2);
            list.Push(1);
            list.Print();

            list.DeleteAt(2);
            list.Print();


            Console.ReadLine();


        }
    }

    //public class Crab
    //{
    //    public virtual string PinchClaws()
    //    {
    //        return "hello from parent";
    //    }
    //}

    //public class CoconutCrab : Crab
    //{
    //    public override string PinchClaws()
    //    {
    //        return "hello from child";
    //    }
    //}

    public class Node1
    {
        public int Value { get; set; }
        public Node1 Next { get; set; }

        public Node1(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedList1
    {
        Node1 head;

        public void Push (int newValue)
        {
            Node1 newNode = new Node1(newValue);
            newNode.Next = head;
            head = newNode;
        }

        public void Append(int newValue)
        {
            Node1 newNode = new Node1(newValue);

            Node1 currentNode = head;
            while(currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = newNode;
        }

        public bool Search(Node1 head, int x)
        {
            Node1 currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Value == x)
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }

            return false;
        }

        public bool SearchRecurcive(Node1 node, int x)
        {
            if (node == null)
                return false;

            if (node.Value == x)
                return true;

            return SearchRecurcive(node.Next, x);
        }

        public void DeleteFirst()
        {
            head = head.Next;
        }

        public void DeleteLast()
        {
            Node1 currentNode = head;
            if (currentNode != null && currentNode.Next != null)
            {
                while(currentNode.Next.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = null;
            }
        }

        public void DeleteAt(int index)
        {
            Node1 currentNode = head;
            for (int i = 1; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = currentNode.Next.Next;
        }


        public void Reverse()
        {
            Node1 prev = null;
            Node1 current = head;
            Node1 next = null;

            while(current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                
                current = next;
            }
        }

        public bool isCircular(Node1 head)
        {
            if (head == null)
                return true;

            Node1 node = head.Next;

            while(node != null && node != head)
            {
                node = node.Next;
            }

            return node == head;
        }

        public void Print()
        {
            Node1 currentNode = head;

            while(currentNode != null)
            {
                Console.Write(currentNode.Value + " ");
                currentNode = currentNode.Next;
            }

            Console.WriteLine();
        }
    }
}
