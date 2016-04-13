 /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
 public static ListNode DeleteDuplicates(ListNode head) {
        if(head==null || head.next==null) return head;
        ListNode dummyHead = new ListNode(0);
        dummyHead.next = head;
        ListNode current = head.next;
        ListNode pre = dummyHead;
        while(current!=null)
        {
            if(pre.next.val == current.val)
            {
                while (current.next != null && current.val == current.next.val)
                {
                    current = current.next;
                }
                pre.next = current.next;
                current= current.next==null?null:current.next;
            }
            else
            {
                pre=pre.next;
                current=current.next;
            }
        }
        return dummyHead.next;
    }