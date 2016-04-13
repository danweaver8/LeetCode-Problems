	public static IList<string> GenerateParenthesis(int n) {
        List<string> allParen = new List<string>();
        if(n>0)
            DFS(string.Empty, n, n, allParen);
        return allParen;
    }
    
    private static void DFS(string preParen, int left, int right, List<string> allParen)
    {
        if(left==0 && right==0) allParen.Add(preParen);
        if(left>0) DFS(preParen+"(", left-1, right, allParen);
        if(left<right) DFS(preParen+")", left, right-1, allParen);
    }