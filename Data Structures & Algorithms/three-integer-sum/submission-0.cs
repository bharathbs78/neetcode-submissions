public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result = new List<List<int>>();
        for (int i = 0; i < nums.Length; i++) {
            int j = i + 1;
            int k = nums.Length - 1;
            if(i>0  && nums[i]==nums[i-1])continue;
            while (j < k) {

                int sum = nums[j] + nums[k];
                if (nums[i] + sum == 0) {
                    result.Add([nums[i], nums[j], nums[k]]);
                    j++;
                    k--;
                    while(j<k && nums[j]==nums[j-1])
                        j++; // need not worry about the rear end as other conditions handle them
                } 
                else if (nums[i] + sum > 0)
                    k--;
                else
                    j++;
            }
        }
        return result;
    }
}
