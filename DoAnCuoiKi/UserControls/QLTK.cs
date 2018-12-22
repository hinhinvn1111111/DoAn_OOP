using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi.UserControls
{
    public partial class QLTK : UserControl
    {
        public QLTK()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //groupBox1.Visible = true;
            //groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            txtusn.Text = lbusn.Text;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            
            DialogResult k = MessageBox.Show("Bạn có chắc chắn không ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (k == DialogResult.OK)
            {
                Connect.Instance.Update_MatKhau(txtusn.Text,txtpw.Text);
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            lbpw.Text = txtpw.Text;
            txtpw.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void QLTK_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            lbusn.Text = DangNhap.usn;
            lbpw.Text = DangNhap.pw;
        }
    }
}
