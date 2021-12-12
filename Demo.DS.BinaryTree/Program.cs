
using Demo.DS.BinaryTree.Lib;

/*var rootNode = new Node(1);

rootNode.Left = new Node(2);
rootNode.Left.Left = new Node(4);
rootNode.Left.Right = new Node(5);

rootNode.Right = new Node(3);
rootNode.Right.Left = new Node(6);
rootNode.Right.Right = new Node(7); */

var tree = new BinaryTree();
tree.AddNode(3);
tree.AddNode(4);
tree.AddNode(2);
tree.AddNode(1);
tree.AddNode(5);
tree.AddNode(6);

var result = tree.IsBalanced(new Node(1));
Console.WriteLine(result);

tree.Print();


