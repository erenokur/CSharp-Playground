// url: https://www.hackerrank.com/challenges/queens-attack-2/problem
/*
    1. The function starts by creating a HashSet named obstacleSet to store the obstacles. 
        It uses a helper function GetKey to generate a unique key for each obstacle based on its row and column. 
        The key is a string in the format "row|column".
    2. Define two arrays dRows and dColumns to represent the eight directions a queen can move on a 
        chessboard: up, up-right, right, down-right, down, down-left, left, and up-left.
    3. The function then initializes a counter count to zero. 
        This counter will keep track of the number of squares the queen can attack.
    4. The function uses a loop to check each direction. 
        For each direction, it starts from the square next to the queen and continues in that direction until 
        it hits an obstacle or the edge of the chessboard. If it hits an obstacle, it breaks the loop for that direction. 
        If it doesn't hit an obstacle, it increments count and moves to the next square in that direction.
    5. Finally, the function returns count, which is the total number of squares the queen can attack.
    6. The helper function GetKey takes a row and a column as arguments and returns a string in the format "row|column". 
        This function is used to generate a unique key for each square on the chessboard.
*/
public class Cell
{
    public long row, column;
}

public static int queensAttack(int n, int k, int r_q, int c_q, List<Cell> obstacles)
{
    HashSet<string> obstacleSet = new HashSet<string>();
    foreach (var obstacle in obstacles)
    {
        obstacleSet.Add(GetKey((int)obstacle.row, (int)obstacle.column));
    }

    int[] dRows = { -1, -1, 0, 1, 1, 1, 0, -1 };
    int[] dColumns = { 0, 1, 1, 1, 0, -1, -1, -1 };

    int count = 0;
    for (int i = 0; i < 8; i++)
    {
        int row = r_q + dRows[i];
        int column = c_q + dColumns[i];
        while (row > 0 && row <= n && column > 0 && column <= n)
        {
            if (obstacleSet.Contains(GetKey(row, column)))
            {
                break;
            }
            count++;
            row += dRows[i];
            column += dColumns[i];
        }
    }

    return count;
}

private static string GetKey(int row, int column)
{
    return row.ToString() + "|" + column.ToString();
}