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
    public bool HasCycle(ListNode head)
    {
        var slowPtr = head;
        var fastPtr = head?.next;
        while(slowPtr != null && fastPtr != null)
        {
            if (slowPtr == fastPtr)
                return true;
            slowPtr = slowPtr?.next;
            fastPtr = fastPtr?.next?.next;
        }

        return false;
    }
}
