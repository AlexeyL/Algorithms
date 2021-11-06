using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms._DataSrtucture.Graph
{
    public class Graph<T>: IEnumerable<T>
    {
        private GraphNodeList<T> nodeSet;

        public Graph(): this(null) { }
        public Graph(GraphNodeList<T> nodeSet)
        {
            if (nodeSet == null)
                this.nodeSet = new GraphNodeList<T>();
            else
                this.nodeSet = nodeSet;
        }

        public void AddNode(GraphNode<T> node)
        {
            nodeSet.Add(node);
        }

        public void AddNode(T value)
        {
            nodeSet.Add(new GraphNode<T>(value));
        }

        public void AddDirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost)
        {
            from.Neighbors.Add(to);
            from.Costs.Add(cost);
        }

        public void AddUndirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost)
        {
            from.Neighbors.Add(to);
            from.Costs.Add(cost);

            to.Neighbors.Add(from);
            to.Costs.Add(cost);
        }

        public bool Contains(T value)
        {
            return nodeSet.FindByValue(value) != null;
        }

        public bool Remove(T value)
        {
            // first remove the node from the nodeset
            GraphNode<T> nodeToRemove = (GraphNode<T>)nodeSet.FindByValue(value);
            if (nodeToRemove == null)
                // node wasn't found
                return false;

            // otherwise, the node was found
            nodeSet.Remove(nodeToRemove);

            // enumerate through each node in the nodeSet, removing edges to this node
            foreach (GraphNode<T> gnode in nodeSet)
            {
                int index = gnode.Neighbors.IndexOf(nodeToRemove);
                if (index != -1)
                {
                    // remove the reference to the node and associated cost
                    gnode.Neighbors.RemoveAt(index);
                    gnode.Costs.RemoveAt(index);
                }
            }

            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(GraphNode<T> graphNode in Nodes)
            {
                if (graphNode == null)
                {
                    break;
                }
                yield return graphNode.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (GraphNode<T> graphNode in Nodes)
            {
                if (graphNode == null)
                {
                    break;
                }
                yield return graphNode.Value;
            }
        }

        public GraphNodeList<T> Nodes
        {
            get
            {
                return nodeSet;
            }
        }

        public int Count
        {
            get { return nodeSet.Count; }
        }
    }
}
