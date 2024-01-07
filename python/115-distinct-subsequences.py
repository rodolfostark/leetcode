class Solution:
    def numDistinct(self, s: str, t: str) -> int:
        cache = {}
        def backtracking(i: int, j: int) -> int:
            if j == len(t):
                return 1
            if i == len(s):
                return 0
            if (i, j) in cache:
                return cache[(i, j)]
            
            if s[i] == t[j]:
                cache[(i, j)] = backtracking(i + 1, j + 1) + backtracking(i + 1, j)
            else:
                cache[(i, j)] = backtracking(i + 1, j)
            return cache[(i, j)]
        return backtracking(0, 0)
