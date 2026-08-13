/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) 
    {
        while(headA != null)
        {
            ListNode curr = headB;

            while(curr != null)
            {
                if(curr == headA)
                    return headA;
                
                curr = curr.next;
            }

            headA = headA.next;
        }

        return null;
    }
}