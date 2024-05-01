using Queue;

Queue<int> queue = new Queue<int>();
queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);

Reverse(queue);
Console.WriteLine(string.Join(" ", queue));

ArrayQueue<int> aq = new ArrayQueue<int>();

aq.Enqueue(10);
aq.Enqueue(20);
aq.Enqueue(30);

Console.WriteLine(aq.Dequeue());
Console.WriteLine(aq.Peek());

static void Reverse(Queue<int> queue)
{
	Stack<int> stack = new Stack<int>();

	while (queue.Count > 0)
	{
		stack.Push(queue.Dequeue());
	}

	while (stack.Count > 0)
	{
		queue.Enqueue(stack.Pop());
	}
}