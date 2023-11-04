class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        elements = set()
        for i in range(len(nums)):
            if nums[i] not in elements:
                elements.add(nums[i])
            else:
                return True
        return False
        