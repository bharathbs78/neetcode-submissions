public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counter = new();
        int maxCount = 0;
        foreach (int i in nums) {
            if (counter.ContainsKey(i)) {
                counter[i] += 1;

            } else
                counter[i] = 1;
            if (counter[i] > maxCount)
                maxCount = counter[i];
        }
        List<int> result = new();
        Dictionary<int, List<int>> frequencyCounts =
            Enumerable.Range(0, maxCount + 1).ToDictionary(key => key, value => new List<int>());
        foreach (var key in counter.Keys) {
            var value = counter[key];
            frequencyCounts[value].Add(key);
        }
        for (int i = maxCount; i > 0; i--) {
            if (frequencyCounts[i].Count() > 0 && k > 0) {
                result.AddRange(frequencyCounts[i]);
                k-=frequencyCounts[i].Count();
            }
        }
        return result.ToArray();
    }
}
