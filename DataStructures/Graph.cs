using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    // TODO: Comment class
    // TODO: Review non-nullable case
    public class Graph<T>
    {
        public GraphNode<T>[] nodes;
    }

    public class GraphNode<T>
    {
        T Value;
        public GraphNode<T>[] Children;
    }
}
