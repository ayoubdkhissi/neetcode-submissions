public class Solution
{
	public ListNode RemoveNthFromEnd(ListNode head, int n)
	{
		if (head.next is null)
			return null;
		// get to the end of the list
		var ptr = head;

		var length = 1;
		while (ptr.next != null)
		{
			ptr = ptr.next;
			length++;
		}

		if(n == length)
		{
			head = head.next;
			return head;
		}
		var i = length-n+1;
		var prev = head;
		ptr = head;
		while(i > 1)
		{
			prev = ptr;
			ptr = ptr.next;
			i--;
		}

		prev.next = ptr.next;

		return head;
	}
}