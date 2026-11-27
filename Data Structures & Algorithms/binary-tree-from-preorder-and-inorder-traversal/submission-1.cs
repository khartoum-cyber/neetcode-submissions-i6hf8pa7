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
    public TreeNode BuildTree(int[] preorder, int[] inorder) 
    {
        Dictionary<int,int> map = new();

        for(int i = 0; i < inorder.Length; i++)
        {
            map[inorder[i]] = i;
        }

        int index = 0;

        return DFS(preorder, 0, inorder.Length - 1);

        TreeNode DFS(int[] preorder, int l, int r)
        {
            if(l > r)
                return null;
            
            int root_val = preorder[index++];

            TreeNode root = new(root_val);

            int mid = map[root_val];

            root.left = DFS(preorder, l, mid - 1);
            root.right = DFS(preorder, mid + 1, r);

            return root;
        }
    }
}
