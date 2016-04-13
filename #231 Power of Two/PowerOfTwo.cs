public static bool IsPowerOfTwo(int n) {
	if(n <= 0)
		return false;
	if(n == 1)
		return true;
	while( n > 1 && n % 2 == 0)
		n /= 2;
	if(n == 1)
		return true;
	else
		return false;
}