// url: https://www.hackerrank.com/challenges/time-conversion/problem
public static string timeConversion(string s)
{
    DateTime time = DateTime.Parse(s);
    return time.ToString("HH:mm:ss");
}