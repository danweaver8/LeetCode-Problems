 public static void Rotate(int[] nums, int k) {
   if(k>nums.Length)
	k = k% nums.Length;
	
  int order = nums.Length - k;
  
  reverse(nums,0, order-1);
  reverse(nums,order, nums.Length-1);
  reverse(nums,0, nums.Length-1);
}

public static void reverse(int[] nums, int left, int right)
{
	if(nums == null || nums.Length == 1)
		return;
		
	while(left<right)
	{
		int temp = nums[left];
		nums[left] = nums[right];
		nums[right] = temp;
		
		left++;
		right--;
	}
}