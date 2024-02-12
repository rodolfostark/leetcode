public class Solution {
    public IList<int> PartitionLabels(string s) {
        Dictionary<char, int> hashmap = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            if (!hashmap.ContainsKey(s[i])) {
                hashmap.Add(s[i], i);
            }
            hashmap[s[i]] = i;
        }
        
        List<int> res = new List<int>();
        int size = 0;
        int end = 0;
        for (int i = 0; i < s.Length; i++) {
            end = Math.Max(end, hashmap[s[i]]);
            size++;

            if (end == i) {
                res.Add(size);
                size = 0;
            }
        }
        return res;   
    }
}