impl Solution {
    pub fn merge(mut intervals: Vec<Vec<i32>>) -> Vec<Vec<i32>> {
        intervals.sort_by(|a, b| a[0].cmp(&b[0]));
        let res = vec![intervals.first().unwrap().clone()];
        intervals.into_iter().skip(1).fold(res, |mut res, curr| {
            let last = res.last().unwrap();
            if curr[0] <= last[1] {
                res.last_mut().unwrap()[1] = last[1].max(curr[1]);
            } else {
                res.push(curr)
            }
            res
        })
    }
}