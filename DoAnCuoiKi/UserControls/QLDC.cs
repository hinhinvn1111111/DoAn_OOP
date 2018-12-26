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
    public partial class QLDC : UserControl
    {
        public QLDC()
        {
            InitializeComponent();
        }
        //hihiEntities a = new hihiEntities();
        private void QLDC_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Connect.Instance.GetTenTruong();
            //comboBox1.DataSource = a.Truongs.ToList();
            comboBox1.ValueMember = "TenTruong";
            comboBox1.DisplayMember = "TenTruong";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.Instance.GetDiemChuan(comboBox1.SelectedValue.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //MessageBox.Show(row.Cells["HoTen"].Value.ToString());
            txtTentruong.Text = row.Cells["TenNganh"].Value.ToString();
            txtDiem.Text = row.Cells["Khoi"].Value.ToString();
            textBox1.Text = row.Cells["Diem"].Value.ToString();
        }
    }
}
