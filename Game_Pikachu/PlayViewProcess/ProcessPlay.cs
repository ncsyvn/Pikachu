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
        public int CheckColumn(int [,] numberMatrixIcon, PointNew p1, PointNew p2)
        {
            int i;
            for (i = p1.x + 1; i < p2.x; i++) 
                if (numberMatrixIcon[i, p1.y] != 0) return 0;
            return 1;
        }
        #endregion

        #region CheckRow
        public int CheckRow(int[,] numberMatrixIcon, PointNew p1, PointNew p2)
        {
            int i;
            for (i = p1.y + 1; i < p2.y; i++) 
                if (numberMatrixIcon[p1.x, i] != 0) return 0;
            return 1;
        }
        #endregion

        public int FindZigZugRow(int [,] matrixNumberIcon, PointNew p1, PointNew p2)
        {
            // Nếu p1 nằm bên phải p2 thì đổi chỗ để dễ xử lý.
            PointNew ptg = new PointNew();
            if (p1.x>p2.x)
            {
                ptg = p1;
                p1 = p2;
                p2 = ptg;
            }

            // Duyệt lần lượt từ trái sang phải
            PointNew p1tg = new PointNew();
            PointNew p2tg = new PointNew();
            int i;
            for (i = 0; i < 22; i++)
            {
                p1tg.x = i;
                p1tg.y = p1.x;
                p2tg.x = i;
                p2tg.y = p2.y;

                // Kiểm tra 2 điểm góc là 0 hoặc (1 điểm thẳng cột với 1 trong 2 điểm p1, p2 và 1 góc bằng 0)
                if ((matrixNumberIcon[p1tg.x, p1tg.y] == 0 && matrixNumberIcon[p2tg.x, p2tg.y] == 0) ||
                   (p1tg.x == p1.x && matrixNumberIcon[p1tg.x, p1tg.y] == 0) ||
                   (p2tg.x == p2.x && matrixNumberIcon[p2tg.x, p2tg.y] == 0))
                {
                    // Tường hợp p1 cao hơn p2
                    if (CheckColumn(matrixNumberIcon, p1tg, p2tg) == 1 || CheckColumn(matrixNumberIcon, p2tg, p1tg) == 1)
                    {
                        arrayPoint[0] = p1;
                        arrayPoint[1] = p1tg;
                        arrayPoint[2] = p2tg;
                        arrayPoint[3] = p2;
                        // Trường hợp i < p1.x
                        if (i < p1.x)
                        {
                            // Kiểm tra 2 hàng ngang từ p1tg đến p1 và p2tg đến p2
                            if (CheckRow(matrixNumberIcon, p1tg, p1) == 1 && CheckRow(matrixNumberIcon, p2tg, p2) == 1)
                            {
                                return 1;
                            }
                        }

                        // Trường hợp p1.x <i <p2.x
                        else if (p1.x < i && i < p2.x)
                        {
                            // Kiểm tra 2 hàng ngang từ p1 đến p1tg và p2tg đến p2
                            if (CheckRow(matrixNumberIcon, p1, p1tg) == 1 && CheckRow(matrixNumberIcon, p2tg, p2) == 1)
                            {
                                return 1;
                            }
                        }
                        //Trường hợp p2.x<i
                        else if (p2.x < i) 
                        {
                            //Kiểm tra 2 hàng ngang từ p1tg đến p1 và p2 đến p2tg
                            if (CheckRow(matrixNumberIcon, p1tg, p1) == 1 && CheckRow(matrixNumberIcon, p2, p2tg) == 1)
                            {
                                return 1;
                            }
                        }
                        
                        //Trường hợp p1.x = i;
                        else if (p1.x == i)
                        {
                            // Kiểm tra 1 hàng ngang từ p2tg đến p2
                            if (CheckRow(matrixNumberIcon, p1tg, p2) == 1)
                            {
                                arrayPoint[2] = p2;
                                arrayPoint[3] = p2;
                                return 1;
                            }
                        }

                        // Trường hợp p2.x=i
                        else if (p2.x==i)
                        {
                            //Kiểm tra 1 hàng ngang từ p1 đến p1tg
                            if (CheckRow(matrixNumberIcon, p1, p1tg) == 1)
                            {
                                arrayPoint[2] = p2;
                                arrayPoint[3] = p2;
                                return 1;
                            }
                        }

                    }
                }               
            }
            return 0;




        }       
    }
}
