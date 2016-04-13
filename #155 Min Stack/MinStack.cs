public class MinStack
{
	Stack<int> main = new Stack<int>();
	Stack<int> min = new Stack<int>();

	public void Push(int x)
	{
		main.Push(x);
		if (min.Count == 0 || min.Peek() >= x)
			min.Push(x);
	}

	public void Pop()
	{
		int poppedElement = main.Pop();
		if (min.Peek() == poppedElement)
			min.Pop();
	}

	public int Top()
	{
		return main.Peek();
	}

	public int GetMin()
	{
		return min.Peek();
	}
}