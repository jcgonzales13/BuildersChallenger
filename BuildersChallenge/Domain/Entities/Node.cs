﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildersChallenge.Domain.Entities
{
    public class Node
    {
        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        
    }
}
