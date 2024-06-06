namespace IfStatements
{
    public static class Task14
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1 && b2)
            {
                if (i <= -5)
                {
                    return 10 - (i * 2);
                }
                else if (i is > -5 and <= 5)
                {
                    return i * -2;
                }
                else
                {
                    return 10 - (i * 2);
                }
            }
            else if (b1 && !b2)
            {
                if (i <= -5)
                {
                    return i * i * i;
                }
                else if (i is > -5 and <= 5)
                {
                    return i * i;
                }
                else
                {
                    return i * i * i;
                }
            }
            else if (!b1 && b2)
            {
                if (i < -9)
                {
                    return i * -1;
                }
                else if (i is >= -9 and < -7)
                {
                    return i;
                }
                else if (i is >= -7 and < -3)
                {
                    return i * 10;
                }
                else if (i is >= -3 and <= 7)
                {
                    return i;
                }
                else
                {
                    return i * -1;
                }
            }
            else
            {
                if (i < -9)
                {
                    return i * -1;
                }
                else if (i is >= -9 and < -3)
                {
                    return i;
                }
                else if (i is >= -3 and < 0)
                {
                    return i * -100;
                }
                else if (i == 0)
                {
                    return 0;
                }
                else if (i is > 0 and < 5)
                {
                    return i * -100;
                }
                else if (i >= 5 && i <= 7)
                {
                    return i;
                }
                else
                {
                    return i * -1;
                }
            }
        }
    }
}
