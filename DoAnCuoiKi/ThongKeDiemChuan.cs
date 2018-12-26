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
    public partial class ThongKeDiemChuan : Form
    {
        public ThongKeDiemChuan()
        {
            InitializeComponent();
        }
        //hihiE a = new hihiE();
        hihiEntities a = new hihiEntities();
        public static string Truong = "";

        private void ThongKeDiemChuan_Load(object sender, EventArgs e)
        {
            int y = DateTime.Now.Year;
            label1.Text = "Điểm chuẩn Đại học "+y+"";
            comboBox1.DataSource = a.Truongs.ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "TenTruong";
            dataGridView1.DataSource = a.TraDiemChuan(int.Parse(comboBox1.SelectedValue.ToString()));
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.Text);
            Truong = comboBox1.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           dataGridView1.DataSource = a.TraDiemChuan(int.Parse(comboBox1.SelectedValue.ToString()));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }
        
    }
}
