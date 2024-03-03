string input = "(()())";
Console.WriteLine(IsProperly(input)); // Output: True

input = "())()";
Console.WriteLine(IsProperly(input)); // Output: False


static bool IsProperly(string sequence)
{
    int balance = 0;
    for (int i = 0; i < sequence.Length; i++)
    {
        char c = sequence[i];
        if (c == '(')
        {
            balance++; 
        }
        else if (c == ')')
        {
            balance--; 

            if (balance < 0)
            {
                return false;
            }
        }
    }
    return balance == 0;
}

