
using System.Linq;

namespace Leetcode.Leetcode;

public class Solution13 {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] res = new int[m + n];
        int next = 0;
        int c1 = 0;
        int c2 = 0;

        while (true) {
            (int mm, c1, c2, bool end) = GetMin(nums1, nums2, c1, c2, m, n);
            if (end) {
                break;
            }
            res[next] = mm;
            next++;
        };
        for (int i = 0; i < n + m; i++) {
            nums1[i] = res[i];
        }
    }

    private (int mm, int c1, int c2, bool end) GetMin(int[] nums1, int[] nums2, int c1, int c2, int m, int n) {
        if (c1 == m && c2 == n) 
             { return (0, c1, c2, true); }
        if (c1 == m || c2 != n && nums1[c1] >= nums2[c2]) { 
            return (nums2[c2], c1, c2 + 1, false);
        }
        return (nums1[c1], c1 + 1, c2, false);
    }
}
