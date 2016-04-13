public static void SortColors(int[] nums) {
	int red=0, blue=nums.Length-1;
	
	for(int i=0; i<=blue; i++)
	{
		if(nums[i]==0)
			swap(nums, i, red++);
		else if (nums[i]==2)
			swap(nums,i--,blue--);
	}
}

public static void swap(int[] nums, int i, int j) {
	int temp = nums[i];
	nums[i] = nums[j];
	nums[j] = temp;
    }