impl Solution {
    pub fn is_happy(mut n: i32) -> bool {
        loop {
            let mut sum = 0;
            while n > 0 {
                sum += (n % 10).pow(2);
                n = n / 10;
            }
            match sum {
                1 | 4 => break sum == 1,
                _ => n = sum,
            }
        }
    }
}