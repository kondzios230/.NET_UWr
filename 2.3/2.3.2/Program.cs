﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var child1 = new BinaryTreeNode<int> { Data = 1 };
            var child21 = new BinaryTreeNode<int> { Data = 10 };
            var child2 = new BinaryTreeNode<int> { Data = 2 , RightNode=child21};
            var child4 = new BinaryTreeNode<int> { Data = 5 };
            var child3 = new BinaryTreeNode<int> { Data = 3, LeftNode = child1 , RightNode = child4};          
            var root = new BinaryTreeNode<int> { Data = 4, LeftNode = child3, RightNode = child2 };

            foreach (var value in root)
                Console.WriteLine(value);

            Console.ReadKey();
        }
    }
}
