public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int size=nums.Length;
        int [] forwardPass=Enumerable.Repeat(1, size).ToArray();
        int [] reversePass=Enumerable.Repeat(1, size).ToArray();
        int[] result = Enumerable.Repeat(1, size).ToArray();
        if (size == 0)
            return result;
        for (int i =1; i < size; i++) {
            forwardPass[i] = forwardPass[i-1]*nums[i-1];
        }
        for (int i = size - 2; i >= 0; i--) {
            reversePass[i]=reversePass[i+1]*nums[i+1];
        }
        for(int i=0;i<size;i++){
            result[i]=forwardPass[i]*reversePass[i];
        }
        return result;
    }
}
