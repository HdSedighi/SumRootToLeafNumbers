﻿internal class Program
{
    private static void Main(string[] args)
    {
         //call solution class
        Solution solution = new Solution();
        //[1,5,1,null,null,null,6]
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(5);
        root.right = new TreeNode(1);
        root.right.right = new TreeNode(6);
        
        Console.WriteLine(solution.SumNumbers(root));
    }
}