int foodQuantity = int.Parse(Console.ReadLine());
Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
Console.WriteLine(orders.Max());

while (orders.Count > 0)
{
    int currentOrder = orders.Peek();

    if (foodQuantity >= currentOrder)
    {
        foodQuantity -= currentOrder;
        orders.Dequeue();
    }
    else
    {
        break;
    }
}

if (orders.Count == 0)
{
    Console.WriteLine("All orders are completed");
}
else
{
    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
}
