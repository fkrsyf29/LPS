using System;
using System.Collections.Generic;

namespace MemoryLeakExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootNode = new TreeNode();
            while (true)
            {
                // create a new subtree of 10000 nodes 
                var newNode = new TreeNode();
                for (int i = 0; i < 10000; i++)
                {
                    var childNode = new TreeNode();
                    newNode.AddChild(childNode);
                }
                rootNode.AddChild(newNode);

                // Limit the number of subtrees to prevent excessive memory consumption
                if (rootNode.ChildrenCount > 1000)
                {
                    rootNode.RemoveFirstChild(); // Remove the oldest subtree
                }
            }
        }
    }

    class TreeNode
    {
        private readonly List<TreeNode> _children = new List<TreeNode>();

        public int ChildrenCount => _children.Count;

        public void AddChild(TreeNode child)
        {
            _children.Add(child);
        }

        public void RemoveFirstChild()
        {
            if (_children.Count > 0)
            {
                _children.RemoveAt(0);
            }
        }
    }
}
