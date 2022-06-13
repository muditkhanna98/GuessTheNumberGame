using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Stack_MuditKhanna
{
    internal class SinglyLinkedList<T>
    {
        public Node<T>? HeadNode { get; private set; }
        public Node<T>? TailNode { get; private set; }
        public int Count { get; set; }

        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Count == 0)
            {
                HeadNode = TailNode = node;
                Count++;
            }
            else
            {
                //to establish link between the new node and the head node
                node.nextNode = HeadNode;
                HeadNode = node;
                Count++;
            }
        }

        public void AddLast(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Count == 0)
            {
                HeadNode = TailNode = node;
                Count++;
            }
            else
            {
                TailNode.nextNode = node;
                TailNode = node;
                Count++;
            }
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    HeadNode = TailNode = null;
                    Count--;
                }
                else
                {
                    Node<T> secondNode = HeadNode.nextNode;
                    HeadNode.nextNode = null;
                    HeadNode = secondNode;
                    Count--;
                }
            }
        }

        public void RemoveLast()
        {
            Node<T>? previous = null;
            if (Count != 0)
            {
                //to get the reference to the last second node
                Node<T> current = HeadNode;
                while (current.nextNode != null)
                {
                    if (current.nextNode == TailNode)
                    {
                        previous = current;
                    }
                    current = current.nextNode;
                }
                TailNode = previous;
                TailNode.nextNode = null;
                Count--;
            }
        }

        public void Clear()
        {
            HeadNode = TailNode = null;
        }
    }
}
