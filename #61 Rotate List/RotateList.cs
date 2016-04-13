public static ListNode RotateRight(ListNode head, int k) {
	if (head == null || k == 0)
			return head;
		ListNode slow = head, fast = head;
		int count = 1;
		while (fast.next != null)
		{
			count++;
			fast = fast.next;
		}
		if (count == 1) return head;
		k = k%count;
		if (k == 0) return head;
		for (int j = 0; j < count - k - 1; j++) //Get the i-n%i th node
		{ slow = slow.next; }

		fast.next = head;
		head = slow.next;
		slow.next = null;

		return head;
   }