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
    public List<int> InorderTraversal(TreeNode root) 
    {
        List<int> res = new List<int>();

        Inorder(root, res);

        return res;
    }

    private void Inorder(TreeNode node, List<int> list)
    {
        if(node == null)
            return;
        
        Inorder(node.left, list);
        list.Add(node.val);
        Inorder(node.right, list);
    }
}