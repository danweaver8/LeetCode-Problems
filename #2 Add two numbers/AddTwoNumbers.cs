public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
       ListNode ListA = l1; ListNode ListB = l2;
        ListNode retLinked = new ListNode(0);
        ListNode tracker = retLinked;
        int overflow= 0;
        while(ListA != null || ListB != null)
        {
            int x = (ListA != null) ? ListA.val : 0;
            int y = (ListB != null) ? ListB.val : 0;
            int sum = overflow + x + y;
            overflow = sum / 10;
            retLinked.next = new ListNode(sum % 10);
            retLinked = retLinked.next;
            if (ListA != null) ListA = ListA.next;
            if (ListB != null) ListB = ListB.next;
        }
        if (overflow > 0)
            retLinked.next = new ListNode(overflow);
        return tracker.next;
    }