using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.ParamonovaVA.Sprint2.Task2.V3.Lib
{
   
        public class DataService : ISprint2Task2V3
        {
            public bool CheckDotInShadedArea(int x, int y)
            {
                if ((3 <= x & x <= 5) && (3 <= y & y <= 5))
                    return true;
                else if ((9 <= x & x <= 10) && (3 <= y & y <= 8))
                    return true;
                else if ((x == 7 || x == 8) && (5 <= y & y <= 12))
                    return true;
                else if ((11 <= x & x <= 12) && (6 <= y & y <= 13))
                    return true;
                else if ((4 <= x & x <= 6) && (y == 9))
                    return true;
                else if ((x == 4) && (9 <= y & y <= 13))
                    return true;
                else if ((x == 13) && (6 <= y & y <= 8))
                    return true;
                else if ((x == 13) && (11 <= y & y <= 13))
                    return true;
                else if ((x == 11 || x == 12) && (y == 3))
                    return true;
                else if (x == 6 && y == 5)
                    return true;
                else if (x == 7 && y == 13)
                    return true;
                else if (x == 3 && y == 11)
                    return true;
                else
                {
                    return false;
                }
            }
        }
    }

