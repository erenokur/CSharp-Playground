// Url: https://www.hackerrank.com/challenges/staircase/problem
/* Solution explanation: 
    1. The function uses a for loop to iterate from 1 to n, inclusive. 
        For each iteration, it creates a string hashes that consists of i hash characters, where i is the current iteration number. 
        This represents the steps of the staircase.
    2. Next, it creates a string spaces that consists of n - i space characters. 
        This represents the spaces before the steps. The number of spaces decreases as i increases, 
        which makes the steps align to the right.  
    3. The function then concatenates spaces and hashes to form a string stairs, which represents a row of the staircase.
    4. By doing this for each iteration, the function prints a staircase of n steps.
*/

public static void staircase(int n)
{

    for (int i = 1; i <= n; i++)
    {
        string hashes = new string('#', i);
        string spaces = new string(' ', n - i);
        string stairs = spaces + hashes;

        Console.WriteLine(stairs);
    }
}
