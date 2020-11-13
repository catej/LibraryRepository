using System;
using System.Collections.Generic;
using datastructures.structures;

namespace DataStructuresApp
{
    public class MyBinarySearchTree
    {
        public TreeNode root = new TreeNode();
        public MyBinarySearchTree()
        {
            root = null;
        }
        public string[] methods = new string[] { "Display Tree", "PreOrder(T)", "InOrder(T)", "PostOrder(T)", "LevelOrder", "Find Height", "Search Tree", "Find Min", "Find Max", "Insert node", "Delete node", "Run Tests" };
        public void Exe()
        {
            string prompt = "What would you like to do? ";
            string menu = UI.DisplayMenu(methods, prompt);
            int methodChoice;
            do
            {
                methodChoice = UI.ValidateInteger(0, methods.Length, menu);
                UseSelectedMethod(methodChoice);                
            }while(!methodChoice.Equals(methods.Length));
        }
        public void UseSelectedMethod(int methodChoice)
        {
            int numberToUse;
            switch (methodChoice)
            {
                case 0:
                    DisplayTree();
                    break;
                case 1:
                    PreOrderTraversal(root);
                    Console.WriteLine();
                    break;
                case 2:
                    InOrderTraversal(root);
                    Console.WriteLine();
                    break;
                case 3:
                    PostOrderTraversal(root);
                    Console.WriteLine();
                    break;
                case 4:
                    LevelOrder();
                    break;
                case 5:
                    Console.WriteLine("Height: " + FindHeight(root));
                    break;
                case 6:
                    numberToUse = UI.ValidateInteger();
                    Console.WriteLine("Number Found: " + SearchTree(numberToUse));
                    break;
                case 7:
                    FindMin();
                    break;
                case 8:
                    FindMax();
                    break;
                case 9:
                    numberToUse = UI.ValidateInteger();
                    InsertNode(numberToUse);
                    break;
                case 10:
                    numberToUse = UI.ValidateInteger();
                    DeleteNode(numberToUse);
                    break;
                case 11:
                    RunTests();
                    break;
                case 12:
                    Console.WriteLine("Exiting MiscMethods...");
                    break;
            }
        }
        private void RunTests()
        {
            InsertNode(16);
            InsertNode(5);
            InsertNode(1);
            InsertNode(6);
            InsertNode(18);
            InsertNode(24);

            DisplayTree();

            System.Console.WriteLine("\n PreOrder : \n");
            PreOrderTraversal(root);

            System.Console.WriteLine("\n InOrder : \n");
            InOrderTraversal(root);

            System.Console.WriteLine("\n PostOrder : \n");
            PostOrderTraversal(root);

            System.Console.WriteLine("\n LevelOrder : \n");
            LevelOrder();

            Console.WriteLine("Height of tree is " + FindHeight(root));

        }
        private bool IsEmpty()
        {
            return (root == null);
        }
        private void DisplayTree()
        {
            DisplayNode(root, 0);
            Console.WriteLine();
        }
        private void DisplayNode(TreeNode rootNode, int level)
        {
            int i;
            if (rootNode == null)
            {
                System.Console.WriteLine();
                return;
            }

            DisplayNode(rootNode.rightSub, level + 1);
            Console.WriteLine();
            
            for (i = 0; i < level; i++)
            {
                Console.Write("++++");
            }
            Console.Write(rootNode.data);

            DisplayNode(rootNode.leftSub, level + 1);
        }
        private void PreOrderTraversal(TreeNode rootNode)
        {
            if (rootNode == null)
            {
                return;
            }
            Console.Write($"{rootNode.data} ");
            PreOrderTraversal(rootNode.leftSub);
            PreOrderTraversal(rootNode.rightSub);
        }
        private void InOrderTraversal(TreeNode rootNode)
        {
            if (rootNode == null)
            {
                return;
            }
            InOrderTraversal(rootNode.leftSub);
            Console.Write($"{rootNode.data} ");
            InOrderTraversal(rootNode.rightSub);
        }
        private void PostOrderTraversal(TreeNode rootNode)
        {
            if (rootNode == null)
            {
                return;
            }
            PostOrderTraversal(rootNode.leftSub);
            PostOrderTraversal(rootNode.rightSub);
            Console.Write($"{rootNode.data} ");
        }
        private void LevelOrder()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            Queue<TreeNode> qu = new Queue<TreeNode>();
            qu.Enqueue(root);

