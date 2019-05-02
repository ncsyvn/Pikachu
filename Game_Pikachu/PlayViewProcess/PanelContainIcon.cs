using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Game_Pikachu
{
    public class DrawPanelContainIcon
    {
        #region property
        public Panel panel = new Panel();
        public PictureBox [,] matrixIcon= new PictureBox[100,100];
        public PictureBox[] arrayIcon = new PictureBox[100];
        public int[,] numberMatrixIcon = new int[100, 100];
        public int numberIcon;
        public int[] numberIconArray = new int[100];
        public int[] idIconArray = new int[100];
        #endregion

        #region Random số lượng Icon và số lần xuất hiện mỗi Icon
        // set Random numberIcon
        // Set Random number each Icon, save as array numberIconArray[]
        public void RandomNumberIconArray()
        {
            int sum = 0;
            int tg, i;
            Random rnd = new Random();
            this.numberIcon = rnd.Next(10, 15);
            for (i=0; i<numberIcon; i++)
            {
                tg=rnd.Next(20, 30);
                sum += tg;
                if (sum<252)
                {
                    if (tg % 2 == 1)
                    {
                        tg -= 1;
                        sum -= 1;
                        numberIconArray[i] = tg;
                    }
                    numberIconArray[i] = tg;
                }
                else
                {
                    sum = sum - tg;
                    numberIconArray[i] = 252 - sum;
                    numberIcon = i + 1;
                    break;
                }
            }
        }
        #endregion



        #region Sau khi đã random số lượng Icon, thì random mã Icon cho các Icon đó
        public void RandomIdIcon()
        {
            int i, random;
            RandomNumberIconArray();
            Random rnd = new Random();
            PictureBox[] arrayIconTg = new PictureBox[100];
            for (i = 0; i < 40; i++) arrayIconTg[i] = new PictureBox();
            #region Initial
            
            arrayIconTg[0].BackgroundImage = global::Game_Pikachu.Properties.Resources._31;
            arrayIconTg[1].BackgroundImage = global::Game_Pikachu.Properties.Resources._1;
            arrayIconTg[2].BackgroundImage = global::Game_Pikachu.Properties.Resources._2;
            arrayIconTg[3].BackgroundImage = global::Game_Pikachu.Properties.Resources._3;
            arrayIconTg[4].BackgroundImage = global::Game_Pikachu.Properties.Resources._4;
            arrayIconTg[5].BackgroundImage = global::Game_Pikachu.Properties.Resources._5;
            arrayIconTg[6].BackgroundImage = global::Game_Pikachu.Properties.Resources._6;
            arrayIconTg[7].BackgroundImage = global::Game_Pikachu.Properties.Resources._7;
            arrayIconTg[8].BackgroundImage = global::Game_Pikachu.Properties.Resources._8;
            arrayIconTg[9].BackgroundImage = global::Game_Pikachu.Properties.Resources._9;
            arrayIconTg[10].BackgroundImage = global::Game_Pikachu.Properties.Resources._10;
            arrayIconTg[11].BackgroundImage = global::Game_Pikachu.Properties.Resources._11;
            arrayIconTg[12].BackgroundImage = global::Game_Pikachu.Properties.Resources._12;
            arrayIconTg[13].BackgroundImage = global::Game_Pikachu.Properties.Resources._13;
            arrayIconTg[14].BackgroundImage = global::Game_Pikachu.Properties.Resources._14;
            arrayIconTg[15].BackgroundImage = global::Game_Pikachu.Properties.Resources._15;
            arrayIconTg[16].BackgroundImage = global::Game_Pikachu.Properties.Resources._16;
            arrayIconTg[17].BackgroundImage = global::Game_Pikachu.Properties.Resources._17;
            arrayIconTg[18].BackgroundImage = global::Game_Pikachu.Properties.Resources._18;
            arrayIconTg[19].BackgroundImage = global::Game_Pikachu.Properties.Resources._19;
            arrayIconTg[20].BackgroundImage = global::Game_Pikachu.Properties.Resources._20;
            arrayIconTg[21].BackgroundImage = global::Game_Pikachu.Properties.Resources._21;
            arrayIconTg[22].BackgroundImage = global::Game_Pikachu.Properties.Resources._22;
            arrayIconTg[23].BackgroundImage = global::Game_Pikachu.Properties.Resources._23;
            arrayIconTg[24].BackgroundImage = global::Game_Pikachu.Properties.Resources._24;
            arrayIconTg[25].BackgroundImage = global::Game_Pikachu.Properties.Resources._25;
            arrayIconTg[26].BackgroundImage = global::Game_Pikachu.Properties.Resources._26;

            #endregion

            for (i = 0; i < numberIcon; i++)
            {
                random = rnd.Next(0, 27);
                arrayIcon[i] = new PictureBox();
                arrayIcon[i].BackgroundImage = arrayIconTg[random].BackgroundImage;
                idIconArray[i] = random;
            }
        }
        #endregion

        #region Lưu vào ma trận Icon và mã trận Mã Icon
        public void ProcessRandomIcon(Panel panel)
        {
        
            RandomIdIcon();
            this.panel = panel;
            int i, j, k, tg;
            int[] count = new int[100];
            for (i = 0; i < numberIcon; i++) count[i] = 0;
            Random rnd = new Random();
            for (i=0; i<12; i++)
            {
                for (j=0; j<21; j++)
                {
                    PictureBox icon = new PictureBox();
                    icon.Size = new Size(30, 30);
                    icon.Location = new Point(j * 30, i * 30);
                    icon.BackColor = Color.Transparent;
                    icon.BackgroundImageLayout = ImageLayout.Stretch;
                    matrixIcon[i, j] = icon;
                    matrixIcon[i, j].Click += PictureBox_Click;

                    tg = rnd.Next(0, numberIcon);
                    if (count[tg]<=numberIconArray[tg])
                    {
                        matrixIcon[i, j].BackgroundImage = arrayIcon[tg].BackgroundImage;
                        numberMatrixIcon[i, j] = idIconArray[tg];
                        panel.Controls.Add(matrixIcon[i, j]);
                    }
                    else
                    {
                        for (k = tg; k < numberIcon-1; k++) arrayIcon[k] = arrayIcon[k + 1];
                        numberIcon--;
                    }
                }
            }
        }

        void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.BackgroundImage = null;
        }

        #endregion



    }
}
