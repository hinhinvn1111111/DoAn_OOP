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
    public partial class DangNhap : Form
    {
        public static string usn = "";
        public static string pw = "";       
        public static string isChecked = "0";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            DangKi dk = new DangKi();
            this.Hide();
            dk.Show();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult k = MessageBox.Show("Bạn có chắc chắn không ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (k == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usn = txtusn.Text;
            pw = txtpw.Text;
            if (Connect.Instance.CheckDangNhap())
            {
                Main tc = new Main();
                this.Hide();
                tc.Show();
            }
            else MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            Connect.Instance.ChangeCheckLogin();

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtusn.Text = "";
            txtpw.Text = "";
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            List<string> arr = new List<string>();
            arr = Connect.Instance.Checked();
            if (int.Parse(arr[0]) == 1)
            {
                cbNhoDangNhap.Checked = true;
                txtusn.Text = arr[1];
                txtpw.Text = arr[2];
            }
        }

        private void cbNhoDangNhap_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNhoDangNhap.Checked == true)
            {
                isChecked = "1";
                
            }
            else
            {
                isChecked = "0";
            }
            usn = txtusn.Text;
            pw = txtpw.Text;
            //Connect.Instance.ChangeCheckLogin();
        }
    }
}
