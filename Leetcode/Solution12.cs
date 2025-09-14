
using System.Linq;

namespace Leetcode.Leetcode;

public class Solution12 {
    Dictionary<int, int> cache = new Dictionary<int, int>();
    public int ClimbStairs(int n) {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        if (n == 2)
            return 2;
        int res = (cache.ContainsKey(n - 1) ? cache[n - 1] : ClimbStairs(n - 1))
                + (cache.ContainsKey(n - 2) ? cache[n - 2] : ClimbStairs(n - 2));
        cache[n] = res;
        return res;
    }
}