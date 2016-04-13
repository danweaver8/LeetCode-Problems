public class BSTIterator
{
	private Stack<TreeNode> stack = null;

	public BSTIterator(TreeNode root)
	{
		stack = new Stack<TreeNode>();
		TreeNode temp = root;
		while (temp != null)
		{
			stack.Push(temp);
			temp = temp.left;
		}
	}

	public bool HasNext()
	{
		return (stack.Count != 0);
	}

	public int Next()
	{
		if (stack.Count == 0)
		{
			return Int32.MaxValue;
		}

		// pop a node
		TreeNode popped = stack.Pop();

		// init stack with right node
		TreeNode temp = popped.right;
		while (temp != null)
		{
			stack.Push(temp);
			temp = temp.left;
		}

		return popped.val;
	}
}