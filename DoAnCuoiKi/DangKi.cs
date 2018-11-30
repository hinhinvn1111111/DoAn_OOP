﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class DangKi : Form
    {
        public static string usnDK = "";
        public static string pwDK = "";
        
        public DangKi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usnDK = txtusn.Text;
            pwDK = txtpw.Text;
            if (txtpw.Text != txtpwNhaplai.Text)
            {
                MessageBox.Show("Password nhập lại không chính xác !");
            }
            else {
                if (Connect.Instance.CheckDangKi())
                    MessageBox.Show("Tài khoản đã được đăng kí !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Connect.Instance.DangKiTaiKhoan();
                    MessageBox.Show("Thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}