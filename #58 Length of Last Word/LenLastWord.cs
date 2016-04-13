 public static int LengthOfLastWord(string s) {
        //If s is null or the length is zero we know just to return zero
        if (s == null || s.Length == 0)
                return 0;
        //We split the words into a string array of words separated by spaces    
        var words = s.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
        
        //
        return words.Length == 0 ? 0 : words[words.Length - 1].Length;
    }