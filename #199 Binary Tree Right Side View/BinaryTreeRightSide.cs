public static IList<int> RightSideView(TreeNode root) {
	List<int> res = new List<int>();
	Queue<TreeNode> preQueue = new Queue<TreeNode>();
	if(root != null)
		preQueue.Enqueue(root);
	Queue<TreeNode> curQueue = new Queue<TreeNode>();
	while (preQueue.Any())
	{
		res.Add(preQueue.Peek().val);
		while (preQueue.Any())
		{
			var top = preQueue.Dequeue();
			if (top.right != null) curQueue.Enqueue(top.right);
			if (top.left != null) curQueue.Enqueue(top.left);
		}

		while (curQueue.Any())
		{
			preQueue.Enqueue(curQueue.Dequeue());
		}
	}
   return res;
}