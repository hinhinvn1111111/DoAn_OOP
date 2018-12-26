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
    public partial class QuanLi : Form
    {
        public QuanLi()
        {
            InitializeComponent();
        }

        private void QuanLi_Load(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(qltk1);
            bunifuTransition4.HideSync(qldc1);
            bunifuTransition2.HideSync(qlts1);
            bunifuTransition1.HideSync(qldt1);
            bunifuTransition1.HideSync(qlds1);
        }

        private void btnThiSinh_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(qltk1);
            bunifuTransition4.HideSync(qldt1);
            bunifuTransition4.HideSync(qldc1);
            bunifuTransition2.ShowSync(qlts1);
         
        }

        private void qlts1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }

        private void btnDiemThi_Click(object sender, EventArgs e)
        {
            bunifuTransition3.HideSync(qlts1);
            bunifuTransition4.HideSync(qldc1);
            bunifuTransition3.HideSync(qlds1);
            bunifuTransition1.HideSync(qltk1);
            bunifuTransition6.ShowSync(qldt1);
        }

        private void btnThiSinh_MouseHover(object sender, EventArgs e)
        {
            //btnThiSinh.Image = System.Drawing.Image.FromFile("E:/Learning/OOP/DoAnCuoiKi/aaaa.png");
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            bunifuTransition3.HideSync(qlds1);
            bunifuTransition4.HideSync(qldc1);
            bunifuTransition3.HideSync(qlts1);
            bunifuTransition3.HideSync(qldt1);
            bunifuTransition4.ShowSync(qltk1);
        }

        private void btnDiemSan_Click(object sender, EventArgs e)
        {
            bunifuTransition3.HideSync(qltk1);
            bunifuTransition4.HideSync(qldc1);
            bunifuTransition3.HideSync(qlts1);
            bunifuTransition3.HideSync(qldt1);
            bunifuTransition4.ShowSync(qlds1);
        }

        private void btnDiemChuan_Click(object sender, EventArgs e)
        {
            bunifuTransition3.HideSync(qltk1);
            bunifuTransition3.HideSync(qlts1);
            bunifuTransition3.HideSync(qldt1);
            bunifuTransition4.HideSync(qlds1);
            bunifuTransition4.ShowSync(qldc1);
        }
    }
}
