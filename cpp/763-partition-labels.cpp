class Solution {
public:
    vector<int> partitionLabels(string s) {
        unordered_map<char, int> hashmap;
        for (int i = 0; i < s.length(); i++) {
            if (hashmap.find(s[i]) == hashmap.end()) {
                hashmap.insert({ s[i], i });
            } else {
                hashmap[s[i]] = i;
            }
        }

        vector<int> res;
        int size = 0;
        int end = 0;
        for (int i = 0; i < s.length(); i++) {
            end = max(end, hashmap[s[i]]);
            size++;

            if (end == i) {
                res.push_back(size);
                size = 0;
            }
        }
        return res;
    }
};