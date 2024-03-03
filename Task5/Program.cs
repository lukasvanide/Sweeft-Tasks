int input = 5;
Console.WriteLine(CountVariants(input));


static int CountVariants(int stairCount)
{
    if (stairCount <= 2)
        return stairCount;

    int prev = 1;
    int current = 2;

    for (int i = 3; i <= stairCount; i++)
    {
        int next = prev + current;
        prev = current;
        current = next;
    }

    return current;
}
