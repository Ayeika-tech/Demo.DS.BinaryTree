using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DS.BinaryTree.Lib.BinaryTree
{
    public class BinaryTree
    {
        private Node? _root;

        public BinaryTree()
        {
            _root = null;
        }

        public BinaryTree(Node rootNode)
        {
            _root = rootNode;
        }

        public void AddNode(int data)
        {
            // 1. If the tree is empty, return a new, single node 
            if (_root == null)
            {
                _root = new Node(data);
                return;
            }

            // 2. Otherwise, recursive down the tree 
            AddNodeInternal(_root, new Node(data));
        }

        private void AddNodeInternal(Node root, Node newNode)
        {
            if (root == null)
            {
                root = newNode;
            }

            if (newNode.Data < root.Data)
            {
                if (root.Left == null)
                {
                    root.Left = newNode;
                }
                else
                {
                    AddNodeInternal(root.Left, newNode);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = newNode;
                }
                else
                {
                    AddNodeInternal(root.Right, newNode);
                }
            }
        }

        public bool IsBalanced(Node node)
        {
            int lh; // for height of left subtree
            int rh; // for height of right subtree

            /* If tree is empty then return true */
            if (node == null)
            {
                return true;
            }

            /* Get the height of left and right sub trees */
            lh = Height(node.Left);
            rh = Height(node.Right);

            if (Math.Abs(lh - rh) <= 1
                && IsBalanced(node.Left) && IsBalanced(node.Right))
            {
                return true;
            }

            /* If we reach here then tree is not height-balanced */
            return false;
        }

        public virtual int Height(Node node)
        {
            /* base case tree is empty */
            if (node == null)
            {
                return 0;
            }

            /* If tree is not empty then height = 1 + max of left
            height and right heights */
            return 1 + Math.Max(Height(node.Left), Height(node.Right));
        }

        public bool Find(int target)
        {
            if (Find(_root, target).Data == target)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Node Find(Node current, int target)
        {
            if (target == current.Data)
            {
                return current;
            }

            if (target < current.Data)
            {
                return Find(current.Left, target);
            }
            else
            {
                return Find(current.Right, target);
            }
        }

        public void Print()
        {
            _root?.Print();
        }
    }
}
