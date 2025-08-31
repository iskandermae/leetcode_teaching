
namespace Leetcode.Leetcode;

internal class Solution8 {
    public int LengthOfLastWord(string s) {
        var wordLen = 0;
        for (int i = s.Length-1; i>=0; i--) {
            if (s[i] != ' ')
                wordLen++;
            else {
                if (wordLen > 0) return wordLen;
            }
        }

        return 0;
    }
}