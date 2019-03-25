namespace Game_Pikachu
{
    partial class SelectForm
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
            this.buttonStart = new System.Windows.Forms.PictureBox();
            this.buttonContinue = new System.Windows.Forms.PictureBox();
            this.buttonGuide = new System.Windows.Forms.PictureBox();
            this.buttonAbout = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonContinue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGuide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.BackgroundImage = global::Game_Pikachu.Properties.Resources.start2;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Location = new System.Drawing.Point(136, 145);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 45);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.TabStop = false;
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.Transparent;
            this.buttonContinue.BackgroundImage = global::Game_Pikachu.Properties.Resources.continue2;
            this.buttonContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonContinue.Location = new System.Drawing.Point(136, 196);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(120, 42);
            this.buttonContinue.TabIndex = 1;
            this.buttonContinue.TabStop = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonGuide
            // 
            this.buttonGuide.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuide.BackgroundImage = global::Game_Pikachu.Properties.Resources.guide2;
            this.buttonGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGuide.Location = new System.Drawing.Point(138, 240);
            this.buttonGuide.Name = "buttonGuide";
            this.buttonGuide.Size = new System.Drawing.Size(120, 45);
            this.buttonGuide.TabIndex = 2;
            this.buttonGuide.TabStop = false;
            this.buttonGuide.Click += new System.EventHandler(this.buttonGuide_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.BackgroundImage = global::Game_Pikachu.Properties.Resources.about2;
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAbout.Location = new System.Drawing.Point(137, 281);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(120, 45);
            this.buttonAbout.TabIndex = 3;
            this.buttonAbout.TabStop = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::Game_Pikachu.Properties.Resources.exit2;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Location = new System.Drawing.Point(139, 326);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 45);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.TabStop = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Pikachu.Properties.Resources.view;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonGuide);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonStart);
            this.DoubleBuffered = true;
            this.Name = "SelectForm";
            this.Text = "SelectForm";
            ((System.ComponentModel.ISupportInitialize)(this.buttonStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonContinue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGuide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.PictureBox buttonStart;
        private System.Windows.Forms.PictureBox buttonContinue;
        private System.Windows.Forms.PictureBox buttonGuide;
        private System.Windows.Forms.PictureBox buttonAbout;
        private System.Windows.Forms.PictureBox buttonExit;
    }
}