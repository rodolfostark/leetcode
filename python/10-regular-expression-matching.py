class Solution:
    def isMatch(self, s: str, p: str) -> bool:
        # top-down memoization cache
        cache = dict()
        def memoization(i: int, j: int) -> bool:
            if (i, j) in cache:
                return cache[(i, j)]
            
            if i >= len(s) and j >= len(p):
                return True
            if j >= len(p):
                return False

            match = i < len(s) and (s[i] == p[j] or p[j] == '.')
            if (j + 1) < len(p) and p[j + 1] == '*':
                cache[(i, j)] = (memoization(i, j + 2) or
                    (match and memoization(i + 1, j)))
                return cache[(i, j)]
            if match:
                cache[(i, j)] = memoization(i + 1, j + 1)
                return cache[(i, j)]
            cache[(i, j)] = False
            return False
        return memoization(0, 0)
