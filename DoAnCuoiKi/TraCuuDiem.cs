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
    public partial class TraCuuDiemThi : Form
    {
        public TraCuuDiemThi()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.Show();
        }
    }
}
