 public static int RangeBitwiseAnd(int m, int n) {
   while(m<n) n &= (n-1);
	return n;
}