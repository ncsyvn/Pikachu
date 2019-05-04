using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Pikachu.PlayViewProcess
{
    public class ProcessPlay
    {
        public static PointNew[] arrayPoint = new PointNew[4];

        #region Check Column
        public int CheckRow(int [,] numberMatrixIcon, PointNew p1, PointNew p2)
        {
            int i;
            for (i = p1.x + 1; i < p2.x; i++) 
                if (numberMatrixIcon[i, p1.y] != 0) return 0;
            return 1;
        }
        #endregion

        #region CheckRow
        public int CheckColumn(int[,] numberMatrixIcon, PointNew p1, PointNew p2)
        {
            int i;
            for (i = p1.y + 1; i < p2.y; i++) 
                if (numberMatrixIcon[p1.x, i] != 0) return 0;
            return 1;
        }
        #endregion

        // public void FindZigZug(int [,] matrixNumberIcon, int x1, int x2, int y1, int y2)
        public int FindRow(int[,] numberMatrixIcon, PointNew p1, PointNew p2)
        {
            PointNew tg;
            if(p1.x > p2.x)
            {
                tg = p1;
                p1 = p2;
                p2 = tg;
            }
            if (CheckRow(numberMatrixIcon, p1, p2) == 0)
                return 0;
            arrayPoint[0] = p1;
            arrayPoint[1] = p2;
            return 1;
        }
        public int FindColumn(int[,] numberMatrixIcon, PointNew p1, PointNew p2)
        {
            PointNew tg;
            if (p1.y > p2.y)
            {
                tg = p1;
                p1 = p2;
                p2 = tg;
            }
            if (CheckColumn(numberMatrixIcon, p1, p2) == 0)
                return 0;
            arrayPoint[0] = p1;
            arrayPoint[1] = p2;
            return 1;
        }
    }
}
