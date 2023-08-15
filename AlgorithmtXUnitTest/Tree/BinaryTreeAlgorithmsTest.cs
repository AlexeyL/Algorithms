using Algorithms.Tree;
using Algorithms._DataSrtucture.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmtXUnitTest.Tree
{
    public class BinaryTreeAlgorithmsTest
    {
        private BinaryTreeAlgorithms alg = new BinaryTreeAlgorithms();

        [Fact]
        public void BinaryTree_InOrderTraverse()
        {
            //Arrange
            TreeNode tree = new TreeNode(1);
            tree.Left = new TreeNode(2);
            tree.Right = new TreeNode(3);
            tree.Left.Left = new TreeNode(4);
            tree.Left.Right = new TreeNode(5);

            //Act
            var result = alg.InOrderTraverse(tree);

            //Assert
            Assert.Equal("4 2 5 1 3 ", result);
        }

        [Fact]
        public void BinaryTree_PreOrderTraverse()
        {
            //Arrange
            TreeNode tree = new TreeNode(1);
            tree.Left = new TreeNode(2);
            tree.Right = new TreeNode(3);
            tree.Left.Left = new TreeNode(4);
            tree.Left.Right = new TreeNode(5);

            //Act
            var result = alg.PreOrderTraverse(tree);

            //Assert
            Assert.Equal("1 2 4 5 3 ", result);
        }

        [Fact]
        public void BinaryTree_PostOrderTraverse()
        {
            //Arrange
            TreeNode tree = new TreeNode(1);
            tree.Left = new TreeNode(2);
            tree.Right = new TreeNode(3);
            tree.Left.Left = new TreeNode(4);
            tree.Left.Right = new TreeNode(5);

            //Act
            var result = alg.PostOrderTraverse(tree);

            //Assert
            Assert.Equal("4 5 2 3 1 ", result);
        }

        [Fact]
        public void BinaryTree_Traverse_NoRecurtion()
        {
            //Arrange
            TreeNode tree = new TreeNode(1);
            tree.Left = new TreeNode(2);
            tree.Right = new TreeNode(3);
            tree.Left.Left = new TreeNode(4);
            tree.Left.Right = new TreeNode(5);

            //Act
            var result = alg.TraverseNoRecurtion(tree);

            //Assert
            Assert.Equal("1 2 3 4 5 ", result);
        }

        [Fact]
        public void BinaryTree_GetTreeHight()
        {
            //Arrange
            TreeNode tree = new TreeNode(20);
            tree.Left = new TreeNode(8);
            tree.Right = new TreeNode(22);
            tree.Left.Left = new TreeNode(4);
            tree.Left.Right = new TreeNode(12);
            tree.Left.Right.Left = new TreeNode(10);

            //Act
            var result = alg.GetTreeHeight(tree);

            //Assert
            Assert.Equal(4, result);
        }
    }
}
