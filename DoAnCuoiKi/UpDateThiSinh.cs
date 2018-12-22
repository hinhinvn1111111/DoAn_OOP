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
    public partial class UpDateThiSinh : Form
    {
        public UpDateThiSinh()
        {
            InitializeComponent();
        }

        private void UpDateThiSinh_Load(object sender, EventArgs e)
        {
            //txtSBD.Text = "";
           
            
        }

        public void GetData(string name,string SBD)
        {
            txtSBD.Text = SBD;
            txtName.Text = name;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSBD.Text == "")
            {
                MessageBox.Show("Sửa thất bại");
            }
            else
            {
                Connect.Instance.Update_ThiSinh(txtName.Text, txtSBD.Text);
                MessageBox.Show("Sửa thành công ");
            }
            
            this.Hide();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
