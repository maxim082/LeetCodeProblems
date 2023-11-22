using System.Linq;

public static class LengthOfLastWord
{
    public static int Calculate(string s){
        return s.Trim().Split(' ').Last().Length;
    }
}