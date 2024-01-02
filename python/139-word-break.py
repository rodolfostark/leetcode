class Solution:
    def wordBreak(self, s: str, wordDict: List[str]) -> bool:
        n = len(s)
        cache = [False] * (n + 1)
        cache[n] = True

        for i in range(n - 1, -1, -1):
            for w in wordDict:
                if (i + len(w) <= n and s[i : i+len(w)] == w):
                    cache[i] = cache[i + len(w)]
                if cache[i]:
                    break
        return cache[0]