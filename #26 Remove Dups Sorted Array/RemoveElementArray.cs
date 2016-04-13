 public static int RemoveElement(int[] nums, int val) {
        if(nums.Length == 0) return 0;
        
        int id=0;
        for(int i =0; i<nums.Length; i++)
        {
            if(nums[i]!=val) nums[id++] = nums[i];
        }
        return id;
    }