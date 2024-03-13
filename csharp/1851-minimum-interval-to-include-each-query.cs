public class Solution {
    public int[] MinInterval(int[][] intervals, int[] queries) {
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        var minHeap = new SortedSet<(int, int)>(Comparer<(int, int)>.Create((a, b) => a.Item1 != b.Item1 ? a.Item1 - b.Item1 : a.Item2 - b.Item2));
        var res = new Dictionary<int, int>();
        var i = 0;
        foreach (var q in queries.OrderBy(x => x)) {
            while (i < intervals.Length && intervals[i][0] <= q) {
                var l = intervals[i][0];
                var r = intervals[i][1];
                minHeap.Add((r - l + 1, r));
                i++;
            }
            
            while (minHeap.Count > 0 && minHeap.Min.Item2 < q) {
                minHeap.Remove(minHeap.Min);
            }
            res[q] = minHeap.Count > 0 ? minHeap.Min.Item1 : -1;
        }
        return queries.Select(q => res[q]).ToArray();      
    }
}