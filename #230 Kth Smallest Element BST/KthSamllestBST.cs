public static IList<string> SummaryRanges(int[] nums) {
	List<string> myOutput = new List<string>();
	if(nums.Length == 0)
		return myOutput;
	
	int head = 0;
	for(int tail =1; tail<nums.Length;tail++)
	{
		if(nums[tail] != nums[tail-1]+1)
		{
			if(head == tail-1)
				myOutput.Add(nums[head].ToString());
			else
				myOutput.Add(nums[head].ToString() + "->"+nums[tail-1].ToString());
			head = tail;
		}
	}
	if(head == nums.Length-1)
		myOutput.Add(nums[head].ToString());
	else
		myOutput.Add(nums[head].ToString()+"->"+nums[nums.Length-1].ToString());
	return myOutput;
}