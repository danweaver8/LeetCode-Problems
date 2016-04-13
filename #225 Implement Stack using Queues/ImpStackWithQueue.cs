public class Stack {
    Queue<int> Queue1 = new Queue<int>();
	Queue<int> Queue2 = new Queue<int>();
	// Push element x onto stack.
	public void Push(int x)
	{
			while(Queue1.Count != 0)
			{
				Queue2.Enqueue(Queue1.Dequeue());
			}

			Queue1.Enqueue(x);

			while(Queue2.Count != 0)
			{
				Queue1.Enqueue(Queue2.Dequeue());
			}
	}

	// Removes the element on top of the stack.
	public void Pop()
	{
		Queue1.Dequeue();
	}

	// Get the top element.
	public int Top()
	{
		return Queue1.Peek();
	}

	// Return whether the stack is empty.
	public bool Empty()
	{
		return Queue1.Count == 0;
	}
}