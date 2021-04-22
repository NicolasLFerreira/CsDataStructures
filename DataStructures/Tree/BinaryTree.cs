using System;

namespace CSDataStructures.DataStructures.Tree
{
    class BinaryTree
    {
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }

        public int Data { get; set; }
        
        public BinaryTree(int data) => Data = data;

        public void Insert(int data)
        {
            if (data <= Data)
            {
                if (Left == null) Left = new BinaryTree(data);
                else Left.Insert(data);
            }

            if (data > Data)
            {
                if (Right == null) Right = new BinaryTree(data);
                else Right.Insert(data);
            }
        }

        public bool Contains(int data)
        {
            if (data == Data) return true;

            if (Left != null)
            {
                if (data == Left.Data) return true;
                if (data <= Left.Data) Left.Contains(data);
            }

            if (Right != null)
            {
                if (data == Right.Data) return true;
                if (data > Right.Data) Right.Contains(data);
            }
            return false;
        }

        public void PrintInOrder()
        {
            if (Left != null) Left.PrintInOrder();
            for (int i = 0; i < Data; i++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
            if (Right != null) Right.PrintInOrder();
        }
    }
}