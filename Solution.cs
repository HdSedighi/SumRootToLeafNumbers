public class Solution {
    public int SumNumbers(TreeNode root, int sum=0) {
        if (root == null) return 0;
        if (root.left == null && root.right == null) return sum * 10 + root.val;
        return SumNumbers(root.right, sum * 10 + root.val) + SumNumbers(root.left, sum * 10 + root.val);
    }
}
