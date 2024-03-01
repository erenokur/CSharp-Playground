// url: https://www.hackerrank.com/challenges/gridland-metro/problem
/*
    Solution explanation:
    1. The grid is represented as a 2D matrix, and each track is represented as a row in the matrix. 
        The Track class represents a track, and the TrackComparer class is used to compare two tracks.
    2. The Track class has three properties: R, C1, and C2, which represent the row number and the start and end column numbers of a track, respectively. 
        The Copy method creates a new Track object with the same properties as the current object.
    3. The TrackComparer class implements the IComparer<Track> interface and overrides the Compare method. 
        This method compares two Track objects based on their R properties (row numbers). 
        If the row numbers are equal, it compares the C1 properties (start column numbers).
    4. The CalculateTrackLength method calculates the total length of all tracks in a list. 
        It iterates over the list and adds the length of each track to a total. 
        The length of a track is calculated as the difference between C2 and C1 plus 1. 
        If a track starts at a column that is greater than the end column of the previous track, 
        it starts a new range with the current track. Otherwise, 
        it extends the end column of the current range to the end column of the current track if it's greater.
    5. The Main method reads the input, sorts the tracks, calculates the total length of the tracks in each row, 
        and subtracts these lengths from the total number of cells in the grid. 
        The result is the total number of cells that are not covered by any tracks.
*/
public class Solution
{
    private class Track
    {
        internal long R, C1, C2;
        internal Track Copy()
        {
            return new Track { R = this.R, C1 = this.C1, C2 = this.C2 };
        }
    }

    private class TrackComparer : IComparer<Track>
    {
        public int Compare(Track t1, Track t2)
        {
            int rDiff = t1.R.CompareTo(t2.R);
            if (rDiff != 0)
            {
                return rDiff;
            }

            return t1.C1.CompareTo(t2.C1);
        }
    }

    public static void Main(String[] args)
    {
        long[] input = Console.ReadLine().Split(' ').Select(s => Convert.ToInt64(s)).ToArray();
        long n = input[0];
        long m = input[1];
        long k = input[2];

        long total = n * m;
        if (k == 0)
        {
            Console.WriteLine(total);
            return;
        }

        Track[] tracks = new Track[k];
        for (int i = 0; i < k; i++)
        {
            long[] trackInput = Console.ReadLine().Split(' ').Select(s => Convert.ToInt64(s)).ToArray();
            tracks[i] = new Track { R = trackInput[0], C1 = trackInput[1], C2 = trackInput[2] };
        }

        Array.Sort(tracks, new TrackComparer());
        List<Track> curRowTracks = new List<Track>() { tracks[0] };
        for (int i = 1; i < tracks.Length; i++)
        {
            if (curRowTracks[curRowTracks.Count - 1].R != tracks[i].R)
            {
                total -= CalculateTrackLength(curRowTracks);
                curRowTracks.Clear();
            }

            curRowTracks.Add(tracks[i]);
        }

        total -= CalculateTrackLength(curRowTracks);
        Console.WriteLine(total);
    }

    private static long CalculateTrackLength(IList<Track> curRowTracks)
    {
        Track range = curRowTracks[0].Copy();
        long total = 0;
        for (int i = 1; i < curRowTracks.Count; i++)
        {
            if (curRowTracks[i].C1 > range.C2)
            {
                total += range.C2 - range.C1 + 1;
                range = curRowTracks[i].Copy();
                continue;
            }

            range.C2 = Math.Max(range.C2, curRowTracks[i].C2);
        }

        total += range.C2 - range.C1 + 1;
        return total;
    }
}
