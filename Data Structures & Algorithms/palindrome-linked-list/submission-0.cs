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
    public bool IsPalindrome(ListNode head) 
    {
        Stack<int> st = new();
        ListNode curr = head;

        while(curr != null)
        {
            st.Push(curr.val);
            curr = curr.next;
        }

        while(head != null)
        {
            if(head.val != st.Pop())
                return false;
            
            head = head.next;
        }

        return true;
    }
}