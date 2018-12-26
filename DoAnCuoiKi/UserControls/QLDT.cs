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
    public partial class QLDT : UserControl
    {
        public QLDT()
        {
            InitializeComponent();
        }

      
        private void QLDT_Load(object sender, EventArgs e)
        {
            cbMon.DataSource = Connect.Instance.GetMonThi_QL();
            cbMon.DisplayMember = "TenMon";
            cbMon.ValueMember = "TenMon";
            dataGridView1.DataSource = Connect.Instance.GetDiemThi_QL(cbMon.SelectedValue.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemDiemThi t = new ThemDiemThi();
            t.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtDiem.Text, @"^[0-10]{1,2}$"))
                MessageBox.Show("Điểm thi không hợp lệ !");
            else
            {
                if (float.Parse(txtDiem.Text) > 10 || float.Parse(txtDiem.Text) < 0)
                {
                    MessageBox.Show("Điểm không hợp lê !");
                }
                else
                {
                    int ID = Connect.Instance.GetIDMon_QL(txtMonThi.Text);
                    Connect.Instance.Update_DiemThi(txtSBD.Text, ID, float.Parse(txtDiem.Text));
                    MessageBox.Show("Thành công");
                    dataGridView1.DataSource = Connect.Instance.GetDiemThi_QL(cbMon.SelectedValue.ToString());
                }
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Bạn có chắc chắn không", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (k == DialogResult.OK)
            {
                int ID = Connect.Instance.GetIDMon_QL(txtMonThi.Text);
                Connect.Instance.Delete_DiemThi(txtSBD.Text,ID);
                MessageBox.Show("Xóa thành công !");
                dataGridView1.DataSource = Connect.Instance.GetDiemThi_QL(cbMon.SelectedValue.ToString());
            }
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //MessageBox.Show(row.Cells["HoTen"].Value.ToString());
            txtTen.Text = row.Cells["HoTen"].Value.ToString();
            txtSBD.Text = row.Cells["SBD"].Value.ToString();
            txtDiem.Text = row.Cells["Diem"].Value.ToString();
            
        }

        private void cbMon_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.Instance.GetDiemThi_QL(cbMon.SelectedValue.ToString());
            txtMonThi.Text = cbMon.SelectedValue.ToString();
            txtTen.Text = "";
            txtSBD.Text = "";
            txtDiem.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.Instance.GetDiemThi_QL(cbMon.SelectedValue.ToString());
        }
    }
}
