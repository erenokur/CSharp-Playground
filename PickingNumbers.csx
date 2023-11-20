// url: https://www.hackerrank.com/challenges/picking-numbers/problem
/* Solution explanation: 
    1. Create a for loop for all the elements of the array. 
    2. Create a nested for loop for all the elements of the array. 
    3. If the difference between the elements is 0 or 1 increase the count. 
    4. If the count is greater than max value make it max value. 
*/

public static int pickingNumbers(List<int> a)
{
    int max = 0;
    for (int i = 0; i < a.Count; i++)
    {
        int count = 0;
        for (int j = 0; j < a.Count; j++)
        {
            if (a[i] - a[j] == 0 || a[i] - a[j] == 1)
            {
                count++;
            }
        }

        if (count > max)
        {
            max = count;
        }
    }
    return max;
}

pickingNumbers(new List<int> { 4, 6, 5, 3, 3, 1 });