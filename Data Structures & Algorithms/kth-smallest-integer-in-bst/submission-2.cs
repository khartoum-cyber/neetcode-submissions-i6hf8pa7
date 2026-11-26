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
    public int KthSmallest(TreeNode root, int k) 
    {
        List<int> res = new() { 0 };

        InOrder(root);

        return res[k];

        void InOrder(TreeNode node)
        {
            if(node == null)
                return;
            
            InOrder(node.left);
            res.Add(node.val);
            InOrder(node.right);
        }
    }
}
