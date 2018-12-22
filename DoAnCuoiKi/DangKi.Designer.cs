namespace DoAnCuoiKi
{
    partial class DangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusn = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtpwNhaplai = new System.Windows.Forms.TextBox();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txtusn
            // 
            this.txtusn.Location = new System.Drawing.Point(244, 24);
            this.txtusn.Name = "txtusn";
            this.txtusn.Size = new System.Drawing.Size(205, 32);
            this.txtusn.TabIndex = 3;
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(244, 83);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(205, 32);
            this.txtpw.TabIndex = 4;
            this.txtpw.UseSystemPasswordChar = true;
            // 
            // txtpwNhaplai
            // 
            this.txtpwNhaplai.Location = new System.Drawing.Point(244, 142);
            this.txtpwNhaplai.Name = "txtpwNhaplai";
            this.txtpwNhaplai.Size = new System.Drawing.Size(205, 32);
            this.txtpwNhaplai.TabIndex = 5;
            this.txtpwNhaplai.UseSystemPasswordChar = true;
            // 
            // btnDangKi
            // 
            this.btnDangKi.BackColor = System.Drawing.Color.White;
            this.btnDangKi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangKi.BackgroundImage")));
            this.btnDangKi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDangKi.Location = new System.Drawing.Point(80, 213);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnDangKi.Size = new System.Drawing.Size(124, 38);
            this.btnDangKi.TabIndex = 6;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangKi.UseVisualStyleBackColor = false;
            this.btnDangKi.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(273, 213);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.button2.Size = new System.Drawing.Size(124, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hủy bỏ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(499, 286);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.txtpwNhaplai);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtusn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusn;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txtpwNhaplai;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button button2;
    }
}