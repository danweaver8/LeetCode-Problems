public static bool ContainsDuplicate(int[] nums) {
	if (nums.Length == 0)
			return false;

		for (int i = 0; i < nums.Length; i++)
		{
			for (int j = i + 1; j < nums.Length; j++)
			{
				if (nums[i] == nums[j])
						return true;
				
			}
		}
		return false;
}
