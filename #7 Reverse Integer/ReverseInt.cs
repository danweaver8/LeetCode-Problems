 public static int Reverse(int x) {
          long result = 0;
            while (x != 0)
            {
                result = x%10+result * 10;
                x = x / 10;
            }
            if (result > (long)int.MaxValue || result < (long)int.MinValue)
            {
                result = 0;
            }
            return (int)result;
    }