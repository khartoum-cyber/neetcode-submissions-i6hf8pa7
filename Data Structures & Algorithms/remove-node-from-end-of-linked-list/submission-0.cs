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
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        List<ListNode> nodes = new();
        ListNode curr = head;

        while(curr != null)
        {
            nodes.Add(curr);
            curr = curr.next;
        }

        int index = nodes.Count - n;
        
        if(index == 0)
            return head.next;
        else
            nodes[index - 1].next = nodes[index].next;

        return head; 
    }
}
