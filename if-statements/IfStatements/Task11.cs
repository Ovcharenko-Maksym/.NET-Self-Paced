namespace IfStatements
{
    public static class Task11
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            var result = i;
            result = (b1 && b2 && i == 0) ? 1 : result;
            result = (b1 && !b2 && i == 0) ? -1 : result;
            result = (b1 && b2 && i >= 4 && i < 8) ? (i * 2) : result;
            result = (b1 && !b2 && i > 3 && i <= 7) ? (10 - (i * 2)) : result;
            result = (b1 && b2 && i < -4 && i >= -8) ? (i * 3) : result;
            result = (b1 && !b2 && i <= -3 && i > -7) ? (10 + (i * 3)) : result;
            result = (!b1 && i == 0) ? 1 : result;
            result = (!b1 && b2 && (i < -8 || i >= 8)) ? (i - (i * i)) : result;
            result = (!b1 && !b2 && (i <= -7 || i > 7)) ? (i - (i * i * i)) : result;
            result = (!b1 && b2 && i != 0 && i > -4 && i <= 4) ? ((i * i) - (i * i * i)) : result;
            result = (!b1 && !b2 && i != 0 && i >= -3 && i < 3) ? ((i * i * i) - (i * i)) : result;
            return result;
        }
    }
}
