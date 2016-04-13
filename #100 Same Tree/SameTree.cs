/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public static bool IsSameTree(TreeNode p, TreeNode q) {
    if(p==null && q==null)
        return true;
    
    if(p==null || q==null)
	return false;
	
	if((p.val == q.val) && (IsSameTree(p.left, q.left)) && (IsSameTree(p.right,q.right)))
		return true;
	else
		return false;
}