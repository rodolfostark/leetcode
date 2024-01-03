public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] cache = new int[nums.Length];
        Array.Fill(cache, 1);
        
        for (int i = nums.Length - 1; i >= 0; i--) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] < nums[j]) {
                    cache[i] = Math.Max(cache[i], 1 + cache[j]);
                }
            }
        }
        return cache.Max();
    }
}