/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public bool IsPalindrome(ListNode head) 
    {
        ListNode left = head;

        return DFS(head);

        bool DFS(ListNode right)
        {
            if(right == null)
                return true;
            
            bool result = DFS(right.next);

            if(!result)
                return false;
            
            bool same = left.val == right.val;

            left = left.next;

            return same;
        }
    }
}