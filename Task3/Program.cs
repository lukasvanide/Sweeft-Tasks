int[] array = { 1, 2, 3, 4, 5, 6, 7, 10, 8, 8, 15, 14 };

Console.WriteLine(NotContains(array));

static int NotContains(int[] array)
{
    Array.Sort(array);

    int smallest = 1;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == smallest)
        {
            smallest++;
        }
        else if (array[i] > smallest)
        {
            return smallest;
        }
    }

    return smallest;
}