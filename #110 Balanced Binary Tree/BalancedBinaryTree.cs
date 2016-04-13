 /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
 public static bool IsBalanced(TreeNode root) {
	if(root==null)
		return true;
	
	if(getHeight(root)==-1)
		return false;
		
	return true;
}

public static int getHeight(TreeNode root)
{
	if(root == null)
		return 0;
	
	int Left = getHeight(root.left);
	int Right = getHeight(root.right);
	
	if(Left == -1 || Right == -1)
		return -1;
	
	if(Math.Abs(Left - Right)>1)
		return -1;
		
	return(Math.Max(Left,Right)+1);
}