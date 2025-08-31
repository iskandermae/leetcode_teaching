// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string res = Moe.com.Solution1.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });

Console.WriteLine($"Result = {res}");

bool res2 = (new Leetcode.Solution2()).IsValid("{{[]}}()()({[]})");
Console.WriteLine($"Result2_true = {res2}");

bool res2False = (new Leetcode.Solution2()).IsValid("{{[]}}()(}({[]})");
Console.WriteLine($"Result2_false = {res2False}");

bool res2False2 = (new Leetcode.Solution2()).IsValid("}");
Console.WriteLine($"Result2_false = {res2False2}");

int res5 = new Leetcode.Solution5().StrStr2("sadbutsad", "dbu");
Console.WriteLine($"Result5 = {res5}");


int res6 = new Leetcode.Leetcode.Solution6().SearchInsert([1, 3, 5, 6, 10], 8);
Console.WriteLine($"Result6 = {res6}");


int res8 = new Leetcode.Leetcode.Solution8().LengthOfLastWord("luffy is still joyboy");
Console.WriteLine($"Result8 (exp 6) = {res8}");

int[] res9_1 = Leetcode.Leetcode.Solution9.PlusOne(new[] { 1, 3, 5, 6, 9 });
Console.WriteLine($"Result9 (+1) = {string.Join(", ", res9_1)}");


int[] res9_2 = Leetcode.Leetcode.Solution9.PlusOne(new[] { 9, 9, 9 });
Console.WriteLine($"Result9 (+1) = {string.Join(", ", res9_2)}");
