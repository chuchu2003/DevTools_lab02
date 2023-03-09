var stack = new Wintellect.PowerCollections.Stack<int>();

for (int i = 0; i < stack.Capacity; i++)
{
    stack.Push(i);
}

Console.WriteLine($"Stack Count: {stack.Count}");

while(stack.Count > 0)
{
    Console.WriteLine($"Pop item: {stack.Pop()}");
}

Console.WriteLine($"Stack Count: {stack.Count}");