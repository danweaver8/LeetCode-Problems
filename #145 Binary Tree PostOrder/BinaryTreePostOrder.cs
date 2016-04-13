public static IList<int> PostorderTraversal(TreeNode root) {
	List<int> PostOrder = new List<int>();
	if(root == null) return PostOrder;
	
	Stack<TreeNode> myStack = new Stack<TreeNode>();
	myStack.Push(root);
	while(myStack.Count > 0)
	{
		TreeNode rootMe = myStack.Pop();
		PostOrder.Insert(0, rootMe.val);
		if(rootMe.left!=null)
			myStack.Push(rootMe.left);
		if(rootMe.right!=null)
			myStack.Push(rootMe.right);
		
	}
	return PostOrder;
}