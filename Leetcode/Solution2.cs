
namespace Leetcode ;

public class Solution2 {
    public bool IsValid(string s) {
        var chars = new Stack<char>();
        var openToClose = new Dictionary<char, char> { { '{', '}' }, { '(', ')' }, { '[', ']' } };

        foreach (char ch in s) {
            if (openToClose.Keys.Contains(ch)) {
                chars.Push(ch);
                continue;
            }

            if (!chars.TryPop(out char curr)) {
                return false;
            }

            char expected = openToClose[curr];
            if (ch != expected) {
                return false;
            }
        }

        return chars.Count == 0;
    }
}

