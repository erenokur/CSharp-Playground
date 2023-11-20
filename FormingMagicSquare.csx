// url: https://www.hackerrank.com/challenges/magic-square-forming/problem
/* Solution explanation: 
    1. Create a list of magic squares.
    2. Create a minCost variable and assign it to int.MaxValue.
    3. Create a foreach loop for all the magic squares.
        a. Create a cost variable and assign it to 0.
        b. Create a nested for loop for all the elements of the magic square.
            i. Add the absolute value of the difference between the magic square and the input square to the cost variable.
        c. If the cost is lower than the minCost, assign the cost to the minCost.
    4. Print the minCost.
*/

public static int formingMagicSquare(List<List<int>> s)
{
    var magicSquares = new List<List<List<int>>> {
        new List<List<int>> { new List<int> { 8, 1, 6 }, new List<int> { 3, 5, 7 }, new List<int> { 4, 9, 2 } },
        new List<List<int>> { new List<int> { 6, 1, 8 }, new List<int> { 7, 5, 3 }, new List<int> { 2, 9, 4 } },
        new List<List<int>> { new List<int> { 4, 9, 2 }, new List<int> { 3, 5, 7 }, new List<int> { 8, 1, 6 } },
        new List<List<int>> { new List<int> { 2, 9, 4 }, new List<int> { 7, 5, 3 }, new List<int> { 6, 1, 8 } },
        new List<List<int>> { new List<int> { 8, 3, 4 }, new List<int> { 1, 5, 9 }, new List<int> { 6, 7, 2 } },
        new List<List<int>> { new List<int> { 4, 3, 8 }, new List<int> { 9, 5, 1 }, new List<int> { 2, 7, 6 } },
        new List<List<int>> { new List<int> { 6, 7, 2 }, new List<int> { 1, 5, 9 }, new List<int> { 8, 3, 4 } },
        new List<List<int>> { new List<int> { 2, 7, 6 }, new List<int> { 9, 5, 1 }, new List<int> { 4, 3, 8 } }
    };

    var minCost = int.MaxValue;

    foreach (var magicSquare in magicSquares)
    {
        var cost = 0;

        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                cost += Math.Abs(s[i][j] - magicSquare[i][j]);
            }
        }

        if (cost < minCost)
        {
            minCost = cost;
        }
    }

    Console.WriteLine(minCost);
    return minCost;
}
formingMagicSquare(new List<List<int>> { new List<int> { 4, 9, 2 }, new List<int> { 3, 5, 7 }, new List<int> { 8, 1, 5 } });