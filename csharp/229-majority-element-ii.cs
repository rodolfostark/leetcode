public class Solution 
{
    public IList<int> MajorityElement(int[] nums) 
    {
        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach(int num in nums) 
        {
            if (count.ContainsKey(num)) 
            {
                count[num]++;
            } 
            else 
            {
                count[num] = 1;
            }

            if (count.Count <= 2)
            {
                continue;
            }

            Dictionary<int, int> newCount = new Dictionary<int, int>();
            foreach (var kvp in count)
            {
                if (kvp.Value > 1)
                {
                    newCount[kvp.Key] = kvp.Value - 1;
                }
            }

            count = newCount;
        }

        List<int> res = new List<int>();
        foreach (int candidate in count.Keys)
        {
            int freq = 0;
            foreach (int num in nums)
            {
                if (num == candidate)
                {
                    freq++;
                }
            }
            if (freq > nums.Length / 3)
            {
                res.Add(candidate);
            }
        }

        return res;
    }
}