// url: https://www.hackerrank.com/challenges/diagonal-difference/problem
/* Solution explanation:
    1. The function starts by initializing four variables: rightToLeftAddition and leftToRightAddition
        to hold the sums of the diagonals, and rightToLeftIndex and leftToRightIndex to keep track of the current position in each diagonal.
        The rightToLeftIndex is initialized to the number of elements in the first row 
        (which is the same as the number of rows in the matrix), and leftToRightIndex is initialized to 0.
    2. For loop to iterate over each row in the matrix. For each row, it adds the element at the rightToLeftIndex - 1 
        position to rightToLeftAddition and the element at the leftToRightIndex position to leftToRightAddition. 
        It then decrements rightToLeftIndex and increments leftToRightIndex. This ensures that the function moves diagonally 
        from right to left and from left to right across the matrix.
    3. After going through all the rows, the function calculates the difference between the sums of the diagonals by subtracting 
        leftToRightAddition from rightToLeftAddition. If the difference is negative, it multiplies it by -1 to make it positive. 
        This is because the function needs to return the absolute difference.
    4. Finally, the function returns the absolute difference between the sums of the diagonals.
*/
public static int diagonalDifference(List<List<int>> arr)
{
    int rightToLeftAddition = 0;
    int leftToRightAddition = 0;
    int rightToLeftIndex = arr[0].Count;
    int leftToRightIndex = 0;
    for (int i = 0; i < arr.Count(); i++)
    {
        rightToLeftAddition += arr[i][rightToLeftIndex - 1];
        rightToLeftIndex--;
        leftToRightAddition += arr[i][leftToRightIndex];
        leftToRightIndex++;
    }
    int result = rightToLeftAddition - leftToRightAddition;
    if (result < 0)
    {
        result = result * -1;
    }
    return result;
}
