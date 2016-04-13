 public static IList<IList<int>> LevelOrderBottom(TreeNode root) {
	 if (root != null)
		{
			List<IList<int>> ListInception = new List<IList<int>>();
			Queue<TreeNode> curlevel = new Queue<TreeNode>();
			Queue<TreeNode> nextlevel = new Queue<TreeNode>();
			curlevel.Enqueue(root);
			while (curlevel.Count != 0 || nextlevel.Count != 0)
			{
				List<int> innerListCur = new List<int>();
				while (curlevel.Count != 0)
				{
					TreeNode node = curlevel.Dequeue();
					innerListCur.Add(node.val);

					if (node.left != null)
						nextlevel.Enqueue(node.left);
					if (node.right != null)
						nextlevel.Enqueue(node.right);
				}
				if(innerListCur.Count>0)
					ListInception.Add(innerListCur);

				List<int> innerListNext = new List<int>();
				while (nextlevel.Count != 0)
				{
					TreeNode node = nextlevel.Dequeue();
					innerListNext.Add(node.val);

					if (node.left != null)
						curlevel.Enqueue(node.left);
					if (node.right != null)
						curlevel.Enqueue(node.right);
				}
				if(innerListNext.Count>0)
					ListInception.Add(innerListNext);
			}
			ListInception.Reverse();
			return ListInception;
		}
		else
			return new List<IList<int>>();
    }