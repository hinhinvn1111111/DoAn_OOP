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
            QuanLiThiSinh ts = new QuanLiThiSinh();
            this.Hide();
            ts.Show();
        }

        private void điểmThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuuDiemThi tc = new TraCuuDiemThi();
            this.Hide();
            tc.Show();
        }

        private void điểmSànToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKeDiemSan ds = new ThongKeDiemSan();
            this.Hide();
            ds.Show();
        }

        private void điểmChuẩnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDiemChuan dc = new ThongKeDiemChuan();
            this.Hide();
            dc.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLi ql = new QuanLi();
            this.Hide();
            ql.Show();
        }
    }
}
