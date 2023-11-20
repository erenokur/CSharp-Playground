// url: https://www.hackerrank.com/challenges/between-two-sets/problem
/*  Solution explanation: 
    1. Get the max value of the first array and the min value of the second array.
    2. Create a for loop from the max value to the min value.
    3. Check if the value is divisible by all the elements of the first array and if all the elements of the second array are divisible by the value.
    4. If the value is divisible by all the elements of the first array and if all the elements of the second array are divisible by the value, increase the count.
*/
public static int getTotalX(List<int> a, List<int> b)
{
    int count = 0;
    int maxA = a.Max();
    int minB = b.Min();

    for (int i = maxA; i <= minB; i += maxA)
    {
        if (a.All(x => i % x == 0) && b.All(x => x % i == 0))
        {
            count++;
        }
    }

    Console.WriteLine(count);
    return count;
}

getTotalX(new List<int> { 2, 6 }, new List<int> { 24, 36 })