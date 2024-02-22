public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        var sortedIntervals = intervals.Clone() as int[][];
        Array.Sort(sortedIntervals, (a, b) => a[0] - b[0]);
        
        var result = 0;
        var prevEnd = sortedIntervals[0][1];
        for (var i = 1; i < sortedIntervals.Length; i++) {
            if (sortedIntervals[i][0] >= prevEnd) {
                prevEnd = sortedIntervals[i][1];
            } else {
                result++;
                prevEnd = Math.Min(prevEnd, sortedIntervals[i][1]);
            }
        }
        return result;
    }
}