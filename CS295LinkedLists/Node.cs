using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS295LinkedLists
{
    /// <summary>
    /// The Node contains the data and a pointer to the next node
    /// </summary>
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
        /// <summary>
        /// This should only be used with Doubly Linked Lists
        /// </summary>
        public Node? Previous { get; set; }

        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}
