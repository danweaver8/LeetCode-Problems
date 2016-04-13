public static int Rob(int[] nums) {
	if(nums.Length == 0)
		return 0;
		
	if(nums.Length == 1)
		return nums[0];
		
   int even = 0;
   int odd = 0;
   
   for(int i =0; i<nums.Length; i++)
   {
	   if(i%2==0)
	   {
		   even += nums[i];
		   even = even > odd ? even:odd;
	   }
	   else
	   {
		   odd+= nums[i];
		   odd = odd > even? odd: even;
	   }
   }
   return even > odd ? even: odd;
}