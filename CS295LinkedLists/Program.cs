// Linked List
using CS295LinkedLists;
using System.Diagnostics;

DoublyLinkedList linkedList = new DoublyLinkedList();
linkedList.InsertFirst(1);
linkedList.InsertFirst(2);
linkedList.InsertFirst(3);
linkedList.InsertFirst(4);

linkedList.DeleteFirst();
linkedList.DeleteFirst();

linkedList.InsertLast(546);
linkedList.InsertLast(4123412);

linkedList.DisplayList();

MyStack stack = new MyStack();
stack.Push(1);
stack.Push(2);
Console.WriteLine("Should return 2: " + stack.Peek());
stack.Pop();
Console.WriteLine("Should return 1: " + stack.Peek());
 

