class Solution:
    def isMatch(self, s: str, p: str) -> bool:
        # top-down memoization
        def memoization(i: int, j: int) -> bool:
            if i >= len(s) and j >= len(p):
                return True
            if j >= len(p):
                return False

            match = i < len(s) and (s[i] == p[j] or p[j] == '.')
            if (j + 1) < len(p) and p[j + 1] == '*':
                return (memoization(i, j + 2) or
                    (match and memoization(i + 1, j)))
            if match:
                return memoization(i + 1, j + 1)
            return False
        return memoization(0, 0)
            
        