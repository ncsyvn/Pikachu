namespace Game_Pikachu.Forms
{
    partial class FrmGioiThieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGioiThieu));
            this.GrbGioiThieu = new System.Windows.Forms.GroupBox();
            this.Grb_Top = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grb_Fill = new System.Windows.Forms.GroupBox();
            this.Rtb_Fill = new System.Windows.Forms.RichTextBox();
            this.QuayLai = new System.Windows.Forms.Button();
            this.GrbGioiThieu.SuspendLayout();
            this.Grb_Top.SuspendLayout();
            this.Grb_Fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbGioiThieu
            // 
            this.GrbGioiThieu.Controls.Add(this.Grb_Fill);
            this.GrbGioiThieu.Controls.Add(this.groupBox1);
            this.GrbGioiThieu.Controls.Add(this.Grb_Top);
            this.GrbGioiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrbGioiThieu.Location = new System.Drawing.Point(0, 0);
            this.GrbGioiThieu.Name = "GrbGioiThieu";
            this.GrbGioiThieu.Size = new System.Drawing.Size(1104, 733);
            this.GrbGioiThieu.TabIndex = 0;
            this.GrbGioiThieu.TabStop = false;
            // 
            // Grb_Top
            // 
            this.Grb_Top.Controls.Add(this.QuayLai);
            this.Grb_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grb_Top.Location = new System.Drawing.Point(3, 18);
            this.Grb_Top.Name = "Grb_Top";
            this.Grb_Top.Size = new System.Drawing.Size(1098, 57);
            this.Grb_Top.TabIndex = 2;
            this.Grb_Top.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 692);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 38);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Grb_Fill
            // 
            this.Grb_Fill.Controls.Add(this.Rtb_Fill);
            this.Grb_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grb_Fill.Location = new System.Drawing.Point(3, 75);
            this.Grb_Fill.Name = "Grb_Fill";
            this.Grb_Fill.Size = new System.Drawing.Size(1098, 617);
            this.Grb_Fill.TabIndex = 4;
            this.Grb_Fill.TabStop = false;
            // 
            // Rtb_Fill
            // 
            this.Rtb_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rtb_Fill.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtb_Fill.Location = new System.Drawing.Point(3, 18);
            this.Rtb_Fill.Name = "Rtb_Fill";
            this.Rtb_Fill.Size = new System.Drawing.Size(1092, 596);
            this.Rtb_Fill.TabIndex = 0;
            this.Rtb_Fill.Text = resources.GetString("Rtb_Fill.Text");
            // 
            // QuayLai
            // 
            this.QuayLai.Location = new System.Drawing.Point(37, 21);
            this.QuayLai.Name = "QuayLai";
            this.QuayLai.Size = new System.Drawing.Size(132, 30);
            this.QuayLai.TabIndex = 0;
            this.QuayLai.Text = "Quay lại";
            this.QuayLai.UseVisualStyleBackColor = true;
            this.QuayLai.Click += new System.EventHandler(this.QuayLai_Click);
            // 
            // FrmGioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 733);
            this.Controls.Add(this.GrbGioiThieu);
            this.Name = "FrmGioiThieu";
            this.Text = "Giới thiệu";
            this.GrbGioiThieu.ResumeLayout(false);
            this.Grb_Top.ResumeLayout(false);
            this.Grb_Fill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbGioiThieu;
        private System.Windows.Forms.GroupBox Grb_Fill;
        private System.Windows.Forms.RichTextBox Rtb_Fill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Grb_Top;
        private System.Windows.Forms.Button QuayLai;
    }
}