/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution 
{
    public TreeNode InvertTree(TreeNode root) 
    {
        if(root == null)
            return null;
            
        Stack<TreeNode> stack = new();

        stack.Push(root);

        while(stack.Count > 0)
        {
            TreeNode curr = stack.Pop();

            (curr.left, curr.right) = (curr.right, curr.left);

            if(curr.left != null)
                stack.Push(curr.left);
            
            if(curr.right != null)
                stack.Push(curr.right);
        }

        return root;
    }
}
