namespace DoAnCuoiKi
{
    partial class TraDIemThi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bnt_TraCuu = new System.Windows.Forms.Button();
            this.txt_SBD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_Noti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(239, 271);
            this.dataGridView1.TabIndex = 35;
            // 
            // bnt_TraCuu
            // 
            this.bnt_TraCuu.Location = new System.Drawing.Point(209, 40);
            this.bnt_TraCuu.Name = "bnt_TraCuu";
            this.bnt_TraCuu.Size = new System.Drawing.Size(46, 36);
            this.bnt_TraCuu.TabIndex = 34;
            this.bnt_TraCuu.Text = "Tra cứu";
            this.bnt_TraCuu.UseVisualStyleBackColor = true;
            this.bnt_TraCuu.Click += new System.EventHandler(this.bnt_TraCuu_Click);
            // 
            // txt_SBD
            // 
            this.txt_SBD.Location = new System.Drawing.Point(92, 49);
            this.txt_SBD.Name = "txt_SBD";
            this.txt_SBD.Size = new System.Drawing.Size(111, 20);
            this.txt_SBD.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(16, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 53);
            this.label10.TabIndex = 32;
            this.label10.Text = "SỐ BÁO DANH";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Noti
            // 
            this.lbl_Noti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Noti.ForeColor = System.Drawing.Color.Red;
            this.lbl_Noti.Location = new System.Drawing.Point(16, 384);
            this.lbl_Noti.Name = "lbl_Noti";
            this.lbl_Noti.Size = new System.Drawing.Size(239, 44);
            this.lbl_Noti.TabIndex = 36;
            this.lbl_Noti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TraDIemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 457);
            this.Controls.Add(this.lbl_Noti);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bnt_TraCuu);
            this.Controls.Add(this.txt_SBD);
            this.Controls.Add(this.label10);
            this.Name = "TraDIemThi";
            this.Text = "TraDIemThi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bnt_TraCuu;
        private System.Windows.Forms.TextBox txt_SBD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Noti;
    }
}