            TreeNode tempNode;
            while (qu.Count != 0)
            {
                tempNode = qu.Dequeue();
                Console.Write($"{tempNode.data} ");
                if (tempNode.leftSub != null)
                {
                    qu.Enqueue(tempNode.leftSub);
                }
                if (tempNode.rightSub != null)
                {
                    qu.Enqueue(tempNode.rightSub);
                }
            }
            Console.WriteLine();
        }
        private int FindHeight(TreeNode rootNode)
        {
            if (rootNode == null)
            {
                return 0;
            }
            int leftHeight = FindHeight(rootNode.leftSub);
            int rightHeight = FindHeight(rootNode.rightSub);

            if (leftHeight > rightHeight)
            {
                return 1 + leftHeight;
            }
            else
            {
                return 1 + rightHeight;
            }
        }
        private bool SearchTree(int numberToSearchFor)
        {
            TreeNode tempNode = root;
            while (tempNode != null)
            {
                if (numberToSearchFor < tempNode.data)
                {
                    tempNode = tempNode.leftSub;
                }
                else if (numberToSearchFor > tempNode.data)
                {
                    tempNode = tempNode.rightSub;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        private int FindMin()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Tree is empty.");
            }
            TreeNode tempNode = root;
            while (tempNode.leftSub != null)
            {
                tempNode = tempNode.leftSub;
            }
            Console.WriteLine($"Min: {tempNode.data}");
            return tempNode.data;
        }
        private int FindMax()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Tree is empty.");
            }
            TreeNode tempNode = root;
            while (tempNode.rightSub != null)
            {
                tempNode = tempNode.rightSub;
            }
            
            Console.WriteLine($"Max: {tempNode.data}");
            return tempNode.data;
        }
        private void InsertNode(int numberToInsert)
        {
            TreeNode tempNode = root;
            TreeNode parentNode = null;

            while (tempNode != null)
            {
                parentNode = tempNode;
                if (numberToInsert < tempNode.data)
                {
                    tempNode = tempNode.leftSub;
                }
                else if (numberToInsert > tempNode.data)
                {
                    tempNode = tempNode.rightSub;
                }
                else
                {
                    Console.WriteLine(numberToInsert + " already present in the tree.");
                }
            }

            TreeNode newNode = new TreeNode(numberToInsert);
            
            if (parentNode == null)
            {
                root = newNode;
            }
            else if (numberToInsert < parentNode.data)
            {
                parentNode.leftSub = newNode;
            }
            else
            {
                parentNode.rightSub = newNode;
            }
        }
        private void DeleteNode(int numberToDelete)
        {
            TreeNode tempNode = root;
            TreeNode parentNode = null;

            while (tempNode != null)
            {
                if (numberToDelete == tempNode.data)
                {
                    break;
                }
                parentNode = tempNode;
                if (numberToDelete < tempNode.data)
                {
                    tempNode = tempNode.leftSub;
                }
                else
                {
                    tempNode = tempNode.rightSub;
                }
            }

            // if NODE is not present
            if (tempNode == null)
            {
                Console.WriteLine(numberToDelete + " not found.");
                return;
            }

            // if NODE has 2 CHILDREN
            TreeNode successorNode , parentofSuccessorNode;
            if (tempNode.leftSub != null && tempNode.rightSub != null) 
            {
                parentofSuccessorNode = tempNode;
                successorNode = tempNode.rightSub;

                while (successorNode.leftSub != null)
                {
                    parentofSuccessorNode = successorNode;
                    successorNode = successorNode.leftSub;
                }
                tempNode.data = successorNode.data;
                tempNode = successorNode;
                parentNode = parentofSuccessorNode;
            }

            // if NODE has 1 CHILD
            TreeNode child;
            if (tempNode.leftSub != null)
            {
                child = parentNode.leftSub;
            }
            else
            {
                child = tempNode.rightSub;
            }

            if (parentNode == null)
            {
                root = child;
            }
            else if (tempNode == parentNode.leftSub)
            {
                parentNode.leftSub = child;
            }
            else
            {
                parentNode.rightSub = child;
            }
        }
    }
}