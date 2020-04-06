using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            Random random = new Random();
            tree.Add(25);
            for (int i = 0; i < 50; i++)
            {
                tree.Add(random.Next(1, 51));
            }
        }
    }
}
