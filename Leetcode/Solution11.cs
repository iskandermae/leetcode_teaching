
namespace Leetcode.Leetcode;

public class Solution11 {
    public int MySqrt(int x) {

        for(int i = 0; i <= 46340; i++) {
            int x2;

            x2 = checked(i * i);
            if (x2 == x) return i;
            if (x2 > x)  return i - 1;
        }
        return 46340;
    }
}