using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
//    static void Main(string[] args)
//    {

//        //Print a matrix in spiral order


//        int[,] arr = new int[5, 5]
//        {
//                {1, 2, 3, 4, 5},
//                {6, 7, 8, 9, 10},
//                {11,12,13,14,15},
//                {16,17,18,19,20},
//                {21,22,23,24,25},
//        };

//        int rowTop = 0;
//        int colLeft = 0;

//        int rowBottom = arr.GetLength(0) - 1;
//        int colRight = arr.GetLength(1) - 1;

//        int itemCounter = 0;
//        int maxItems = arr.GetLength(0) * arr.GetLength(1);

//        List<int> arrayList = new List<int>();

//        while (itemCounter <= maxItems)
//        {

//            for (int j = colLeft; j < colRight; j++)
//            {
//                arrayList.Add(arr[rowTop, j]);
//                itemCounter++;
//            }


//            for (int i = rowTop; i < rowBottom; i++)
//            {
//                arrayList.Add(arr[i, colRight]);
//                itemCounter++;
//            }



//            for (int k = colRight; k > colLeft; k--)
//            {
//                arrayList.Add(arr[rowBottom, k]);
//                itemCounter++;
//            }


//            for (int i = rowBottom; i > rowTop; i--)
//            {
//                arrayList.Add(arr[i, colLeft]);
//                itemCounter++;
//            }

//            colLeft++;
//            rowTop++;
//            colRight--;
//            rowBottom--;

//        }



//        foreach (var a in arrayList)
//        {
//            Console.Write(a);
//        }
//        //            Console.Write();

//        Console.ReadLine();


//    }
//}

//public class BinaryTreeNode
//{
//    private BinaryTreeNode left, right;
//    private int data;

//    public BinaryTreeNode(int value)
//    {
//        data = value;
//    }

//    public void Insert(int value)
//    {
//        if (value <= data)
//        {
//            if (left == null)
//            {
//                left = new BinaryTreeNode(value);
//            }
//            else left.Insert(value);
//        }
//        else
//        {
//            if (right == null)
//            {
//                right = new BinaryTreeNode(value);
//            }
//            else
//            {
//                right.Insert(value);
//            }
//        }
//    }

//    public bool Contains(int value)
//    {
//        if (value == data)
//            return true;
//        if (value < data)
//        {
//            if (left == null) return false;
//            else
//                return left.Contains(value);
//        }
//        else if (right == null) return false;
//        else return right.Contains(value);
//    }


//    public void PrintInOrder()
//    {
//        if (left != null) left.PrintInOrder();
//        Console.Write(data);
//        if (right != null) right.PrintInOrder();
//    }

//    public int MaxDepth(BinaryTreeNode node)
//    {
//        if (node == null) return 0;

//        var a = 1 + Math.Max(MaxDepth(node.left), MaxDepth(node.right));

//        //  Console.WriteLine("Max depth for node data:" + node.data + ", Depth=" + a);
//        return a;
//    }

//    public int MinDepth(BinaryTreeNode node)
//    {
//        if (node == null) return 0;

//        var a = 1 + Math.Max(MaxDepth(node.left), MaxDepth(node.right));
//        // Console.WriteLine("Min depth for node data:" + node.data + ", Depth="+a);
//        return a;
//    }

//    public bool IsBalance(BinaryTreeNode root)
//    {
//        Console.WriteLine($"node={root.data}, ");
//        return (MaxDepth(root) - MinDepth(root) < 1);
//    }

//    public bool IsBinaryTreeOnLeft(BinaryTreeNode node)
//    {
//        if (node.left == null)
//            return true;

//        if (node.left != null && node.left.data < node.data)
//            return IsBinaryTreeOnLeft(node.left);
//        else
//        {
//            Console.WriteLine($"Found {node.left.data}>{node.data} which is wrong.");
//            return false;
//        }

//    }
//}
}
