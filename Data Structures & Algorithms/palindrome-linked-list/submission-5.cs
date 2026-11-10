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
        Stack<int> stack = new();
        ListNode curr = head;

        while(curr != null)
        {
            stack.Push(curr.val);
            curr = curr.next;
        }

        while(stack.Count != 0)
        {
            if(stack.Pop() != head.val)
                return false;
            
            head = head.next;
        }

        return true;
    }
}