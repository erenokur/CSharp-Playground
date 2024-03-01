// url: https://www.hackerrank.com/challenges/the-birthday-bar/problem?isFullScreen=true
/* Solution explanation:
    1. Starts by iterating through the array of integers and summing the values of the next m integers.
    2. If the sum is equal to d, it increments the count variable.
    3. Finally, it returns the count variable.
*/

public static int TheBirthdayBar(List<int> s, int d, int m)
{
    int count = 0;
    for (int i = 0; i < s.Count - m + 1; i++)
    {
        var sum = 0;
        for (int j = i; j < i + m; j++)
        {
            sum += s[j];
        }
        if (sum == d) count++;
    }
    return count;
}

TheBirthdayBar(new List<int> { 1, 2, 1, 3, 2 }, 3, 2); // 2