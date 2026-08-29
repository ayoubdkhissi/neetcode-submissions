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
    public ListNode ReverseList(ListNode head)
    {
        var tmp = head;
        while(tmp?.next != null)
        {
            var current = tmp.next;
            tmp.next = current.next;
            current.next = head;
            head = current;
        }

        return head;
    }
}
