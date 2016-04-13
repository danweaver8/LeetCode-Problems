 public static IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
	if(root == null)
		return new List<IList<int>>();
	List<IList<int>> ListInception = new List<IList<int>>();
	Stack<TreeNode> Level = new Stack<TreeNode>();
	Stack<TreeNode> OtherLevel = new Stack<TreeNode>();

	Level.Push(root);
	while (Level.Count != 0 || OtherLevel.Count!=0)
	{
		List<int> innerListCur = new List<int>();

		while (Level.Count != 0)
		{
			TreeNode node = Level.Pop();
			innerListCur.Add(node.val);

			if (node.left != null)
				OtherLevel.Push(node.left);
			if (node.right != null)
				OtherLevel.Push(node.right);
		}
		if (innerListCur.Count > 0)
			ListInception.Add(innerListCur);
		
		List<int> innerListNext = new List<int>();
		while (OtherLevel.Count != 0)
		{
			TreeNode node = OtherLevel.Pop();
			innerListNext.Add(node.val);

			if (node.right != null)
				Level.Push(node.right);
			if (node.left != null)
				Level.Push(node.left);
			
		}
		if (innerListNext.Count > 0)
			ListInception.Add(innerListNext);
	}

	return ListInception;
}