class Solution:
    def canPartition(self, nums: List[int]) -> bool:
        total = sum(nums)
        if total % 2 != 0:
            return False
        
        cache = set()
        cache.add(0)
        target = total // 2

        for i in range(len(nums) - 1, -1, -1):
            next_cache = set()
            for t in cache:
                if (t + nums[i]) == target:
                    return True
                next_cache.add(t + nums[i])
                next_cache.add(t)
            cache = next_cache
        return False
        