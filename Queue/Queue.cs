using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Queue
{
    public class Queue : ISubject
    {
        LinkedList.LinkedList internalList = new LinkedList.LinkedList();
        private List<IObserver> _observers = new List<IObserver>();
        public Node Enqueue(int newNode)
        {
            var nodeToAdd = new Node(newNode, null);
            internalList.insertlast(newNode);
            this.Notify();
            return nodeToAdd;
        }
        public Node Dequeue()
        {
            var retval = internalList.GetFirst();
            internalList.deletefirst();
            this.Notify();
            return retval;
        }
        public override string ToString()
        {
            return internalList.ToString();
        }
        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
