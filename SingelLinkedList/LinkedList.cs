using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        Node head = null;
        Node lastint = null;
        int count = 0;

        public void addlast(int newNode) 
        {
            Node currentNode = head;
            if (head == null)
            {
                head = new Node(newNode, null);

            }
            else
            {
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = new Node(newNode, null);
            }
            count++;
        }
        public Node GetNode(int argData)
        {
            Node currentNode = head;
            while (currentNode?.data != argData)
            {
                if(currentNode == null)
                {
                    Console.WriteLine("flase");
                    return null;
                }
                currentNode = currentNode.next;
            }
            return currentNode;
        }
        public void insertafter(Node argData)
        {
            Node currentNode = head;
            while(currentNode != argData)
            {
                currentNode = currentNode?.next;
            }
            currentNode.next = new Node(newNode, currentNode);
        }

        public void addfirst(int newNode)
        {
            head = new Node(newNode, head);
            count++;
        }
        public void deletelast()
        {
            if (head == null)
            {
                Console.WriteLine("false");
            }
            else
            {
                if (head != lastint)
                {
                    head = head.next;
                }

                else
                {
                    head = lastint = null;
                }
                count--;
            }
        }
        
        public Node GetFirst()
        {
            return head;
        }
        public int size()
        { return count; }

    }
}
