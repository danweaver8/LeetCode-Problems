 public static int MaxSubArray(int[] nums) {
        int max = int.MinValue, sum = 0;
		for (int i = 0; i < nums.Length; i++) 
		{
			if (sum < 0) 
				sum = nums[i];
			else 
				sum += nums[i];
			if (sum > max)
				max = sum;
		}
    return max;
}