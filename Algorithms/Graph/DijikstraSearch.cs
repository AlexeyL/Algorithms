using Algorithms._DataSrtucture.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Graph
{
    public class DijikstraSearch
    {
        private List<string> processedNodes = new List<string>();
        private Dictionary<string, int> costs = new Dictionary<string, int>();

        public int Search(Graph<string> graph)
        {
            var start = graph.Nodes.FindByValue("Start");

            // add costs to the cost to the neighbours to the cost hash table
            for (int i = 0; i < start.Neighbors.Count; i++)
            {
                costs.Add(start.Neighbors[i].Value, start.Costs[i]);
            }

            var node = FindLowestCostNode(graph);

            while (node != null)
            {
                // get neighbors of current node
                var neighbors = node.Neighbors;
                
                // get cost to this node
                int cost = costs[node.Value];

                if (neighbors != null && neighbors.Count > 0)
                {
                    // if the way to the one of the neighbor is 
                    // shorter then update costs hash table with new value
                    for (int i = 0; i < neighbors.Count; i++)
                    {
                        var neighborNode = neighbors[i];
                        var nodeCost = node.Costs[i];
                        var newCost = cost + nodeCost;

                        if (!costs.ContainsKey(neighborNode.Value))
                        {
                            costs.Add(neighborNode.Value, int.MaxValue);
                        }

                        if (costs[neighborNode.Value] > newCost)
                        {
                            costs[neighborNode.Value] = newCost;
                        }
                    }
                    
                    // add this node to the processed nodes list
                    processedNodes.Add(node.Value);

                    // find next lowest cost neighbor
                    node = FindLowestCostNode(graph);
                }
                else
                {
                    return cost;
                }
            }

            return -1;
        }

        private GraphNode<string> FindLowestCostNode(Graph<string> graph)
        {
            if (costs.Count > 0)
            {
                var unProcessedCosts = costs.Where(c => !processedNodes.Contains(c.Key)).ToList();
                if (unProcessedCosts.Count > 0)
                {
                    var lowestUnProcesseCost = unProcessedCosts.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
                    
                    return graph.Nodes.First(n => n.Value == lowestUnProcesseCost);
                }
            }

            return null;
        }
    }
}
