using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms._DataSrtucture.Graph
{
    public class GraphNode<T>
    {
        private T data;
        private GraphNodeList<T> neighbors = null;
        private List<int> costs;

        public GraphNode() { }
        public GraphNode(T data) : this(data, null) { }
        public GraphNode(T data, GraphNodeList<T> neighbors)
        {
            this.data = data;
            this.neighbors = neighbors;
        }

        public T Value
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public GraphNodeList<T> Neighbors
        {
            get
            {
                if (neighbors == null)
                    neighbors = new GraphNodeList<T>();

                return neighbors;
            }
            set
            {
                neighbors = value;
            }
        }

        public List<int> Costs
        {
            get
            {
                if (costs == null)
                    costs = new List<int>();

                return costs;
            }
        }

    }
}
