//url: https://www.hackerrank.com/challenges/compare-the-triplets/problem
public static List<int> compareTriplets(List<int> a, List<int> b)
{
    int aScore = a.Where((alice, index) => alice > b[index]).Count();
    int bScore = b.Where((bob, index) => bob > a[index]).Count();

    return new List<int>() { aScore, bScore };
}