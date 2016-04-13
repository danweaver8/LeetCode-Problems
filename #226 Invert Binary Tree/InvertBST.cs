/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public static TreeNode InvertTree(TreeNode root) {
	if(root == null)    
		return null;
	TreeNode dummyHead = root;
	Queue<TreeNode> queueMe = new Queue<TreeNode>();
	queueMe.Enqueue(root);

	while (queueMe.Count != 0)
	{
		TreeNode current = queueMe.Dequeue();
		if (current.left != null)
		{
			queueMe.Enqueue(current.left);
		}
		if(current.right!=null)
		{
			queueMe.Enqueue(current.right);
		}
		
		TreeNode temp = current.right;
		current.right = current.left;
		current.left = temp;
	}
	return dummyHead;
}
