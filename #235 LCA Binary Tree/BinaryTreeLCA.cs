/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
	if(root == null)
		return null;
	
	if(root == p || root == q)
		return root;
		
	TreeNode L =  LowestCommonAncestor(root.left, p, q);
	TreeNode R =  LowestCommonAncestor(root.right, p, q);
	
	if(L!=null && R!=null)
		return root;
	return L!= null? L : R;
}
