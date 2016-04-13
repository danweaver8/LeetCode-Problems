 /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
 public static IList<IList<int>> PathSum(TreeNode root, int sum) {
	List<IList<int>> myPaths = new List<IList<int>>();
	List<int> current = new List<int>();
	PathSumII(root, sum, current, myPaths);
	return myPaths;
}

public static void PathSumII(TreeNode root, int sum, List<int> currentPath, List<IList<int>> returnPaths)
{
	if(root==null) return;
	currentPath.Add(root.val);
	
	if(root.left == null && root.right == null && root.val==sum)
		returnPaths.Add(new List<int>(currentPath));
	else
		{
			PathSumII(root.left, sum-root.val, currentPath, returnPaths);
			PathSumII(root.right, sum-root.val, currentPath, returnPaths);
		}
	currentPath.RemoveAt(currentPath.Count-1);
}