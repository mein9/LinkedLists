// Linked List
using CS295LinkedLists;
using System.Diagnostics;

LinkedList linkedList = new LinkedList();
linkedList.InsertFirst(1);
linkedList.InsertFirst(2);
linkedList.InsertFirst(3);
linkedList.InsertFirst(4);

linkedList.DeleteFirst();
linkedList.DeleteFirst();

linkedList.InsertLast(546);
linkedList.InsertLast(4123412);

linkedList.DisplayList();
 