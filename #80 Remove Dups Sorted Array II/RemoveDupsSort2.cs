 public static int RemoveDuplicates(int[] nums) {
	if(nums.Length==0) return 0;
	int j = 0, count = 1;
	for(int i=1; i< nums.Length; i++)
	{
		if(nums[i]!=nums[j])
		{
			nums[++j]=nums[i];
			count=0;
		}else if(count<2)
		{
			nums[++j]=nums[i];
		}
		count++;
	}
	return j+1;
}