
namespace Leetcode.Leetcode;

public class Solution7 {
    public int searchInsert(int[] nums, int target) {
        int smallerThenTargetI = 0;
        int greaterThenTargetI = nums.Length - 1;
        if (target <= nums[0]) {
            return 0;
        }

        if (target > nums[greaterThenTargetI]) {
            return nums.Length;
        }

        while (true) {

            if (greaterThenTargetI - smallerThenTargetI == 1) {
                if (target <= nums[smallerThenTargetI])
                    return smallerThenTargetI;
                if (target <= nums[greaterThenTargetI])
                    return greaterThenTargetI;
                if (target > nums[greaterThenTargetI])
                    return greaterThenTargetI + 1;
            }

            int middleI = (greaterThenTargetI + smallerThenTargetI) / 2;

            if (nums[middleI] > target) {
                greaterThenTargetI = middleI;
                continue;
            }

            if (nums[middleI] < target) {
                smallerThenTargetI = middleI;
                continue;
            }

            return middleI;
        }
    }
}
