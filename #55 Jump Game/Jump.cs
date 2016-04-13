 public static bool CanJump(int[] nums) {
        int jump=1;
        for(int i=0; i<nums.Length-1; i++)
        {
            jump--;
            if(nums[i]>jump)jump=nums[i];
            if(jump==0)return false;
        }
        return true;
    }