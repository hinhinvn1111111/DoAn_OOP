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
    public partial class QLTS : UserControl
    {
        public QLTS()
        {
            InitializeComponent();
        }

        public static string name = "";
        public static string ID = "";

        private void QLTS_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.Instance.GetDanhSachThiSinh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemThiSinh tts = new ThemThiSinh();
            tts.ShowDialog();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(name + ID);
            //Connect.Instance.Update_ThiSinh(name, ID);
            //dataGridView1.DataSource = Connect.Instance.GetDanhSachThiSinh();
            UpDateThiSinh u = new UpDateThiSinh();
            u.GetData(name, ID);
            u.ShowDialog();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Thao tác của bạn sẽ xóa hết tất cả các điểm thí sinh !\nBạn có chắc chắn không", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (k == DialogResult.OK)
            {
                Connect.Instance.Delete_ThiSinh(ID);
                MessageBox.Show("Xóa thành công !");
                dataGridView1.DataSource = Connect.Instance.GetDanhSachThiSinh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //MessageBox.Show(row.Cells["HoTen"].Value.ToString());
            name = row.Cells["HoTen"].Value.ToString();
            ID = row.Cells["SBD"].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.Instance.GetDanhSachThiSinh();
        }
    }
}
