public static int LargestRectangleArea(int[] height) {
	if (height == null || height.Length == 0) return 0;
	Stack<int> largeBuildings = new Stack<int>();

	int max = 0, i = 0;
	while (i < height.Length)
	{
		//push index to stack when the current height is larger than the previous one
		if (largeBuildings.Count == 0 || height[i] >= height[largeBuildings.Peek()])
		{
			largeBuildings.Push(i);
			i++;
		}
		else
		{
			int p = largeBuildings.Pop();
			int h = height[p];
			int w = largeBuildings.Count == 0 ? i : i - largeBuildings.Peek() - 1;
			max = Math.Max(h * w, max);
		}
	}

	while(largeBuildings.Count>0)
	{
		int p = largeBuildings.Pop();
		int h = height[p];
		int w = largeBuildings.Count == 0 ? i : i - largeBuildings.Peek() - 1;
		max = Math.Max(h * w, max);
	}
	return max;
}