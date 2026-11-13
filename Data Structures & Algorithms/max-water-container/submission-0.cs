public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea=0;
        int i=0;
        int j=heights.Length-1;
        while(i<j){
            int area=Math.Min(heights[i], heights[j])*(j-i);
            maxArea=Math.Max(area,maxArea);
            if(heights[i]>heights[j])
                j--;
            else if( heights[i]<heights[j])
                i++;
            else{
                i++;
                j--;
            }
        }
        return maxArea;
    }
}
