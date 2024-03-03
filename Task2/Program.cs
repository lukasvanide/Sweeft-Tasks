using System.Runtime.CompilerServices;
//me mogweret mailze magram pasuxi ar mimigia amito chavtvale ro coinebis raodenoba aris ulimito 
int input = 86;

Console.WriteLine(MinSplit(input));



static int MinSplit(int amount)
{
    int[] coins = new int[] { 50, 20, 10, 5, 1 };
    int count = 0;

    for (int i = 0; i < coins.Length; i++)
    {
        count += amount / coins[i];
        amount %= coins[i];
    }

    return count;
}