namespace Codewars;

public class MyQueue
{
    private Stack<int> stack;

    public MyQueue()
    {
        stack = new Stack<int>();
    }

    public void Push(int x)
    {
        stack.Push(x);

        Stack<int> newStack = new Stack<int>();

        while (stack.Count > 0)
        {
            newStack.Push(stack.Pop());
        }

        stack = newStack;
    }

    public int Pop()
    {
        return stack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public bool Empty()
    {
        return stack.Count == 0;
    }
}
