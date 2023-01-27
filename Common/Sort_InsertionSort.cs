using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Sort_InsertionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            Node currentNode = list.GetFirst().next;
            while (currentNode != null)
            {
                for (var cur = list.GetFirst(); cur != null; cur = cur.next)
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

        public override void SortDesc(IMyList list)
        {
            throw new NotImplementedException();
        }
    }
    public class ReversInsertionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            Node currentNode = list.GetFirst().next;
            while (currentNode != null)
            {
                for (var cur = list.GetFirst(); cur != null; cur = cur.next)
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

        public override void SortDesc(IMyList list)
        {
            throw new NotImplementedException();
        }
    }
}
