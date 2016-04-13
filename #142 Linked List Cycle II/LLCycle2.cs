/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public static ListNode DetectCycle(ListNode head) {
	if(head == null) return null;
	
	ListNode slow = head;
	ListNode fast = head;
	
	while(fast.next!=null && fast.next.next!=null)
	{
		slow = slow.next;
		fast = fast.next.next;
		
		if(fast == slow)
		   { 
			   ListNode slow2 = head;
			   while(slow2!=slow)
			   {
				   slow2=slow2.next;
				   slow = slow.next;
			   }
			   return slow;
		   }
	}
	return null;
}