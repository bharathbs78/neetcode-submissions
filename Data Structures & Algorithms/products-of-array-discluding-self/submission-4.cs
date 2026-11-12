public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int size = nums.Length;
        int[] result = new int[size];
        if (size == 0)
            return result;
        int left = 1;
        for (int i = 0; i < size; i++) {
            result[i]=1;
            result[i] *= left;
            left *= nums[i];
        }
        int right=1;
        for (int i = size - 1; i >= 0; i--) {
            result[i]*=right;
            right*=nums[i];
        }

        return result;
    }
}
