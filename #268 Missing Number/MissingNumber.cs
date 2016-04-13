public static int MissingNumber(int[] nums) {
   int arrayLen = nums.Length;
   int seqSum = arrayLen*(arrayLen+1)/2;
   int sum = 0;
   for(int i=0;i<arrayLen;i++)
   {
	   sum+=nums[i];
   }
   return seqSum - sum;
}