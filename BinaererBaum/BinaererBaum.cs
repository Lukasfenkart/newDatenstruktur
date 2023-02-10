using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaererBaum
{
    public class BinaererBaum
    {
        private Node firstRoot;
        public void Add(int Data)
        {
            if (firstRoot == null)
            {
                firstRoot = new Node(Data);
                return;
            }
            else
            {
                AddLeavesToTree(Data);
            }
        }
        public void AddLeavesToTree(int Data)
        {
            Node firstNode = firstRoot;
            while (true)
            {
                if (Data == firstNode.Data)
                    throw new Exception("Number already in Tree");
                if (Data > firstNode.Data)
                {
                    if (firstNode.right == null)
                    {
                        firstNode.right = new Node(Data);
                        return;
                    }
                    firstNode = firstNode.right;
                }
                else if (Data < firstNode.Data)
                {
                    if (firstNode.left == null)
                    {
                        firstNode.left = new Node(Data);
                        return;
                    }
                    firstNode = firstNode.left;
                }

            }
        }
        public override string ToString()
        {
            return getElementsAsString(firstRoot);
        }
        string getElementsAsString(Node element)
        {
            if (element == null)
                return "";
            if (element.left == null && element.right == null)
                return element.Data.ToString();
            return getElementsAsString(element.left)
            + element.Data.ToString()
            + getElementsAsString(element.right);
        }
    }
}
