public static ListNode ReverseBetween(ListNode head, int m, int n) {
	if (head == null || head.next==null || m==n) return head;
	ListNode previous = m == 1 ? head : null;
	ListNode current = head;
	ListNode next = head.next;
	int position = 1;

	while(current!=null)
	{
		if (position < m)
		{
			previous = current;
			current = next;
			next = next.next;
		}
		else if (position >= m && position < n)
		{
			ListNode temp = next.next;
			next.next = current;
			current = next;
			next = temp;
		}
		else
			break;
		position++;
	}

	//RE-LINK NODES 
	if (m == 1)
	{
		previous.next = next;
		return current;
	}
	else
	{
		previous.next.next = next;
		previous.next = current;
		return head;
	}
}