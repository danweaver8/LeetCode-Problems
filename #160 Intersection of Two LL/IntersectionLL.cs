 /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
 public static ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
	if(headA == null || headB == null)
		return null;
	
	int Acount = getNodeCount(headA);
	int Bcount = getNodeCount(headB);
	
	if (Acount > Bcount)
		{
			int difference = Acount - Bcount;
			for (int i = difference; i > 0; i--)
			{
				headA = headA.next;
			}
		}
	else if (Bcount > Acount)
		{
			int difference = Bcount - Acount;
			for (int i = difference; i > 0; i--)
			{
				headB = headB.next;
			}
		}

		while (headA != null || headB != null)
		{
			if (headA == headB)
				return headA;
			headA = headA.next;
			headB = headB.next;
		}
		return null;
}
    
public static int getNodeCount(ListNode head)
{
	int count = 1;
	while(head.next!=null)
	{
		head = head.next;
		count++;
	}
	return count;
}