using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms._DataSrtucture.BinaryTree
{
    public class TreeNode
    {
        public int Data;
        public TreeNode Left, Right;

        public TreeNode(int item)
        {
            Data = item;
            Left = Right = null;
        }
    }
}
