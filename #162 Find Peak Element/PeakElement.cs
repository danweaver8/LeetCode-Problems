public static int FindPeakElement(int[] nums) {
	if(nums.Length<1)
		return 0;
		
	int high = nums.Length-1, low = 0, mid = 0;
	while(low<high)
		{
			mid = (low+high)/2;
			if(nums[mid]<nums[mid+1])
				low = mid+1;
			else if(nums[mid]>nums[mid+1])
				high = mid;
		}
	return low;
}