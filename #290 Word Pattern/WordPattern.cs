public static bool WordPattern(string pattern, string str) {
	Dictionary<char, string> dict = new Dictionary<char, string>();
	var strArray = str.Split(' ').ToArray();
	
	if(pattern.Length!=strArray.Length)
		return false;
		
	for(int i=0; i<pattern.Length; i++)
	{
		if(dict.ContainsKey(pattern[i]))
		{
			if(dict[pattern[i]]!=strArray[i])
				return false;
		}
		else
		{
			if(dict.ContainsValue(strArray[i]))
				return false;
			dict.Add(pattern[i], strArray[i]);
		}
	}
	return true;
}