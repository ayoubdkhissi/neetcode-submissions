public class Solution
{
	public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
        var list = new ListNode();

        var ptr1 = l1;
        var ptr2 = l2;
        var ptr3 = list;
        var rest = 0;
        while(ptr1 is not null && ptr2 is not null)
        {
            var result = (ptr1.val + ptr2.val + rest).ToString();
            if(result.Length > 1)
            {
                rest = int.Parse(result[0].ToString());
                ptr3.val = int.Parse(result[1].ToString());
            }
            else
            {
				ptr3.val = int.Parse(result[0].ToString());
                rest = 0;
			}
            ptr1 = ptr1.next;
            ptr2 = ptr2.next;
            if(ptr1 is not null && ptr2 is not null)
            {
                ptr3.next = new ListNode();
				ptr3 = ptr3.next;
            }
		}

        // add the rest of each list
        while(ptr1 is not null)
        {
			var result = (ptr1.val + rest).ToString();
			ptr3.next = new ListNode();
			ptr3 = ptr3.next;
			if (result.Length > 1)
			{
				rest = int.Parse(result[0].ToString());
				ptr3.val = int.Parse(result[1].ToString());
			}
			else
			{
				ptr3.val = int.Parse(result[0].ToString());
				rest = 0;
			}
			ptr1 = ptr1.next;

		}

		while (ptr2 is not null)
		{
			ptr3.next = new ListNode();
			ptr3 = ptr3.next;
			var result = (ptr2.val + rest).ToString();
			if (result.Length > 1)
			{
				rest = int.Parse(result[0].ToString());
				ptr3.val = int.Parse(result[1].ToString());
			}
			else
			{
				ptr3.val = int.Parse(result[0].ToString());
				rest = 0;
			}
			ptr2 = ptr2.next;
		}

		if (rest > 0)
			ptr3.next = new ListNode(rest);


		return list;
	}
}

