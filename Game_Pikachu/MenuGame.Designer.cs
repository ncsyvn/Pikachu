﻿namespace Game_Pikachu
{
    partial class MenuGame
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(384, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(457, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "NEW GAME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(384, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(457, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "RESUME";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(384, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(457, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "HELP";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(384, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(457, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "QUIT GAME";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // MenuGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 629);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MenuGame";
            this.Text = "MenuGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}