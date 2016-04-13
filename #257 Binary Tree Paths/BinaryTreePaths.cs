/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public static IList<string> BinaryTreePaths(TreeNode root)
{
	List<string> DepthPaths = new List<string>();
	if (root == null)
		return DepthPaths;

   
	BinaryTreePathHelper(root, string.Empty, DepthPaths);
	return DepthPaths;
}

public static void BinaryTreePathHelper(TreeNode root, string path, List<string> returnPaths)
{
	if (root.left == null && root.right == null) returnPaths.Add(path + root.val);
	if (root.left != null) BinaryTreePathHelper(root.left, path + root.val + "->", returnPaths);
	if (root.right != null) BinaryTreePathHelper(root.right, path + root.val + "->", returnPaths);
}
