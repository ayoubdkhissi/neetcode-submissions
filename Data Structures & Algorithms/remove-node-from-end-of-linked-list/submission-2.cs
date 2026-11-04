public class Solution
{
	public ListNode RemoveNthFromEnd(ListNode head, int n)
	{
		if (head.next is null)
			return null;
		// get to the n'th node
		var ptr = head;

		while (n > 1)
		{
			ptr = ptr.next;
			n--;
		}

		if (ptr.next is null)
			return head.next;

		var ptr2 = new ListNode(-1, new ListNode(-1, head));
		while(ptr is not null)
		{
			ptr = ptr.next;
			ptr2 = ptr2.next;
		}

		ptr2.next = ptr2.next.next;

		return head;
	}
}