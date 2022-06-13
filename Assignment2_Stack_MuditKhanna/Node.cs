using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Stack_MuditKhanna
{
    internal class Node<T>
    {
        public Node<T> nextNode { get; set; }
        public T nodeData { get; set; }

        public Node(T nodeData)
        {
            this.nodeData = nodeData;
        }
    }
}
