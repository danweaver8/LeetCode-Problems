public static string RemoveDuplicateLetters(string s) {
  if (s == null || s.Length == 0) return string.Empty;
	Dictionary<char, int> seenLetters = new Dictionary<char, int>();
	Stack<char> letters = new Stack<char>();
	List<bool> isVisited = new List<bool>(Enumerable.Repeat<bool>(false, 26));

	for(int i=0;i<s.Length;i++)
	{
		if (seenLetters.ContainsKey(s[i]))
			seenLetters[s[i]]++;
		else
			seenLetters[s[i]] = 1;
	}

	for(int i=0; i< s.Length;i++)
	{
		seenLetters[s[i]]--;
		if (isVisited[s[i] - 'a'] || (letters.Count > 0 && letters.Peek() == s[i])) continue;
		while(letters.Count!=0 && letters.Peek()>s[i] && seenLetters[letters.Peek()]>0)
		{
			isVisited[letters.Peek() - 'a'] = false;
			letters.Pop();
		}
		letters.Push(s[i]);
		isVisited[s[i] - 'a'] = true;
	}
	StringBuilder returnS = new StringBuilder();
	while(letters.Count>0)
	{
		returnS.Insert(0, letters.Pop());
	}
	return returnS.ToString();
}