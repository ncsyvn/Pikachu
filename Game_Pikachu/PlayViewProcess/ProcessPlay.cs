using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Pikachu.PlayViewProcess
{
    public class ProcessPlay
    {
        #region Check Column
        public int CheckColumn(int [,] numberMatrixIcon, int x1, int x2, int y)
        {
            int i;
            for (i = x1 + 1; i < x2; i++) 
                if (numberMatrixIcon[i, y] != 0) return 0;
            return 1;
        }
        #endregion

        #region CheckRow
        public int CheckRow(int[,] numberMatrixIcon, int y1, int y2, int x)
        {
            int i;
            for (i = y1 + 1; i < y2; i++) 
                if (numberMatrixIcon[x, i] != 0) return 0;
            return 1;
        }
        #endregion

    }
}
