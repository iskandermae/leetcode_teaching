namespace Moe.com {
    public static class Solution1 {
        public static string LongestCommonPrefix(string[] strs) {
            if (strs.Length == 0) {
                return "";
            }

            string firstStr = strs[0];
            if (strs.Length == 1) {
                return firstStr;
            }

            string maxPrefix = "";
            for (int i =0; i < firstStr.Length; i++) {
                char ch = firstStr[i];

                for (int j = 1; j < strs.Length; j++) {
                    if (strs[j].Length < i + 1 || strs[j][i] != ch) {
                        return maxPrefix;
                    }
                }

                maxPrefix += ch;
            }

            return maxPrefix;
        }
    }
}
