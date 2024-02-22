impl Solution {
    pub fn erase_overlap_intervals(mut intervals: Vec<Vec<i32>>) -> i32 {
        intervals.sort_by(|a, b| a[0].cmp(&b[0]));
        let mut res = 0;
        let mut prev_end = intervals[0][1];
        for i in 1..intervals.len() {
            let (start, end) = (intervals[i][0], intervals[i][1]);
            if start >= prev_end {
                prev_end = end;
            } else {
                res += 1;
                prev_end = prev_end.min(end);
            }
        }
        res
    }
}