// Url: https://www.hackerrank.com/challenges/birthday-cake-candles/problem
public static int birthdayCakeCandles(List<int> candles)
{
    int max = candles.Max();
    int result = candles.Count(x => x == max);
    return result;
}