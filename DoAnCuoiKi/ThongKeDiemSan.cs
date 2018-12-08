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
    public partial class ThongKeDiemSan : Form
    {
        public ThongKeDiemSan()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }

        private void ThongKeDiemSan_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            label1.Text = "Điểm sàn các trường Đại học " + year + "";
            dataGridView1.DataSource = Connect.Instance.GetDiemSan_ThongKe();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
