string[] input = Console.ReadLine();
                 
int N = int.Parse(input[0]); 
int S = int.Parse(input[1]); 
int X = int.Parse(input[2]); 

int[] elements = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

Stack<int> stack = new Stack<int>();

for (int i = 0; i < N; i++)
{
    stack.Push(elements[i]);
}

for (int i = 0; i < S; i++)
{
    if (stack.Count > 0)
    {
        stack.Pop();
    }
}


if (stack.Contains(X))
{
    Console.WriteLine("found");
}
else
{

    if (stack.Count == 0)
    {
        Console.WriteLine("nothing found");
    }
    else
    {
        Console.WriteLine(stack.Min());
    }
}

