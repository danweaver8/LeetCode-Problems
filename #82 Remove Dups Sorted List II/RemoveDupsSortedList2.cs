public static ListNode DeleteDuplicates(ListNode head) {
	if(head==null || head.next==null) return head;
	
	ListNode result = new ListNode(0);
	result.next = head;
	ListNode pre = result, current = head;

	while (current != null)
	{
		while (current.next != null && current.val == current.next.val)
		{
			current = current.next;
		}
		if (pre.next == current)
			pre = pre.next;
		else
		{
			pre.next = current.next;
		}
		current = current.next;
	}
	return result.next;
}