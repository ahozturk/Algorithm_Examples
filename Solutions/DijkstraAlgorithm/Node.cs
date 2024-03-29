﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.DijkstraAlgorithm
{
    public class Node
    {
        public string Name { get; set; }
        public Dictionary<Node, int> Edges { get; set; }

        public Node(string name)
        {
            Name = name;
        }

        public Node AddEdge(Node node, int distance)
        {
            Edges ??= new Dictionary<Node, int>();

            Edges.Add(node, distance);
            return this;
        }
        
    }
}
