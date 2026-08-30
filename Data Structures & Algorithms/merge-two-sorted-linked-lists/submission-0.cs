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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;

        var p1 = list1;
        var p2 = list2;
        var newHead = new ListNode();
        var ptr = newHead;
        while(p1 != null && p2 != null)
        {
            if(p1.val > p2.val)
            {
                ptr.val = p2.val;
                p2 = p2.next;
            }
            else
            {
                ptr.val = p1.val;
                p1 = p1.next;
            }

            if(p1 != null && p2 != null)
            {
                ptr.next = new ListNode();
                ptr = ptr.next;
            }
        }

        if (p1 != null)
            ptr.next = p1;
        if (p2 != null)
            ptr.next = p2;
        return newHead ;
    }
}