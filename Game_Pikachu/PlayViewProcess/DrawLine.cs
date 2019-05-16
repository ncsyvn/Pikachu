using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game_Pikachu.PlayViewProcess
{
    public class DrawLine
    {
        #region Draw Line Row
        public void DrawLineRow(Panel panel, int[,] numberMatrixIcon, PictureBox [,] matrixIcon, PointNew p1, PointNew p2)
        {
            PictureBox p11 = new PictureBox();
            PictureBox p22 = new PictureBox();
            PictureBox ptg = new PictureBox();
            p11 = matrixIcon[p1.x - 1, p1.y - 1];
            p22 = matrixIcon[p2.x - 1, p2.y - 1];
            if (p11.Location.X > p22.Location.X)
            {
                ptg = p11;
                p11 = p22;
                p22 = ptg;
            }

            PictureBox pictureBox = new PictureBox();
            pictureBox.BackgroundImage = global::Game_Pikachu.Properties.Resources.LineRow;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox.Size = new Size(p22.Location.X - p11.Location.X, 5);
            pictureBox.Location = new Point(p11.Location.X + 15, p11.Location.Y + 15);
            panel.Controls.Add(pictureBox);
        }
        #endregion



        #region Draw Line Column
        public void DrawLineColumn(Panel panel, int[,] numberMatrixIcon, PictureBox[,] matrixIcon, PointNew p1, PointNew p2)
        {
            PictureBox p11 = new PictureBox();
            PictureBox p22 = new PictureBox();
            PictureBox ptg = new PictureBox();
            p11 = matrixIcon[p1.x - 1, p1.y - 1];
            p22 = matrixIcon[p2.x - 1, p2.y - 1];
            if (p11.Location.Y > p22.Location.Y)
            {
                ptg = p11;
                p11 = p22;
                p22 = ptg;
            }

            PictureBox pictureBox = new PictureBox();
            pictureBox.BackgroundImage = global::Game_Pikachu.Properties.Resources.LineRow;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox.Size = new Size(5, p22.Location.Y - p11.Location.Y);
            pictureBox.Location = new Point(p11.Location.X + 15, p11.Location.Y + 15);
            panel.Controls.Add(pictureBox);
        }
        #endregion
    }
}
