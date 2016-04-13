public class Solution {
    StringBuilder longPal = new StringBuilder();
    public string LongestPalindrome(string s) {
        if(s.Length<2) return s;
        for(int i=0; i<s.Length; i++)
        {
            //Expand Even
            LongestPalHelper(s, longPal, i, i);
            LongestPalHelper(s, longPal, i, i+1);
        }
        return longPal.ToString();
    }
    
    public void LongestPalHelper(string s, StringBuilder longPal, int i, int j)
    {
        while(i>=0 && j<s.Length && s[i]==s[j])
        {
            if (j - i + 1 > longPal.Length) {
                longPal.Clear();
                
                int endLength = j+1-i;
                Console.WriteLine(endLength);
                longPal.Append(s.Substring(i, endLength));
            }
            i--;
            j++;
        }
    }
}