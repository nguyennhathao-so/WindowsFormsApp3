namespace WindowsFormsApp3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label2 = new System.Windows.Forms.Label();
            this.button_lognIn = new System.Windows.Forms.Button();
            this.button_lognUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "DANH SÁCH HÀNG HÓA ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_lognIn
            // 
            this.button_lognIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_lognIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lognIn.Location = new System.Drawing.Point(738, 40);
            this.button_lognIn.Name = "button_lognIn";
            this.button_lognIn.Size = new System.Drawing.Size(141, 44);
            this.button_lognIn.TabIndex = 3;
            this.button_lognIn.Text = "ĐĂNG NHẬP ";
            this.button_lognIn.UseVisualStyleBackColor = false;
            this.button_lognIn.Click += new System.EventHandler(this.buttom1_dangnhap);
            // 
            // button_lognUp
            // 
            this.button_lognUp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_lognUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lognUp.Location = new System.Drawing.Point(899, 40);
            this.button_lognUp.Name = "button_lognUp";
            this.button_lognUp.Size = new System.Drawing.Size(97, 44);
            this.button_lognUp.TabIndex = 4;
            this.button_lognUp.Text = "ĐĂNG KÍ ";
            this.button_lognUp.UseVisualStyleBackColor = false;
            this.button_lognUp.Click += new System.EventHandler(this.buttom1_dangki);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-18, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 582);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_lognIn);
            this.panel2.Controls.Add(this.button_lognUp);
            this.panel2.Location = new System.Drawing.Point(203, -15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 123);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources._1601460671Shoppo_Logo;
            this.pictureBox1.InitialImage = global::WindowsFormsApp3.Properties.Resources._1601460671Shoppo_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(17, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(76, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Shoppo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1236, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Shoppo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_lognIn;
        private System.Windows.Forms.Button button_lognUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}