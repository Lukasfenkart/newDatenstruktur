using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        Node firstint = null;
        Node lastint = null;
        int count = 0;

        public void add(Node newNode)
        {
            if (firstint == null)
            {
                firstint = newNode;
                lastint = newNode;
            }
            else
            {
                lastint.next = newNode;
                lastint = newNode;
            }
            count++;
        }

        public int size()
        { return count; }

    }
}
