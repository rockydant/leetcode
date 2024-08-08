public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int nums1Pos = m - 1;
        int nums2Pos = n - 1;
        int totalPos = m + n - 1;

        while(nums2Pos >= 0){
            if(nums1Pos >= 0 && nums1[nums1Pos] > nums2[nums2Pos]){
                nums1[totalPos--] = nums1[nums1Pos--];
            }else{
                nums1[totalPos--] = nums2[nums2Pos--];
            }
        }
    }
}