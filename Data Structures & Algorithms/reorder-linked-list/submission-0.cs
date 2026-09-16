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
    public void ReorderList(ListNode head)
    {
        var t = new List<ListNode>();
        var ptr = head;
        
        while(ptr is not null)
        {
            t.Add(ptr);
            ptr = ptr.next;
        }

        var l = 0;
        var r = t.Count-1;
        
        while(l < r)
        {
            var leftNode = t[l];
            var rightNode = t[r];
            var tmp = leftNode.next;
            leftNode.next = rightNode;
            rightNode.next = tmp;

            l++;r--;
        }

        t[l].next = null;
    }
}
