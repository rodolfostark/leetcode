public class Solution {
    public bool CheckValidString(string s) {
        int leftMax = 0;
        int leftMin = 0;

        foreach (char c in s) {
            if (c == '(') {
                leftMax++;
                leftMin++;
            } else if (c == ')') {
                leftMax--;
                leftMin--;
            } else {
                leftMin--;
                leftMax++;
            }

            if (leftMax < 0) {
                return false;
            }
            if (leftMin < 0) {
                leftMin = 0;
            }
        }
        return leftMin == 0;        
    }
}