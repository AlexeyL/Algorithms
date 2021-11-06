using Algorithms._DataSrtucture.Graph;
using Algorithms.Graph;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmtXUnitTest.Graph
{
    public class DijikstraAlgorithmsTest
    {
        private DijikstraSearch dijikstraSearch;

        public DijikstraAlgorithmsTest()
        {
            dijikstraSearch = new DijikstraSearch();
        }

        [Fact]
        public void DijikstraSearch_Returns_ShortestPath_1()
        {
            // Arrange
            var graph = SetTest1Graph();

            // Act
            var result = dijikstraSearch.Search(graph);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void DijikstraSearch_Returns_ShortestPath_2()
        {
            // Arrange
            var graph = SetTest2Graph();

            // Act
            var result = dijikstraSearch.Search(graph);

            // Assert
            Assert.Equal(5, result);
        }

        private Graph<string> SetTest1Graph()
        {
            // build nodes
            var graph = new Graph<string>();
            var startNode = new GraphNode<string>("Start");
            var aNode = new GraphNode<string>("A");
            var bNode = new GraphNode<string>("B");
            var finishNode = new GraphNode<string>("Finish");

            // add nodes to the graph
            graph.AddNode(startNode);
            graph.AddNode(aNode);
            graph.AddNode(bNode);
            graph.AddNode(finishNode);

            // add connecting egde with weight
            graph.AddDirectedEdge(startNode, aNode, 6);
            graph.AddDirectedEdge(startNode, bNode, 2);

            graph.AddDirectedEdge(aNode, finishNode, 1);

            graph.AddDirectedEdge(bNode, aNode, 3);
            graph.AddDirectedEdge(bNode, finishNode, 5);

            return graph;
        }

        private Graph<string> SetTest2Graph()
        {
            // build nodes
            var graph = new Graph<string>();
            var startNode = new GraphNode<string>("Start");
            var aNode = new GraphNode<string>("A");
            var bNode = new GraphNode<string>("B");
            var finishNode = new GraphNode<string>("Finish");

            // add nodes to the graph
            graph.AddNode(startNode);
            graph.AddNode(aNode);
            graph.AddNode(bNode);
            graph.AddNode(finishNode);

            // add connecting egde with weight
            graph.AddDirectedEdge(startNode, aNode, 2);
            graph.AddDirectedEdge(startNode, bNode, 3);

            graph.AddDirectedEdge(aNode, finishNode, 10);

            graph.AddDirectedEdge(bNode, aNode, 1);
            graph.AddDirectedEdge(bNode, finishNode, 2);

            return graph;
        }
    }
}
