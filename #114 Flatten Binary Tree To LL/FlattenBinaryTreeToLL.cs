 public static void Flatten(TreeNode root) {
        if(root == null)
            return;
        
        Flatten(root.left);
        Flatten(root.right);
        
        TreeNode right = root.right;
        root.right = root.left;
        root.left = null;
        
        while(root.right!= null)
        {
            root = root.right;
        }
        root.right = right;
    }