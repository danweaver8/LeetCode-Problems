 public static int SumNumbers(TreeNode root) {
	return leafNumbers(root,0);
}

public static int leafNumbers(TreeNode node,int sum){
	if(node==null) return 0;
	int temp = sum*10+node.val;
	if(node.left==null&&node.right==null) return temp;
	return leafNumbers(node.left,temp)+leafNumbers(node.right,temp);
}