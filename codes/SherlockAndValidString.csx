// url: https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem
/* Solution explanation:
    1. Starts by converting the string to a character array and grouping the characters by their occurrence.
    2. It then counts the number of times each character appears and groups these counts.
    3. The result is a list of groups, where each group contains a count and the number of characters that appear that many times. 
        This list is sorted in descending order by the count.
    4. If there are two groups, the function checks if the count in the second group is 1 and the number of characters in that group is also 1.
    5. If this is the case, it returns "YES", because it's possible to remove one occurrence of one character to make all characters appear the same number of times.
    6. Finally, if there are two groups but the previous condition is not met, 
        the function checks the difference between the counts in the two groups and the number of characters in each group. 
        If the difference is not 1 or both groups contain more than one character, it returns "NO",
        because it's not possible to make all characters appear the same number of times by changing just one character.
        Otherwise, it returns "YES".
*/
public static string sherlockAndValidString(string s)
{
    var arr = s.ToCharArray()
         .GroupBy(x => x).Select(key => new { c = key.Key, count = key.Count() })
         .GroupBy(x => x.count).Select(key => new { number = key.Key, count = key.Count() })
         .OrderByDescending(x => x.number).ToList();
    if (arr.Count() > 2) return "NO";
    if (arr.Count() == 1) return "YES";
    if (arr[1].number == 1 && arr[1].count == 1) return "YES";

    var difNumber = Math.Abs(arr[0].number - arr[1].number);
    return difNumber != 1 || (arr[0].count != 1 && arr[1].count != 1) ? "NO" : "YES";
}
