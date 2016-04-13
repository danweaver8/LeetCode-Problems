public static bool IsPalindrome(ListNode head) {
	if(head == null || head.next == null)
		return true;
		
	ListNode slow = head;
	ListNode fast = head;
	
	while(fast.next!=null && fast.next.next!=null)
	{
		slow=slow.next;
		fast=fast.next.next;
	}
	ListNode head2 = slow.next;
	
	//Reverse Now
	ListNode r1 = slow.next;
	ListNode r2 = r1.next;
	
	while(r1!=null && r2!=null)
	{
		ListNode temp = r2.next;
		r2.next = r1;
		r1 = r2;
		r2 = temp;
	}
	head2.next = null;
	
	ListNode secondHalf = r1;
	slow = head;
	while(secondHalf != null)
	{
		if(slow.val != secondHalf.val)
			return false;
		secondHalf = secondHalf.next;
		slow = slow.next;
	}
	return true;
}