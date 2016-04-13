public static IList<int> PreorderTraversal(TreeNode root) {
	List<int> preOrderTraversal = new List<int>();
	if(root==null)
		return preOrderTraversal;
		
	Stack<TreeNode> preMe = new Stack<TreeNode>();
	preMe.Push(root);
	
	while(preMe.Count>0)
	{
		TreeNode temp = preMe.Pop();
		preOrderTraversal.Add(temp.val);
		if(temp.left!=null)
		   preMe.Push(temp.left);
		if(temp.right!=null)
		   preMe.Push(temp.right);
	}
	return preOrderTraversal;
}