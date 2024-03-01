// url: https://www.hackerrank.com/challenges/divisible-sum-pairs/problem?isFullScreen=true

/// <summary>
/// Given an array of integers and a positive integer k, determine the number of (i, j) pairs where i < j and ar[i] + ar[j] is divisible by k.
/// </summary>
/// <param name="n"></param>
/// <param name="k"></param>
/// <param name="ar"></param>
/// <returns></returns>
public static int divisibleSumPairs(int n, int k, List<int> ar)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if ((ar[i] + ar[j]) % k == 0)
            {
                count++;
            }
        }
    }
    return count;
}

/// <summary>
/// Linq implementation of the divisibleSumPairs method
/// </summary>
/// <param name="n"></param>
/// <param name="k"></param>
/// <param name="ar"></param>
/// <returns></returns>
public static int divisibleSumPairsWithLinq(int n, int k, List<int> ar)
{
    return ar.Select((value, index) => ar.Skip(index + 1).Select(x => x + value).Count(x => x % k == 0)).Sum();
}

Console.WriteLine(divisibleSumPairsWithLinq(6, 3, new List<int> { 1, 3, 2, 6, 1, 2 })); // 5