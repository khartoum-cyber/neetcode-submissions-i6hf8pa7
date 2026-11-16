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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) 
    {
        if(root == null)
            return false;
        
        if(IsSameTree(root, subRoot))
            return true;
        
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);

        bool IsSameTree(TreeNode node, TreeNode subRoot)
        {
            if(node == null && subRoot == null)
                return true;
            
            if(node == null || subRoot == null)
                return false;
            
            if(node.val != subRoot.val)
                return false;
            
            return IsSameTree(node.left, subRoot.left) && IsSameTree(node.right, subRoot.right);
        }
    }
}
