public static int CompareVersion(string version1, string version2) {
	if(version1 == string.Empty || version2 == string.Empty)
		return 0;
		
	string[] v1 = version1.Split('.');
	string[] v2 = version2.Split('.');
	
	int length = Math.Max(v2.Length, v1.Length);
	
	for(int i = 0; i<length; i++)
	{
		int v1A = int.Parse(i < v1.Length? v1[i]:"0");
		int v2A = int.Parse(i < v2.Length? v2[i]:"0" );
		if(v1A > v2A)
			return 1;
		else if(v1A < v2A)
			return -1;
	}
	return 0;
}