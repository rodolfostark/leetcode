public class Solution {
    public int Reverse(int x) {
        int reverse = 0;

        while (x != 0) {
           int digit = x % 10;
           x = x / 10;

           if (reverse > Int32.MaxValue / 10 || 
                (reverse == Int32.MaxValue / 10 && digit > 7)) {
                return 0;   
            }

            if (reverse < Int32.MinValue / 10 || 
                (reverse == Int32.MinValue / 10 && digit < -8)) {
                return 0;   
            } 

            reverse = reverse * 10 + digit;
        }
        return reverse;
    }
}