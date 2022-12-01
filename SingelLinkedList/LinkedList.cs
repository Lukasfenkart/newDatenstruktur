using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace LinkedList
{
    public class LinkedList : IMyList
    {
        Node head = null;
        Node lastint = null;
        private SortStrategy _strategy;
        int count = 0;

        public void insertfirst(int newNode)
        {
            head = new Node(newNode, head);
            count++;
        }
        public void insertlast(int newNode)
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
        public void insertafter(Node argData, int newNode)
        {
            Node currentNode = head;
            while (currentNode != argData)
            {
                currentNode = currentNode?.next;
            }
            currentNode.next = new Node(newNode, currentNode.next);
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
        public Node GetNode(int argData)
        {
            Node currentNode = head;
            while (currentNode?.data != argData)
            {
                if (currentNode == null)
                {
                    Console.WriteLine("flase");
                    return null;
                }
                currentNode = currentNode.next;
            }
            return currentNode;
        }
        public void Switch(Node firstNode, Node secondNode)
        {
            if (!Exists(firstNode) || !Exists(secondNode))
                return;
            (firstNode.data, secondNode.data) = (secondNode.data, firstNode.data);
        }
        public bool Exists(Node node)
        {
            Node currentNode = head;
            if (currentNode == node) return true;
            while (currentNode != null)
            {
                if (currentNode == node)
                {
                    return true;
                }
                currentNode = currentNode.next;
            }
            return false;
        }
        public void InsertionSort()
        {
            Node currentNode = head.next;
            while (currentNode != null)
            {
                for (var cur = head; cur != null; cur = cur.next)
                {
                    if (cur == currentNode)
                        break;
                    if ((int)cur.data < (int)currentNode.data)
                        continue;
                    (cur.data, currentNode.data) = (currentNode.data, cur.data);
                }
                currentNode = currentNode.next;
            }
        }
        public void InsertionSortReverse()
        {
            Node currentNode = head.next;
            while (currentNode != null)
            {
                for (var cur = head; cur != null; cur = cur.next)
                {
                    if (cur == currentNode)
                        break;
                    if ((int)cur.data > (int)currentNode.data)
                        continue;
                    (cur.data, currentNode.data) = (currentNode.data, cur.data);
                }
                currentNode = currentNode.next;
            }
        }
        public void BubbleSort()
        {
            bool sort = true;
            while (sort)
            {
                sort = false;
                Node currentNode = head;
                Node currentNodeNext = head.next;
                while (currentNodeNext != null)
                {
                    if (currentNode.data > currentNodeNext.data)
                    {
                        (currentNode.data, currentNodeNext.data) = (currentNodeNext.data, currentNode.data);
                        sort = true;
                    }
                    currentNode = currentNode.next;
                    currentNodeNext = currentNodeNext.next;
                }
            }
        }
        
        public int size()
        { 
            return count; 
        }
        public Node GetFirst()
        {
            return head;
        }
        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            _strategy = sortStrategy;
        }
        public void Sort()
        {
            _strategy.Sort(this);
        }
    }
}
