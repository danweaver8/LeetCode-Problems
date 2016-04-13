/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public static ListNode ReverseList(ListNode head) {
	ListNode dummyHead = head;
	
	ListNode reverse = null;
	while(dummyHead != null)
	{
		ListNode temp = dummyHead.next;
		dummyHead.next = reverse;
		reverse = dummyHead;
		dummyHead = temp;
	}
	return reverse;
}
