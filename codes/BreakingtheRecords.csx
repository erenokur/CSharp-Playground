//  Url: https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
/*  Solution explanation: 
    1. Get first elements of he scores array and assign it to max and min values. 
    2. Define min and max values.
    3. Create a for loop for all the scores. 
        a. if one value lower than initial value make it min value and increase min count. 
        b. if one value greater than initial value make it max value and increase max count.
*/

public static List<int> breakingRecords(List<int> scores)
{

    int min = scores[0];
    int max = scores[0];
    int minCount = 0;
    int maxCount = 0;

    for (int i = 1; i < scores.Count; i++)
    {
        if (scores[i] < min)
        {
            min = scores[i];
            minCount++;
        }
        else if (scores[i] > max)
        {
            max = scores[i];
            maxCount++;
        }
    }

    Console.WriteLine(maxCount + " " + minCount);
    return new List<int> { maxCount, minCount };
}

breakingRecords(new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 });