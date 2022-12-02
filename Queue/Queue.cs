using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Queue
{
    public class Queue
    {
        LinkedList.LinkedList internalList = new LinkedList.LinkedList();
        public Node Enqueue(int newNode)
        {
            var nodeToAdd = new Node(newNode, null);
            internalList.insertlast(newNode);
            return nodeToAdd;
        }
        public Node Dequeue()
        {
            var retval = internalList.GetFirst();
            internalList.deletefirst();
            return retval;
        }
        public override string ToString()
        {
            return internalList.ToString();
        }
    }
}
