using System;
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
            if(txtusn.Text=="" || txtpw.Text == "" || txtpwNhaplai.Text == "")
            {
                MessageBox.Show("Không được để trống");
            }
            else
            {
                usnDK = txtusn.Text;
                pwDK = txtpw.Text;
                if (txtpw.Text != txtpwNhaplai.Text)
                {
                    MessageBox.Show("Password nhập lại không chính xác !");
                }
                else
                {
                    if (Connect.Instance.CheckDangKi())
                        MessageBox.Show("Tài khoản đã được đăng kí !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        int t = Connect.Instance.DangKiTaiKhoan(txtusn.Text.ToString(), txtpw.Text.ToString());
                        if (t == 0)
                        {
                            MessageBox.Show("Thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DangNhap dn = new DangNhap();
                            this.Hide();
                            dn.Show();
                        }
                        else if(t==1)
                            MessageBox.Show("Tài khoản phải dài hơn 3 và ngắn hơn 50 kí tự\nChỉ chứa các kí tự là chữ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Mật khẩu phải dài hơn 3 và ngắn hơn 8 kí tự\nChỉ chứa các kí tự là số !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }
    }
}
