using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Sort_SelectionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var current = list.GetFirst();

            while (current.next != null)
            {
                var extreme = current;
                for (var cur = current.next; cur != null; cur = cur.next)
                {
                    if ((int)cur.data < (int)extreme.data)
                        continue;
                    extreme = cur;
                }
                (extreme.data, current.data) = (current.data, extreme.data);
                current = current.next;
            }
        }
        public override void SortDesc(IMyList list)
        {
            throw new NotImplementedException();
        }
    }
}
