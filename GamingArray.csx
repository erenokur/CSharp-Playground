// Url: https://www.hackerrank.com/challenges/an-interesting-game-1
/* Solution explanation: 
    1. Create a for loop for all the elements of the array. 
    2. Create a variable to store the count value. 
    3. Create a variable to store the previous value. 
    4. If the current value is greater than the previous value increase the count. 
    5. If the count is even return ANDY else return BOB.
*/
public static string gamingArray(List<int> arr)
{
    int count = 0;
    int prev = 0;

    foreach (int num in arr)
    {
        if (num > prev)
        {
            prev = num;
            count++;
        }
    }

    return count % 2 == 0 ? "ANDY" : "BOB";
}