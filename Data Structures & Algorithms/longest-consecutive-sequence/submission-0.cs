public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hs=new HashSet<int>(nums);
        int maxLength=0;
        foreach(var num in nums){
            if(hs.Contains(num-1))
            continue;
            int length=1;
            while(hs.Contains(num+length))
                length++;
            maxLength=Math.Max(length,maxLength);
        }
        return maxLength;
    }
}
