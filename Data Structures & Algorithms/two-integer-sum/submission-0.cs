public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map=new();
        for(int i=0;i<nums.Length;i++){
            if(!map.TryGetValue(target-nums[i], out int value)){
                map.Add(nums[i], i);
            }
            else
                return [value,i];
        }
        return [];
    }
}
