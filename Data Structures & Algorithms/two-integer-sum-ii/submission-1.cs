public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = numbers.Length - 1;
        while (i < j) {
            int result=numbers[i]+numbers[j];
            if (result== target)
                return new int[] { i + 1, j + 1 };
            if(result>target)
                j--;
            else
                i++;
            
        }
        return [];
    }
}
