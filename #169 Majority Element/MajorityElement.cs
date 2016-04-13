 public static int MajorityElement(int[] nums) {
	//A bit shorter of an answer than my last submission
	Dictionary<int, int> myNumCount = new Dictionary<int, int>();
	for(int i =0; i< nums.Length; i++)
	{
		if(myNumCount.ContainsKey(nums[i]))
		{
			myNumCount[nums[i]]++;
		}
		else
		{
			myNumCount.Add(nums[i], 1);
		}
		if(myNumCount[nums[i]]>nums.Length/2)
			return nums[i];
	}
   return Int32.MaxValue;
}