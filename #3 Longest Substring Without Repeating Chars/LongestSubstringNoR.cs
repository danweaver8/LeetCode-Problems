public static int LengthOfLongestSubstring(string s) {
        if(s==string.Empty || s=="") return 0;
        
            bool[] exist = new bool[256];
            int i = 0; int maxLen = 0;
            for (int j = 0; j < s.Length; j++)
            {
                while (exist[s[j]])
                {
                    exist[s[i]] = false;
                    i++;
                }
                exist[s[j]] = true;
                maxLen = Math.Max(j - i + 1, maxLen);
            }
            return maxLen;
    }