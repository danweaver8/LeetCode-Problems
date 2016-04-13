public static RandomListNode CopyRandomList(RandomListNode head) {
   if (head == null) return null;

	Dictionary<RandomListNode, RandomListNode> deepCopyMe = new Dictionary<RandomListNode, RandomListNode>();
	RandomListNode node = head;
	int count = 0;

	while(node!=null && !deepCopyMe.ContainsKey(node))
	{
		count++;
		RandomListNode newnode = new RandomListNode(node.label);
		deepCopyMe.Add(node, newnode);
		node = node.next;
	}

	node = head;

	for(int i=0; i< count;i++)
	{
		RandomListNode newNode = deepCopyMe[node];
		if (node.next != null)
			newNode.next = deepCopyMe[node.next];
		if (node.random != null)
			newNode.random = deepCopyMe[node.random];

		node = node.next;
	}

	return deepCopyMe[head];
}