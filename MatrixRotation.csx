// url: https://www.hackerrank.com/challenges/matrix-rotation-algo/problem
/* Solution explanation: 
    1. The function starts by getting the number of rows (m) and columns (n) in the matrix. 
        It then calculates the number of layers in the matrix, which is half of the minimum of m and n. 
        This is because the rotation happens layer by layer, starting from the outermost layer (or ring) and moving towards the center. 
    2. The outer loop iterates over each layer. 
        For each layer, it calculates the number of rotations needed, which is r modulo the perimeter of the current layer. 
        The perimeter is calculated as twice the sum of the number of rows and columns, 
        minus 4 times the current layer number (to account for the already processed outer layers). 
    3. The inner loop performs the rotations. It rotates the elements in the top row, 
        right column, bottom row, and left column of the current layer one step at a time. 
        It uses a temporary variable temp to store the first element of the top row before shifting the other elements.
    4. After all rotations are done, the function prints the matrix. It iterates over each element in the matrix and prints it.
*/

public static void matrixRotation(List<List<int>> matrix, int r)
{
    int m = matrix.Count;
    int n = matrix[0].Count;
    int numLayers = Math.Min(m, n) / 2;

    for (int layer = 0; layer < numLayers; layer++)
    {
        int rotations = r % (2 * (m + n - 2 - 4 * layer));
        while (rotations > 0)
        {
            // Top row
            int temp = matrix[layer][layer];
            for (int j = layer; j < n - 1 - layer; j++)
                matrix[layer][j] = matrix[layer][j + 1];

            // Right column
            for (int i = layer; i < m - 1 - layer; i++)
                matrix[i][n - 1 - layer] = matrix[i + 1][n - 1 - layer];

            // Bottom row
            for (int j = n - 1 - layer; j > layer; j--)
                matrix[m - 1 - layer][j] = matrix[m - 1 - layer][j - 1];

            // Left column
            for (int i = m - 1 - layer; i > layer + 1; i--)
                matrix[i][layer] = matrix[i - 1][layer];

            matrix[layer + 1][layer] = temp;

            rotations--;
        }
    }

    // printing the matrix
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i][j]);
            if (j != n - 1)
                Console.Write(" ");
        }

        if (i != m - 1)
            Console.WriteLine();
    }
}
