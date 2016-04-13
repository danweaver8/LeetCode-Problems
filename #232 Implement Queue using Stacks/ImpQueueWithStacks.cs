public class Queue {
    Stack<int> Stack1 = new Stack<int>();
    Stack<int> Stack2 = new Stack<int>();
    // Push element x to the back of queue.
    public void Push(int x) {
        while(Stack1.Count != 0)
            Stack2.Push(Stack1.Pop());
            
        Stack1.Push(x);
        
        while(Stack2.Count != 0)
            Stack1.Push(Stack2.Pop());
    }

    // Removes the element from front of queue.
    public void Pop() {
        Stack1.Pop();
    }

    // Get the front element.
    public int Peek() {
        return Stack1.Peek();
    }

    // Return whether the queue is empty.
    public bool Empty() {
        return Stack1.Count == 0;
    }
}