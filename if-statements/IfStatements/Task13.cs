namespace IfStatements
{
    public static class Task13
    {
        public static int DoSomething(bool b, int i)
        {
            if (b)
            {
                if (i < -8)
                {
                    return 5 + i;
                }
                else if (i is >= -8 and < -4)
                {
                    return i;
                }
                else if (i is >= -4 and < 0)
                {
                    return 5 + i;
                }
                else if (i == 0)
                {
                    return 10;
                }
                else if (i > 0 && i <= 3)
                {
                    return i - 5;
                }
                else
                {
                    return i * -1;
                }
            }
            else
            {
                if (i <= -5)
                {
                    return i * -1;
                }
                else if (i is > -5 and <= 5)
                {
                    return 10 - i;
                }
                else
                {
                    return i * -1;
                }
            }
        }
    }
}
