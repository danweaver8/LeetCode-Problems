public static IList<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        if(root == null)
            return result;
            
        var stack = new Stack<TreeNode>();
        var cur = root;
        while (cur!=null || stack.Any())
        {
            while(cur!=null) 
            {
                stack.Push(cur);
                cur = cur.left;
            }

            cur = stack.Pop();
            result.Add(cur.val);
            cur = cur.right;
        }
        return result;
    }