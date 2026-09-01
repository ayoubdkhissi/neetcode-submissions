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
        var hashSet = new HashSet<ListNode>();

        while(head != null)
        {
            if (hashSet.Contains(head))
                return true;

            hashSet.Add(head);
            head = head.next;
        }

        return false;
    }
}
