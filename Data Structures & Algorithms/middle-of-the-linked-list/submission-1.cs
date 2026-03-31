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
public class Solution {
    public ListNode MiddleNode(ListNode head) 
    {
        List<ListNode> list = new();
        ListNode curr = head;

        while(curr != null)
        {
            list.Add(curr);
            curr = curr.next;
        }

        return list[list.Count / 2];
    }
}