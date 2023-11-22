using System;

namespace LeetCode.Problems;

public class PalindromeInteger
{
    public static bool IsPalindrome(int x)
    {

        if (x < 0) return false;
        if (x < 10) return true;

        var stringValue = x.ToString();

        for (x = 0; x < stringValue.Length / 2; x++)
        {
            if (stringValue[x] != stringValue[stringValue.Length - 1 - x]) return false;
        }

        return true;
    }
}