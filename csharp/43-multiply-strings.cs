public class Solution {
    public string Multiply(string num1, string num2) {
        if (num1.Equals("0") || num2.Equals("0")) {
            return "0";
        }

        var result = new int[num1.Length + num2.Length];
        num1 = Reverse(num1);
        num2 = Reverse(num2);

        for (var i = 0; i < num1.Length; i++) {
            for (var j = 0; j < num2.Length; j++) {
                var digit = (num1[i] - '0') * (num2[j] - '0');
                result[i + j] += digit;
                result[i + j + 1] += result[i + j] / 10;
                result[i + j] = result[i + j] % 10;
            }
        }

        Array.Reverse(result);
        var leftZeros = 0;

        while (leftZeros < result.Length && result[leftZeros] == 0) {
            leftZeros++;
        }

        var str = new StringBuilder();
        for (var i = leftZeros; i < result.Length; i++) {
            str.Append(result[i]);
        }
        return str.ToString();
    }
    private string Reverse(string str) {
        var array = str.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}