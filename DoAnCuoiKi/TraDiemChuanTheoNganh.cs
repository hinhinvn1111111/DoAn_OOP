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
    public partial class TraDiemChuanTheoNganh : Form
    {
        public TraDiemChuanTheoNganh()
        {
            InitializeComponent();
        }
        hihiEntities context = new hihiEntities();
        private void cbx_Nganh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.DiemChuanTheoNganh(int.Parse(cbx_Nganh.SelectedValue.ToString()));
        }

        private void TraDiemChuanTheoNganh_Load(object sender, EventArgs e)
        {
            cbx_Nganh.DataSource = context.Nganhs.ToList();
            cbx_Nganh.ValueMember = "ID";
            cbx_Nganh.DisplayMember = "TenNganh";
        }
    }
}
