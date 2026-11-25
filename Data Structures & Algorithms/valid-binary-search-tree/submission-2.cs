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

public class Solution {
    public bool IsValidBST(TreeNode root) 
    {
        List<int> inOrder = new();

        DFS(root);
        
        for(int i = 0; i < inOrder.Count - 1; i++)
        {
            if (inOrder[i] >= inOrder[i + 1])
                return false;
        }

        return true;
        
        void DFS(TreeNode node)
        {
            if(node == null)
                return;

            DFS(node.left);
            inOrder.Add(node.val);
            DFS(node.right);
        }
    }
}
