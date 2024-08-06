using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS295LinkedLists
{
    public class MyQueue
    {
        private LinkedList queue = new LinkedList();

        public void Enqueue(int data)
        {
            queue.InsertLast(data);
        }
        public void Dequeue()
        {
            queue.DeleteFirst();
        }
        public int Peek()
        {
            return queue.First.Data;
        }

    }
}
