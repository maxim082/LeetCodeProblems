using System.Text;

namespace ForLeetCode
{
    public static class Problem6
    {
        public static string Convert(string s, int numRows)
        {
            var sLength = s.Length;
            if (numRows == 1 || numRows > sLength) return s;

            var result = new StringBuilder();
            int columnsCount = sLength / (numRows + numRows - 2) * (numRows - 1);
            int notFullColumns = sLength % (numRows + numRows - 2) > numRows ? sLength % (numRows + numRows - 2) - numRows + 1 : 1;
            var subResult = new char[numRows, columnsCount + notFullColumns];

            int x = 0;
            int y = 0;
            bool isFullRow = true;

            for (int i = 0; i < sLength; i++)
            {
                subResult[y, x] = s[i];

                if (isFullRow && y < numRows - 1) { y++; }
                else if (isFullRow && y == numRows - 1 || !isFullRow && y > 0) { y--; x++; isFullRow = false; }
                else if (!isFullRow && y == 0) { y++; isFullRow = true; }
            }

            for (int y1 = 0; y1 <= subResult.GetUpperBound(0); y1++)
            {
                for (int i = 0; i <= subResult.GetUpperBound(1); i++)
                {
                    if (subResult[y1, i] != '\0')
                        result.Append(subResult[y1, i]);
                }
            }

            return result.ToString();
        }
    }
}
