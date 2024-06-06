namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
        {
            if (b)
            {
                switch (i)
                {
                    case 0: return 10;
                    case 1: return 9;
                    case 2: return 6;
                    case 3: return 1;
                    case 4: return -6;
                    case 5: return 15;
                    case 6: return 16;
                    case 7: return 17;
                    case 8: return 18;
                    case 9: return 19;
                    case 10: return 20;
                    case -1: return 9;
                    case -2: return 6;
                    case -3: return 1;
                    case -4: return -6;
                    case -5: return -15;
                    case -6: return 4;
                    case -7: return 3;
                    case -8: return 2;
                    case -9: return 1;
                    case -10: return 0;
                }
            }
            else
            {
                switch (i)
                {
                    case 0: return 10;
                    case 1: return 9;
                    case 2: return 8;
                    case 3: return 7;
                    case 4: return 6;
                    case 5: return -95;
                    case 6: return -94;
                    case 7: return -93;
                    case 8: return -92;
                    case 9: return -91;
                    case 10: return -90;
                    case -1: return 11;
                    case -2: return 12;
                    case -3: return 13;
                    case -4: return 14;
                    case -5: return 15;
                    case -6: return 16;
                    case -7: return -107;
                    case -8: return -108;
                    case -9: return -109;
                    case -10: return -110;
                }
            }

            return -1;
        }
    }
}
