public static bool IsIsomorphic(string s, string t) {
	if (s == null || t == null || s.Length!=t.Length)
			return false;

	Dictionary<char, char> Isomorphic = new Dictionary<char, char>();
	Dictionary<char, char> Isomorphic2 = new Dictionary<char, char>();
	for (int i = 0; i < s.Length; i++)
	{
		if (Isomorphic.ContainsKey(s[i]))
		{
			if (Isomorphic[s[i]] != t[i])
				return false;
		}
		else
			Isomorphic.Add(s[i], t[i]);
		
		if(Isomorphic2.ContainsKey(t[i]))
		{
			 if (Isomorphic2[t[i]] != s[i])
				return false;
		}else
			Isomorphic2.Add(t[i], s[i]);
	}
	return true;
}