public class Solution {
    public int[][] Merge(int[][] intervals) {
        var sortedIntervals = intervals.Clone() as int[][];
        Array.Sort(sortedIntervals, (a, b) => a[0] - b[0]);

        var mergedIntervals = new List<int[]>();
        var lastInterval = sortedIntervals[0];
        mergedIntervals.Add(lastInterval);

        for (var i = 1; i < sortedIntervals.Length; i++) {
            if (lastInterval[1] >= sortedIntervals[i][0]) {
                lastInterval[1] = Math.Max(lastInterval[1], sortedIntervals[i][1]);
            } else {
                lastInterval = sortedIntervals[i];
                mergedIntervals.Add(lastInterval);
            }
        }
        return mergedIntervals.ToArray();
    }
}