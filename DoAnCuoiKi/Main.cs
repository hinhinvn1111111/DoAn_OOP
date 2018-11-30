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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.Show();
        }

        private void điểmThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuuDiemThi tc = new TraCuuDiemThi();
            this.Hide();
            tc.Show();
        }
    }
}
