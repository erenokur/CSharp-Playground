// url: https://www.hackerrank.com/challenges/encryption/problem
/* Solution explanation: 
    1. The function starts by converting the input string to a character array arr. 
        It then initializes an empty string encrypted to hold the encrypted string.
    2. Calculate the length of the segments, which is the ceiling of the square root of the length of arr. 
        This length is stored in lebar.
    3. The function then uses a nested loop to encrypt the string. 
        The outer loop iterates over each position in a segment, and the inner loop iterates over each segment. 
        For each position in each segment, it appends the character at that position to encrypted.
    4. Before appending a character, the function checks if encrypted is not empty. 
        If it's not, it adds a space to encrypted. This ensures that there's a space between the characters from different segments.
*/

public static string encryption(string s)
{
    char[] arr = s.ToCharArray();
    string encrypted = "";
    int lebar = (int)Math.Ceiling(Math.Sqrt(arr.Length));

    for (int i = 0; i < lebar; i++)
    {
        if (!string.IsNullOrEmpty(encrypted))
        {
            encrypted += " ";
        }

        for (int j = i; j < arr.Length; j += lebar)
        {
            encrypted += arr[j];
        }
    }

    return encrypted;
}
