public static int StrStr(string haystack, string needle) {
        int hLen = haystack.Length, nLen = needle.Length;
        if(nLen == 0) return 0;
        int thresh = hLen - nLen;
        for(int i=0; i<=thresh; i++)
        {
            //Console.WriteLine(haystack.Substring(i, nLen).ToString());
            if(haystack.Substring(i, nLen)==needle)
                return i;
        }
        return -1;
    }