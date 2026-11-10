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
    public ListNode ReverseKGroup(ListNode head, int k) 
    {
        ListNode curr = head;
        int group = 0;

        while(curr != null && group < k)
        {
            curr = curr.next;
            group++;
        }

        if(group == k)
        {
            curr = ReverseKGroup(curr, k);

            while(group-- > 0)
            {
                ListNode tmp = head.next;
                head.next = curr;
                curr = head;
                head = tmp;
            }

            head = curr;
        }

        return head;
    }
}
