using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS295LinkedLists
{
    public class MyStack
    {
        private LinkedList _stack = new LinkedList();
        public LinkedList Stack { get { return _stack; } }


        public void Push(int value)
        {
            _stack.InsertFirst(value);
        }
        public int Pop()
        {
            return _stack.DeleteFirst().Data;
        }
        public int Peek()
        {
            return _stack.First.Data;
        }

   
    }
}
