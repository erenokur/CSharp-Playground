// url: https://www.hackerrank.com/challenges/kangaroo/problem
/* Solution explanation:
    1. Get the locations and speed of the kangaroos.
    2. Check if the speed is 0 or the locations are not divisible by the speed or the locations are less than 0.
    3. If any of the above is true, return "NO", otherwise return "YES".
*/
public static string kangaroo(int x1, int v1, int x2, int v2)
{
    int locations = x1 - x2;
    int speed = v2 - v1;

    Console.WriteLine("Test");
    return (speed == 0 || locations % speed != 0 || locations / speed < 0) ? "NO" : "YES";
}

Console.WriteLine(kangaroo(2, 1, 1, 2));