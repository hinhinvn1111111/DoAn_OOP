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
    public partial class TraDIemThi : Form
    {
        public TraDIemThi()
        {
            InitializeComponent();
        }
        hihiEntities context = new hihiEntities();

        private void bnt_TraCuu_Click(object sender, EventArgs e)
        {
           
            try
            {
                
                dataGridView1.DataSource = context.TraDiemThi(txt_SBD.Text.ToString().Trim());
                lbl_Noti.Text = "";
           
            }
            catch 
            {
                lbl_Noti.Text = "NHẬP SAI SỐ BÁO DANH";
            }
        }
    }
}
