public static int MySqrt(int x) {
	   if (x == 0) return 0;

		int start = 1, end= x, ans=1;
		while(start<=end)
		{
			int mid = start + (end - start) / 2;
			if (mid <= x / mid)
			{ start = mid + 1; ans = mid; }
			else
				end = mid - 1;
		}
		return ans;
    }