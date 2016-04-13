/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left =0, right = n, middle = 0;
        if(n==1)
            return 1;
            
        while(left<=right)
        {
            middle = left+(right-left)/2;
            if(IsBadVersion(middle))
                right = middle-1;
            else
                left = middle+1;
        }
        return left;
    }
}