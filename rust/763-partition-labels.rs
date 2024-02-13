use std::collections::HashMap;
use std::cmp;

impl Solution {
    pub fn partition_labels(s: String) -> Vec<i32> {
        let mut hashmap: HashMap<char, usize> = HashMap::new();
        for (i, c) in s.chars().enumerate() {
            hashmap.insert(c, i);
        }
        let mut res: Vec<i32> = Vec::new();
        let mut size = 0;
        let mut end = 0;
        for (i, c) in s.chars().enumerate() {
            end = cmp::max(end, *hashmap.get(&c).unwrap());
            size += 1;

            if end == i {
                res.push(size as i32);
                size = 0;
            }
        }
        res        
    }
}