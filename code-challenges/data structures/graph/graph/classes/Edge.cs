﻿using System;
using System.Collections.Generic;
using System.Text;

namespace graph.classes
{
    public class Edge<T>
    {
        public int Weight { get; set; }
        public Vertex<T> Vertex { get; set; }
    }
}
