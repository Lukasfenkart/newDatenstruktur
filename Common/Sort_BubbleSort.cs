﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Sort_BubbleSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            bool sort = true;
            while (sort)
            {
                sort = false;
                Node currentNode = list.GetFirst();
                Node currentNodeNext = list.GetFirst().next;
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
        public override void SortDesc(IMyList list)
        {
            throw new NotImplementedException();
        }
    }
    public class BubbleSortDesc : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            throw new NotImplementedException();
        }

        public override void SortDesc(IMyList list)
        {
            bool sort = true;
            while (sort)
            {
                sort = false;
                Node currentNode = list.GetFirst();
                Node currentNodeNext = list.GetFirst().next;
                while (currentNodeNext != null)
                {
                    if (currentNode.data < currentNodeNext.data)
                    {
                        (currentNode.data, currentNodeNext.data) = (currentNodeNext.data, currentNode.data);
                        sort = true;
                    }
                    currentNode = currentNode.next;
                    currentNodeNext = currentNodeNext.next;
                }
            }
        }
    }
}
