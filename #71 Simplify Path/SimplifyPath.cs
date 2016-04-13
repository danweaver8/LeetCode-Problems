 public static string SimplifyPath(string path) {
	if (path.Length == 0 || path == null) return path;
	string[] paths = path.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
	Stack<string> mypath = new Stack<string>();

	for(int i=0; i<paths.Length;i++)
	{
		if (paths[i] == ".." && mypath.Count>0)
			mypath.Pop();
		else if (paths[i] == "." || paths[i] == "..") continue;
		else
			mypath.Push(paths[i]);
	}

	if (mypath.Count == 0) return "/";

	StringBuilder returnPath = new StringBuilder();
	while(mypath.Count>0)
	{
		returnPath.Insert(0,"/" + mypath.Pop());
	}

	return returnPath.ToString();
}