using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace MyStack
{
    public class MyStack
    {
        LinkedList.LinkedList internalList = new LinkedList.LinkedList();
        public Node Push(int newNode)
        {
            var nodeToAdd = new Node(newNode, null);
            internalList.insertlast(newNode);
            return nodeToAdd;
        }
        public Node Pop()
        {
            var retval = internalList.GetLast();
            internalList.deletelast();
            return retval;
        }
        public override string ToString()
        {
            return internalList.ToString();
        }
        public 
    }
}
