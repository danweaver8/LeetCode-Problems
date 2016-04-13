public static bool ContainsNearbyDuplicate(int[] nums, int k) {
	if(nums.Length == 0 || k ==0)
		return false;
		
	for (int i = 0; i < nums.Length; i++)
		{
			for (int j = i+1; j < nums.Length; j++)
			{
				if (nums[i] == nums[j])
				{
					int difference = j-i;
					if (difference<=k)
						return true;
				}
			}
		}
	return false;
    }