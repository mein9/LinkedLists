﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS295LinkedLists
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void InsertFirst(int data)
        {
            // Create the node
            Node newNode = new Node();
            // Put data in the node
            newNode.Data = data;
            // Put the old node into Next
            newNode.Next = First;
            // Make the first the new node
            First = newNode;
        }

        public Node DeleteFirst()
        {
            // Assign the temporary variable
            Node temp = First;
            // Assign the new head
            First = First.Next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating through list...");
            Node current = First;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
        }
    }
}