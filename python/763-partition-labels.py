class Solution:
    def partitionLabels(self, s: str) -> List[int]:
        hashmap = {}
        for i in range(len(s)):
            hashmap[s[i]] = i
        
        res = []
        size = 0
        end = 0
        for i in range(len(s)):
            end = max(end, hashmap[s[i]])
            size += 1
            if end == i:
               res.append(size)
               size = 0 
        return res
        