 public static int ClimbStairs(int n) {
    if(n==0 || n==1)
        return n;
    int[] store = new int[n];

    store[0] = 1;
    store[1] = 2;

    for(int i = 2; i < n; ++i)
        store[i] = store[i-1] + store[i-2];

    return store[n-1];
}