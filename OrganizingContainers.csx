// Url: https://www.hackerrank.com/challenges/organizing-containers-of-balls/problem
/* Solution explanation: 
    1. The function starts by getting the number of elements in the first list (n) and the total number of lists (q).
        It then creates a new list of long integers named colors with n elements, all initialized to zero.
    2. The first nested loop block sums up the elements in each column across all lists. 
        The outer loop iterates over each element in a list (column in the 2D list), and the inner loop iterates over 
        each list (row in the 2D list). The sum of each column is stored in the colors list.
    3. The second loop block checks if it's possible to organize the containers. 
        It iterates over each list and calculates the sum of its elements. 
        Then, it checks if this sum is equal to any of the sums in the colors list. 
        If it finds a match, it sets the matched sum in colors and the sum of the list elements to -1 and breaks the inner loop.
        If it doesn't find a match (i.e., the sum of the list elements is not equal to -1 after the inner loop), it returns "Impossible". 
    4. If the function goes through all the lists without returning "Impossible", 
        it means it's possible to organize the containers, so it returns "Possible". 
*/
public static string organizingContainers(List<List<long>> container)
{
    int n = container[0].Count;
    int q = container.Count;

    List<long> colors = new List<long>(new long[n]);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < q; j++)
        {
            colors[i] += container[j][i];
        }
    }

    for (int i = 0; i < n; i++)
    {
        long t = container[i].Sum();

        for (int j = 0; j < n; j++)
        {
            if (t != colors[j])
            {
                continue;
            }

            t = colors[j] = -1;
            break;
        }

        if (t != -1)
        {
            return "Impossible";
        }
    }

    return "Possible";
}
