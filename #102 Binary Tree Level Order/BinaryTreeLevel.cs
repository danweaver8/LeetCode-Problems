public static IList<IList<int>> LevelOrder(TreeNode root) {
	if (root == null) return new List<IList<int>>();

		List<IList<int>> listInception = new List<IList<int>>();
		Queue<TreeNode> LevelMe = new Queue<TreeNode>();
		LevelMe.Enqueue(root);

		while(LevelMe.Count>0)
		{
			List<int> innerList = new List<int>();
			int size = LevelMe.Count();
			for(int i = size; i>0; i--)
			{
				TreeNode node = LevelMe.Dequeue();
				innerList.Add(node.val);
				if (node.left != null) LevelMe.Enqueue(node.left);
				if (node.right != null) LevelMe.Enqueue(node.right);
			}
			listInception.Add(innerList);
		}
		return listInception;
    }