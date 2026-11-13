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
    public int DiameterOfBinaryTree(TreeNode root) 
    {
        if(root == null)
            return 0;

        int maxDiameter = 0;
        
        DFS(root);

        return maxDiameter;

        int DFS(TreeNode node)
        {
            if(node == null)
                return 0;

            int left = DFS(node.left);
            int right = DFS(node.right);

            maxDiameter = Math.Max(maxDiameter, left + right);

            return 1 + Math.Max(left, right);
        }
    }
}
