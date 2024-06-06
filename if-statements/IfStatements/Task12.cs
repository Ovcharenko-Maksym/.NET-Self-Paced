namespace IfStatements
{
    public static class Task12
    {
        public static int DoSomething(int i)
        {
            if (i < -8)
            {
                return i * i;
            }
            else if (i is >= -8 and < -5)
            {
                return i;
            }
            else if (i is >= -5 and < 5)
            {
                return (i * i) - i;
            }
            else if (i is >= 5 and < 10)
            {
                return i;
            }
            else
            {
                return 0 - (i * i);
            }
        }
    }
}
