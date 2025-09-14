// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


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

string res10 = new Leetcode.Leetcode.Solution10().ConvertToTitle(701);

Console.WriteLine($"Result9 (ZY) = {string.Join(", ", res10)}");
string res102 = new Leetcode.Leetcode.Solution10().ConvertToTitle(1);
Console.WriteLine($"Result9 (A) = {string.Join(", ", res102)}");
string res103 = new Leetcode.Leetcode.Solution10().ConvertToTitle(2);
Console.WriteLine($"Result9 (B) = {string.Join(", ", res103)}");
string res104 = new Leetcode.Leetcode.Solution10().ConvertToTitle(26);
Console.WriteLine($"Result9 (Z) = {string.Join(", ", res104)}");
string res105 = new Leetcode.Leetcode.Solution10().ConvertToTitle(27);
Console.WriteLine($"Result9 (AA) = {string.Join(", ", res105)}");

int res11 = new Leetcode.Leetcode.Solution11().MySqrt(2147483647-1);
Console.WriteLine($"Result11 = {string.Join(", ", res11)}");
int i = 100000;
Console.WriteLine($"{2147483647} {Math.Sqrt(2147483647)}");


Console.WriteLine($"time {DateTime.Now}");
Console.WriteLine($"{new Leetcode.Leetcode.Solution12().ClimbStairs(47)}");
Console.WriteLine($"time {DateTime.Now}");


Console.WriteLine($"{new Leetcode.Leetcode.Solution14().Run()}");
