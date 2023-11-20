// url: https://www.hackerrank.com/challenges/apple-and-orange/problem
/* Solution explanation: 
    1. Create a function to add values to the elements of the array. 
    2. Create a function to check the distances of the elements of the array. 
    3. Create a function to count the elements of the array. 
    4. Call the functions in the main function. 
*/

private static List<int> ValueAdder(List<int> objects, int valueToAdd)
{
    return objects.Select(x => x + valueToAdd).ToList();
}
private static List<int> CheckDistances(List<int> objects, int min, int max)
{
    List<int> results = objects.Where(x => x >= min && x <= max).ToList();
    return results;

}

public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
{
    Console.WriteLine(CheckDistances(ValueAdder(apples, a), s, t).Count());
    Console.WriteLine(CheckDistances(ValueAdder(oranges, b), s, t).Count());
}

countApplesAndOranges(5, 10, 2, 3, new List<int> { -2, 2, 1 }, new List<int> { 5, -6 });