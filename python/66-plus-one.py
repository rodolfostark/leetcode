class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        n = len(digits)
        num = 0
        for i in range(n):
            num += digits[i] * (10 ** (n - i - 1))
        num += 1
        res = []
        while num > 0:
            digit = num % 10
            num = num // 10
            res.insert(0, digit)
        return res