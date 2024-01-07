class Solution:
    def findTargetSumWays(self, nums: List[int], target: int) -> int:
        cache = {} # (index, total) -> number of ways

        def backtracking(index: int, total: int) -> int:
            if index == len(nums):
                return 1 if total == target else 0
            if (index, total) in cache:
                return cache[(index, total)]
            
            cache[(index, total)] = (backtracking(index + 1, total + nums[index]) + 
                                    backtracking(index + 1, total - nums[index]))
            return cache[(index, total)]
        return backtracking(0, 0)
        