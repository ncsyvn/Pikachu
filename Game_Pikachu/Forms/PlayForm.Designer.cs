﻿namespace Game_Pikachu
{
    partial class PlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMark = new System.Windows.Forms.Label();
            this.labelHelp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSwapLocation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelContainIcon = new System.Windows.Forms.Panel();
            this.buttonPlayAgain = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.PictureBox();

            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonP1 = new System.Windows.Forms.Button();
            this.buttonP2 = new System.Windows.Forms.Button();
            this.buttonP3 = new System.Windows.Forms.Button();
            this.buttonP4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();

            this.pictureBox1 = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.buttonPlayAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jokerman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Jokerman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(-8, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trợ giúp";
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.BackColor = System.Drawing.Color.Black;
            this.labelMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMark.ForeColor = System.Drawing.Color.Lime;
            this.labelMark.Location = new System.Drawing.Point(20, 117);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(66, 25);
            this.labelMark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);


            this.labelMark.TabIndex = 3;
            this.labelMark.Text = "10.06";
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.BackColor = System.Drawing.Color.Black;
            this.labelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.ForeColor = System.Drawing.Color.Lime;
            this.labelHelp.Location = new System.Drawing.Point(55, 290);
            this.labelHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(29, 31);
            this.labelHelp.TabIndex = 4;
            this.labelHelp.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Jokerman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1, 356);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đổi vị trí";
            // 
            // labelSwapLocation
            // 
            this.labelSwapLocation.AutoSize = true;
            this.labelSwapLocation.BackColor = System.Drawing.Color.Black;
            this.labelSwapLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSwapLocation.ForeColor = System.Drawing.Color.Lime;
            this.labelSwapLocation.Location = new System.Drawing.Point(55, 407);
            this.labelSwapLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSwapLocation.Name = "labelSwapLocation";
            this.labelSwapLocation.Size = new System.Drawing.Size(29, 31);
            this.labelSwapLocation.TabIndex = 6;
            this.labelSwapLocation.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Jokerman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(201, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 49);
            this.label4.TabIndex = 10;
            this.label4.Text = "Time";
            // 
            // progressBarTime
            // 
            this.progressBarTime.BackColor = System.Drawing.Color.DodgerBlue;
            this.progressBarTime.ForeColor = System.Drawing.Color.Gold;
            this.progressBarTime.Location = new System.Drawing.Point(345, 15);
            this.progressBarTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarTime.Maximum = 3000;
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(640, 25);
            this.progressBarTime.Step = 1;
            this.progressBarTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTime.TabIndex = 11;
            this.progressBarTime.Value = 1;
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelContainIcon
            // 
            this.panelContainIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelContainIcon.Location = new System.Drawing.Point(167, 63);
            this.panelContainIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainIcon.Name = "panelContainIcon";
            this.panelContainIcon.Size = new System.Drawing.Size(840, 446);
            this.panelContainIcon.TabIndex = 0;
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlayAgain.Location = new System.Drawing.Point(8, 458);
            this.buttonPlayAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(129, 44);
            this.buttonPlayAgain.TabIndex = 12;
            this.buttonPlayAgain.TabStop = false;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Location = new System.Drawing.Point(993, 6);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(56, 41);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.TabStop = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 

            // buttonP1
            // 
            this.buttonP1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonP1.Location = new System.Drawing.Point(240, 419);
            this.buttonP1.Name = "buttonP1";
            this.buttonP1.Size = new System.Drawing.Size(75, 23);
            this.buttonP1.TabIndex = 14;
            this.buttonP1.UseVisualStyleBackColor = false;
            // 
            // buttonP2
            // 
            this.buttonP2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonP2.Location = new System.Drawing.Point(353, 419);
            this.buttonP2.Name = "buttonP2";
            this.buttonP2.Size = new System.Drawing.Size(75, 23);
            this.buttonP2.TabIndex = 15;
            this.buttonP2.UseVisualStyleBackColor = false;
            // 
            // buttonP3
            // 
            this.buttonP3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonP3.Location = new System.Drawing.Point(459, 419);
            this.buttonP3.Name = "buttonP3";
            this.buttonP3.Size = new System.Drawing.Size(75, 23);
            this.buttonP3.TabIndex = 16;
            this.buttonP3.UseVisualStyleBackColor = false;
            // 
            // buttonP4
            // 
            this.buttonP4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonP4.Location = new System.Drawing.Point(571, 419);
            this.buttonP4.Name = "buttonP4";
            this.buttonP4.Size = new System.Drawing.Size(75, 23);
            this.buttonP4.TabIndex = 17;
            this.buttonP4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(327, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(432, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "->";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepPink;
            this.label7.Location = new System.Drawing.Point(544, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "->";

            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(25, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);

            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonP4);
            this.Controls.Add(this.buttonP3);
            this.Controls.Add(this.buttonP2);
            this.Controls.Add(this.buttonP1);

            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);

            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.progressBarTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSwapLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelContainIcon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlayAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSwapLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox buttonPlayAgain;
        private System.Windows.Forms.PictureBox buttonExit;

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonP1;
        private System.Windows.Forms.Button buttonP2;
        private System.Windows.Forms.Button buttonP3;
        private System.Windows.Forms.Button buttonP4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.PictureBox pictureBox1;

    }
}