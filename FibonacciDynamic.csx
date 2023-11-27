private static int fib(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else if (n == 1)
    {
        return 1;
    }
    else
    {
        return fib(n - 1) + fib(n - 2);
    }
}

/// <summary>
/// Memoization is a technique for improving the performance of recursive algorithms. It involves rewriting the recursive algorithm so that as answers to problems are found, they are stored in an array. The next time the same problem is encountered, the stored value is used instead of having to recalculate it.
/// </summary>
/// <param name="n"></param>
/// <param name="memo"></param>
/// <returns></returns>
private static int fibMemo(int n, Dictionary<int, int> memo = null)
{
    if (memo == null)
    {
        memo = new Dictionary<int, int>();
    }

    if (memo.ContainsKey(n))
    {
        return memo[n];
    }
    else if (n <= 2)
    {
        memo[n] = 1;
        return 1;
    }
    else
    {
        int result = fibMemo(n - 1, memo) + fibMemo(n - 2, memo);
        memo[n] = result;
        return result;
    }
}

/// <summary>
/// Fibonacci sequence using dynamic programming. This dynamic programming solution is more efficient than the memoized solution because it does not require recursion. It does not use as much memory as the memoized solution because it does not require an array to store the results of previous calculations.
/// </summary>
/// <param name="n"></param>
/// <returns></returns>
private static int fibDynamic(int n)
{
    int a = 1;
    int b = 1;
    for (int i = 2; i < n; i++)
    {
        int temp = a;
        a = b;
        b = temp + b;
    }
    return b;
}


// Time for single recursive call
Console.WriteLine("Time for single recursive call:");
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
fib(20);
stopwatch.Stop();
long elapsedMicroseconds = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
Console.WriteLine(elapsedMicroseconds + " μs");

// Time for 100 recursive calls
Console.WriteLine("\nTime for 100 recursive calls:");
stopwatch.Reset();
stopwatch.Start();
for (int i = 0; i < 100; i++)
{
    fib(20);
}
stopwatch.Stop();
elapsedMicroseconds = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
Console.WriteLine(elapsedMicroseconds + " μs");

// Memoized Fibonacci function
Console.WriteLine("\nUsing memoization:");

// Time for single memoized call
Console.WriteLine("\nTime for single memoized call:");
stopwatch.Reset();
stopwatch.Start();
fibMemo(20);
stopwatch.Stop();
elapsedMicroseconds = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
Console.WriteLine(elapsedMicroseconds + " μs");

// Time for 100 memoized calls
Console.WriteLine("\nTime for 100 memoized calls:");
stopwatch.Reset();
stopwatch.Start();
for (int i = 0; i < 100; i++)
{
    fibMemo(20);
}
stopwatch.Stop();
elapsedMicroseconds = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
Console.WriteLine(elapsedMicroseconds + " μs");

// Time for single dynamic call
Console.WriteLine("\nTime for single memoized call:");
stopwatch.Reset();
stopwatch.Start();
fibDynamic(20);
stopwatch.Stop();
elapsedMicroseconds = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
Console.WriteLine(elapsedMicroseconds + " μs");

// Time for 100 dynamic calls
Console.WriteLine("\nTime for 100 memoized calls:");
stopwatch.Reset();
stopwatch.Start();
for (int i = 0; i < 100; i++)
{
    fibDynamic(20);
}
stopwatch.Stop();
elapsedMicroseconds = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
Console.WriteLine(elapsedMicroseconds + " μs");