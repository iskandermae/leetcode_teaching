
namespace Leetcode.Leetcode;

internal class Solution10 {
    public string ConvertToTitle(int columnNumber) {
        //A = 65,  Z = 90
        string rez = "";
        do {
            columnNumber--;
            rez = (char)(columnNumber % 26 + 65) + rez;
            columnNumber = columnNumber / 26;
        } while (columnNumber > 0);
        return rez;
    }
}