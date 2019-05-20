namespace Game_Pikachu.Forms
{
    partial class FormHuongDan
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonGuide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGuide)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(748, 334);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonGuide
            // 
            this.buttonGuide.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuide.BackgroundImage = global::Game_Pikachu.Properties.Resources.guide2;
            this.buttonGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGuide.Location = new System.Drawing.Point(329, 12);
            this.buttonGuide.Name = "buttonGuide";
            this.buttonGuide.Size = new System.Drawing.Size(120, 45);
            this.buttonGuide.TabIndex = 18;
            this.buttonGuide.TabStop = false;
            // 
            // FormHuongDan
            // 
            this.BackgroundImage = global::Game_Pikachu.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 409);
            this.Controls.Add(this.buttonGuide);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FormHuongDan";
            ((System.ComponentModel.ISupportInitialize)(this.buttonGuide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox buttonGuide;
    }
}