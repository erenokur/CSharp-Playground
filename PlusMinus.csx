// Url: https://www.hackerrank.com/challenges/plus-minus/problem
/* Solution explanation: 
    1. The function starts by creating three separate lists: 
        positiveNumbers, negativeNumbers, and neutralNumbers. 
        These lists will hold the positive, negative, and zero values from the input list, respectively. 
    2. Iterate over each number in the input list. If a number is positive, it's added to the positiveNumbers list. 
        If it's negative, it's added to the negativeNumbers list. If it's zero, it's added to the neutralNumbers list. 
    3. After categorizing all the numbers, the function calculates the proportions of positive, negative, and zero values. 
        It does this by dividing the count of numbers in each category by the total count of numbers in the input list. 
        The results are stored in positiveResult, negativeResult, and neutralResult, respectively. 
        Note that the counts are cast to decimal before division to ensure that the results are decimal numbers. 
    4. Finally, the function prints the calculated proportions. It prints the proportion of positive numbers first, 
        followed by the proportion of negative numbers, and then the proportion of zero values. 
*/

public static void plusMinus(List<int> arr)
{
    List<int> positiveNumbers = new List<int>();
    List<int> negativeNumbers = new List<int>();
    List<int> neutralNumbers = new List<int>();
    foreach (int num in arr)
    {
        if (num > 0)
        {
            positiveNumbers.Add(num);
        }
        else if (num < 0)
        {
            negativeNumbers.Add(num);
        }
        else
        {
            neutralNumbers.Add(num);
        }
    }
    decimal positiveResult = (decimal)positiveNumbers.Count() / (decimal)arr.Count();
    decimal negativeResult = (decimal)negativeNumbers.Count() / (decimal)arr.Count();
    decimal neutralResult = (decimal)neutralNumbers.Count() / (decimal)arr.Count();

    Console.WriteLine(positiveResult);
    Console.WriteLine(negativeResult);
    Console.WriteLine(neutralResult);
}