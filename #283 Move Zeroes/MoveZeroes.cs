public static void MoveZeroes(int[] nums) {
	int i = 0;
	for(int j=0;j<nums.Length;j++)
	{
		if(nums[j]!=0)
		{
			nums[i++] = nums[j];
		}
		
	}
	while(i<nums.Length)
	{
		nums[i++]=0;
	}
}