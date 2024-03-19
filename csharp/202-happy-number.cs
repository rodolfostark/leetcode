public class Solution {
    public bool IsHappy(int n) {
        var visit = new HashSet<int>();
        
        while (!visit.Contains(n)) {
            visit.Add(n);
            n = SumOfSquares(n);
            if (n == 1) {
                return true;
            }
        }
        return false;
    }
    private int SumOfSquares(int n) {
        int sum = 0;

        while (n > 0) {
            int digit = n % 10;
            sum += digit * digit;
            n = n / 10;
        }
        return sum;
    }
}