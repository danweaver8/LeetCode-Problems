public static bool IsPalindrome(int x) {
      if (x < 0 || x == int.MaxValue || x== int.MinValue) return false;
            int palindromeX = 0;
            int input = x;

            while(x>0)
            {
                palindromeX = palindromeX * 10 + (x % 10);
                x = x / 10;
            }
            return palindromeX == input;
    }