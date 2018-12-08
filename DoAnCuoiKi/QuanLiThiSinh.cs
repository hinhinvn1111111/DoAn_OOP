using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class QuanLiThiSinh : Form
    {
        public QuanLiThiSinh()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }

        private void QuanLiThiSinh_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.Instance.GetDanhSachThiSinh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemThiSinh t = new ThemThiSinh();
            this.Hide();
            t.Show();
        }
    }
}
