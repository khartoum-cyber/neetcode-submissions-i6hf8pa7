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
        List<ListNode> arr = new();
        ListNode curr = head;

        while(curr != null)
        {
            arr.Add(curr);
            curr = curr.next;
        }

        return arr[arr.Count / 2];
    }
}