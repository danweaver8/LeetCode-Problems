 public static IList<string> LetterCombinations(string digits) {
        if (digits == null || digits.Length == 0)
            return new List<string>();
        Dictionary<int, string> map = new Dictionary<int, string>();
        List<string> results = new List<string>();
        map.Add(0, "");
        map.Add(1, "");
        map.Add(2, "abc");
        map.Add(3, "def");
        map.Add(4, "ghi");
        map.Add(5, "jkl");
        map.Add(6, "mno");
        map.Add(7, "pqrs");
        map.Add(8, "tuv");
        map.Add(9, "wxyz");
        
        string myS = string.Empty;
        DFS(digits, results, myS, 0, map);
        return results;
    }
    
    public static void DFS(string digits, List<string> results, string myS, int start, Dictionary<int,string> phoneMe)
    {
        if(start==digits.Length)
            results.Add(myS);
        else
        {
            string temp = phoneMe[digits[start]-'0'];
            //Console.WriteLine(phoneMe[digits[start]-'0']);
            for(int i=0; i<temp.Length; i++)
            {
                myS+= temp[i];
                DFS(digits, results, myS, start+1, phoneMe);
                myS=myS.Remove(myS.Length-1);
            }
        }
    }