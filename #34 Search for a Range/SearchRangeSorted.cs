public static int[] SearchRange(int[] nums, int target) {
        if(nums == null||target==null)
            return new int[]{-1,-1};
            
        bool found = false;
        int high = nums.Length-1, low = 0, mid=-1;
        while(low<=high)
        {
            mid = (high+low/2);
            if(nums[mid]==target){
                found=true;
                break;
            }
            else if(nums[mid]<target){
                low = mid+1;
            }
            else high = mid-1;
        }
        
        if(!found)
            return new int[]{-1,-1};
            
      int left = mid;
      while (left >= 0 && nums[left] == target) --left;
      // Find right
      int right = mid;
      while (right < nums.Length && nums[right] == target) ++right;

      return new int[]{left + 1, right - 1};    
        
    }