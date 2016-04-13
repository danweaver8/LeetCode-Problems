/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public static ListNode RemoveElements(ListNode head, int val) {
	if(head == null || val == null)
		return null;
	ListNode returnNode = new ListNode(0);
	returnNode.next = head;
	
	ListNode traverseMe = returnNode;
	
	while(traverseMe.next !=null)
	{
		if(traverseMe.next.val == val)
		{traverseMe.next = traverseMe.next.next;}
		else{traverseMe = traverseMe.next;}
	}
	return returnNode.next;
}
