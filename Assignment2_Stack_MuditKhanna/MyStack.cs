using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Stack_MuditKhanna
{
    internal class MyStack<T> : IEnumerable<T>
    {
        SinglyLinkedList<T> myList = new SinglyLinkedList<T>();
        public int count = 0;

        public void Push(T item)
        {
            myList.AddFirst(item);
            count++;
        }

        public T pop()
        {
            T value = myList.HeadNode.nodeData;
            myList.RemoveFirst();
            count--;
            return value;
        }

        public T Peek()
        {
            return myList.HeadNode.nodeData;
        }

        public void Clear()
        {
            myList.Clear();
            count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (myList.HeadNode != null)
            {
                Node<T> current = myList.HeadNode;
                while (current != null)
                {
                    yield return current.nodeData;
                    current = current.nextNode;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
