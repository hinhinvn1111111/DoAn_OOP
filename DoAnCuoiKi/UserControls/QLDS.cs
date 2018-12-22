using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DoAnCuoiKi.UserControls
{
    public partial class QLDS : UserControl
    {
        public QLDS()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void QLDS_Load(object sender, EventArgs e)
        {
            cbTenTruong.DataSource = Connect.Instance.GetDiemSan_ThongKe();
            cbTenTruong.DisplayMember = "TenTruong";
            cbTenTruong.ValueMember = "TenTruong";
            dataGridView1.DataSource = Connect.Instance.GetDiemSan_ThongKe();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //MessageBox.Show(row.Cells["HoTen"].Value.ToString());
            txtTentruong.Text = row.Cells["TenTruong"].Value.ToString();
            txtDiem.Text = row.Cells["Diem"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (float.Parse(txtDiem.Text) > 30 || float.Parse(txtDiem.Text) < 0)
            {
                MessageBox.Show("Điểm không hợp lê !");
            }
            else
            {
                int ID = Connect.Instance.GetIDTruong(txtTentruong.Text);
                Connect.Instance.Update_DiemSan(ID, float.Parse(txtDiem.Text));
                MessageBox.Show("Thành công");
                dataGridView1.DataSource = Connect.Instance.GetDiemSan_ThongKe();
            }

        }
    }
}
