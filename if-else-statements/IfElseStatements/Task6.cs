namespace IfStatements
{
    public static class Task6
    {
        public static int DoSomething(int i)
        {
            if (i == 7)
            {
                return 14;
            }

            if (i == -2)
            {
                return -6;
            }

            if (i < -8)
            {
                return i * i;
            }
            else if (i >= -8 && i < -2)
            {
                return i * 3;
            }
            else if (i >= -2 && i <= 3)
            {
                return (i * 2) + (i * i);
            }
            else if (i > 3 && i <= 7)
            {
                return i * (i - 1) * -1;
            }
            else
            {
                return i * 2;
            }
        }
    }
}
