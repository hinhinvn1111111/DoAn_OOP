namespace DoAnCuoiKi
{
    partial class ThemDiemThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemDiemThi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbImport = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.lbTenFile = new System.Windows.Forms.Label();
            this.grbThemThuCong = new System.Windows.Forms.GroupBox();
            this.btnThemThuCong = new System.Windows.Forms.Button();
            this.txtSBD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtĐiểm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbImport.SuspendLayout();
            this.grbThemThuCong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grbImport
            // 
            this.grbImport.Controls.Add(this.listView1);
            this.grbImport.Controls.Add(this.btnChonFile);
            this.grbImport.Controls.Add(this.lbTenFile);
            this.grbImport.Location = new System.Drawing.Point(15, 82);
            this.grbImport.Name = "grbImport";
            this.grbImport.Size = new System.Drawing.Size(612, 301);
            this.grbImport.TabIndex = 23;
            this.grbImport.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(18, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(575, 198);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(18, 31);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(107, 31);
            this.btnChonFile.TabIndex = 11;
            this.btnChonFile.Text = "Chọn file";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // lbTenFile
            // 
            this.lbTenFile.AutoSize = true;
            this.lbTenFile.ForeColor = System.Drawing.Color.Navy;
            this.lbTenFile.Location = new System.Drawing.Point(159, 35);
            this.lbTenFile.Name = "lbTenFile";
            this.lbTenFile.Size = new System.Drawing.Size(74, 23);
            this.lbTenFile.TabIndex = 10;
            this.lbTenFile.Text = "Tên file";
            // 
            // grbThemThuCong
            // 
            this.grbThemThuCong.Controls.Add(this.comboBox1);
            this.grbThemThuCong.Controls.Add(this.txtĐiểm);
            this.grbThemThuCong.Controls.Add(this.label5);
            this.grbThemThuCong.Controls.Add(this.label3);
            this.grbThemThuCong.Controls.Add(this.btnThemThuCong);
            this.grbThemThuCong.Controls.Add(this.txtSBD);
            this.grbThemThuCong.Controls.Add(this.label2);
            this.grbThemThuCong.Location = new System.Drawing.Point(82, 115);
            this.grbThemThuCong.Name = "grbThemThuCong";
            this.grbThemThuCong.Size = new System.Drawing.Size(463, 268);
            this.grbThemThuCong.TabIndex = 22;
            this.grbThemThuCong.TabStop = false;
            // 
            // btnThemThuCong
            // 
            this.btnThemThuCong.BackColor = System.Drawing.Color.White;
            this.btnThemThuCong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemThuCong.BackgroundImage")));
            this.btnThemThuCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemThuCong.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThemThuCong.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnThemThuCong.FlatAppearance.BorderSize = 2;
            this.btnThemThuCong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemThuCong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThuCong.ForeColor = System.Drawing.Color.Navy;
            this.btnThemThuCong.Location = new System.Drawing.Point(225, 189);
            this.btnThemThuCong.Name = "btnThemThuCong";
            this.btnThemThuCong.Size = new System.Drawing.Size(109, 38);
            this.btnThemThuCong.TabIndex = 10;
            this.btnThemThuCong.Text = "Thêm";
            this.btnThemThuCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemThuCong.UseVisualStyleBackColor = false;
            this.btnThemThuCong.Click += new System.EventHandler(this.btnThemThuCong_Click);
            // 
            // txtSBD
            // 
            this.txtSBD.Location = new System.Drawing.Point(225, 31);
            this.txtSBD.Name = "txtSBD";
            this.txtSBD.Size = new System.Drawing.Size(153, 32);
            this.txtSBD.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(94, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "SBD";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Navy;
            this.radioButton2.Location = new System.Drawing.Point(376, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 27);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Import";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Navy;
            this.radioButton1.Location = new System.Drawing.Point(180, 82);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(152, 27);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Thêm thủ công";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(225, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 36);
            this.label4.TabIndex = 19;
            this.label4.Text = "Thêm điểm thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(94, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Môn";
            // 
            // txtĐiểm
            // 
            this.txtĐiểm.Location = new System.Drawing.Point(225, 132);
            this.txtĐiểm.Name = "txtĐiểm";
            this.txtĐiểm.Size = new System.Drawing.Size(153, 32);
            this.txtĐiểm.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(94, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Điểm";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 31);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ThemDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(639, 420);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbImport);
            this.Controls.Add(this.grbThemThuCong);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemDiemThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ThemDiemThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbImport.ResumeLayout(false);
            this.grbImport.PerformLayout();
            this.grbThemThuCong.ResumeLayout(false);
            this.grbThemThuCong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbImport;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Label lbTenFile;
        private System.Windows.Forms.GroupBox grbThemThuCong;
        private System.Windows.Forms.Button btnThemThuCong;
        private System.Windows.Forms.TextBox txtSBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtĐiểm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}