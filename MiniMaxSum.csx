// Url: https://www.hackerrank.com/challenges/mini-max-sum/problem
/* Solution explanation: 
    1. Create a list for max number calculation. 
    2. Get the max number from the array and remove it from the list. 
    3. Create a list for min number calculation. 
    4. Get the min number from the array and remove it from the list. 
    5. Sum the max number list and min number list. 
    6. Print the result. 
*/

public static void miniMaxSum(List<int> arr)
{
    List<int> MaxNumCal = new List<int>();
    MaxNumCal = arr.ToList();
    int max = arr.Max();
    MaxNumCal.Remove(max);

    List<int> MinNumCal = new List<int>();
    MinNumCal = arr.ToList();
    int min = arr.Min();
    MinNumCal.Remove(min);

    long maxResult = MaxNumCal.Sum(x => (long)x);
    long minResult = MinNumCal.Sum(x => (long)x);

    Console.WriteLine(maxResult + " " + minResult);
}