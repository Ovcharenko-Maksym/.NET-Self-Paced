namespace IfStatements
{
    public static class Task4
    {
        public static int DoSomething(bool b1, bool b2, bool b3, bool b4)
        {
            if (!b1 && !b2 && !b3 && !b4)
            {
                return 5;
            }
            else if (b1 && !b2 && !b3 && !b4)
            {
                return 2;
            }
            else if (!b1 && b2 && !b3 && !b4)
            {
                return 5;
            }
            else if (b1 && b2 && !b3 && !b4)
            {
                return 2;
            }
            else if (!b1 && !b2 && b3 && !b4)
            {
                return 6;
            }
            else if (b1 && !b2 && b3 && !b4)
            {
                return 3;
            }
            else if (!b1 && b2 && b3 && !b4)
            {
                return 6;
            }
            else if (b1 && b2 && b3 && !b4)
            {
                return 2;
            }
            else if (!b1 && !b2 && !b3 && b4)
            {
                return 8;
            }
            else if (b1 && !b2 && !b3 && b4)
            {
                return 1;
            }
            else if (!b1 && b2 && !b3 && b4)
            {
                return 5;
            }
            else if (b1 && b2 && !b3 && b4)
            {
                return 1;
            }
            else if (!b1 && !b2 && b3 && b4)
            {
                return 7;
            }
            else if (b1 && !b2 && b3 && b4)
            {
                return 4;
            }
            else if (!b1 && b2 && b3 && b4)
            {
                return 6;
            }
            else
            {
                return 1;
            }
        }
    }
}
