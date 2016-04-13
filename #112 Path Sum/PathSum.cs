public static bool HasPathSum(TreeNode root, int sum) {
	 if (root == null) return false;
		if (root.left == null && root.right == null && root.val == sum) return true;
		else if (root.left == null && root.right == null && root.val != sum) return false;
		return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
}