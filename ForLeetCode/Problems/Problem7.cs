using System;
namespace ForLeetCode
{
    public static class Problem7
    {
        public static int Reverse(int x)
        {
            try
            {
                long result = 0;

                if (x < 10 && x > -10) return x;

                bool isNeg = x < 0;
                if (isNeg) x = x * (-1);

                while (x > 0)
                {
                    result = result * 10;
                    var remain = x % 10;
                    result = (result + remain);
                    x = x / 10;
                }

                return checked((int)(isNeg ? result * (-1) : result));
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}
