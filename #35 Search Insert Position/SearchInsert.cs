public static int SearchInsert(int[] nums, int target) {
        int low = 0; int high = nums.Length;
     
        while(low<high)
        {
             int mid =(high+low)/2;
            if (nums[mid] == target) {
                return mid;
            }
            if(nums[mid]>target)
            {
                high = mid;
            }
            if(nums[mid]<target)
            {
                low = mid +1;
            }
        }
        return low;
    }