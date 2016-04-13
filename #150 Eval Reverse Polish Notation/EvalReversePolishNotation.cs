public static int EvalRPN(string[] tokens) {
	string[] operations = new string[4] { "*", "+", "-", "/" };
	Stack<int> nums = new Stack<int>();

	for(int i=0; i<tokens.Length;i++)
	{
		if(!operations.Contains<string>(tokens[i]))
		{
			nums.Push(int.Parse(tokens[i]));
		}
		else
		{
			int tempNum = 0;
			int first = nums.Pop(), last = nums.Pop();
			switch(tokens[i])
			{
				case "+": tempNum = first + last; break;
				case "-": tempNum = last - first; break;
				case "*": tempNum = first * last; break;
				case "/": tempNum = last / first; break;
			}
			nums.Push(tempNum);
		}
	}
	return nums.Pop();
}