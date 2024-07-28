// Linked List
using CS295LinkedLists;

// Construct a new node and assign a value to Data
Node nodeA = new Node();
nodeA.Data = 1234213;

Node nodeB = new Node();
nodeB.Data = 99999;

Node nodeC = new Node();
nodeC.Data = 4312;

Node nodeD = new Node();
nodeD.Data = 1111;

// Link the nodes logically, from A thru D
// A references B, B references C, C references D
nodeA.Next = nodeB;
nodeB.Next = nodeC;
nodeC.Next = nodeD;