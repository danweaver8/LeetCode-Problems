public static int MajorityElement(int[] nums) {
	Dictionary<int, int> myNumCount = new Dictionary<int, int>();
	for(int i =0; i< nums.Length; i++)
	{
		if(myNumCount.ContainsKey(nums[i]))
		{
			int count = myNumCount[nums[i]];
			count++;
			myNumCount[nums[i]] = count;
		}
		else
		{
			myNumCount[nums[i]] = 1;
		}
	}
    int max = myNumCount.Values.Max();
	return myNumCount.FirstOrDefault(x => x.Value == max).Key;
}