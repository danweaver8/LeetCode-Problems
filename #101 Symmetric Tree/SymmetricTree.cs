 public static bool IsSymmetric(TreeNode root) {
    if(root == null)
        return true;
        
    return IsSymmetric(root.left, root.right);
}
    
 public bool IsSymmetric(TreeNode Left, TreeNode Right)
 {
	if(Left == null && Right == null)
		return true;
	if (Left == null || Right == null) 
		return false;
		
	if((Left.val == Right.val) && (IsSymmetric(Left.left,Right.right)) && (IsSymmetric(Left.right,Right.left)))
		return true;
	else
		return false;
 }