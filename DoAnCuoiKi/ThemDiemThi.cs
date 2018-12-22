using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace DoAnCuoiKi
{
    public partial class ThemDiemThi : Form
    {
        public ThemDiemThi()
        {
            InitializeComponent();
        }
        public int ID = 0;
        List<string> arrMonThi = new List<string>();
        private void ThemDiemThi_Load(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                grbThemThuCong.Visible = false;
                grbImport.Visible = true;
            }
            else
            {
                grbThemThuCong.Visible = true;
                grbImport.Visible = false;
            }

            comboBox1.DataSource = Connect.Instance.GetMonThi_QL();
            comboBox1.DisplayMember = "TenMon";
            comboBox1.ValueMember = "TenMon";
            

        }

        private void btnThemThuCong_Click(object sender, EventArgs e)
        {
            if(Connect.Instance.CheckSBD(txtSBD.Text))
                MessageBox.Show("SBD không đúng !");
            else
            {
                ID = Connect.Instance.GetIDMon_QL(comboBox1.SelectedValue.ToString());
                //MessageBox.Show(ID + " " + comboBox1.Items.Count + "");
                //Connect.Instance.Update_DiemThi(txtSBD.Text, ID, float.Parse(txtĐiểm.Text));
                if (Connect.Instance.CheckThemDiem_QL(txtSBD.Text, ID))
                {
                    Connect.Instance.ThemDiem_QL(txtSBD.Text, ID, float.Parse(txtĐiểm.Text));
                    MessageBox.Show("Thêm thành công !");
                    this.Hide();
                }else MessageBox.Show("Thêm thất bại, thí sinh đã có điểm môn này !");

                //this.Hide();


            }
            
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "(Tất cả các tệp)|*.*|(Tất cả các tệp)|*.xlsx";
            op.ShowDialog();
            if (op.FileName != "")
            {
                int dem = 0;
                lbTenFile.Text = op.FileName;
                //Tạo đối tượng excel
                Excel.Application app = new Excel.Application();
                //Mở tệp excel
                Excel.Workbook wb = app.Workbooks.Open(op.FileName);
                try
                {
                    //Mở sheet
                    Excel._Worksheet sheet = wb.Sheets[1];
                    Excel.Range range = sheet.UsedRange;
                    //Đọc dữ liệu
                    int rows = range.Rows.Count;
                    int clos = range.Columns.Count;
                    //Đọc dòng tiêu đề để tạo cột
                    for (int c = 1; c <= clos; c++)
                    {
                        string clname = range.Cells[1, c].Value.ToString();
                        ColumnHeader col = new ColumnHeader();
                        col.Text = clname;
                        col.Width = 200;
                        //MessageBox.Show(clname);
                        listView1.Columns.Add(col);
                    }
                    for (int i = 2; i <= rows; i++)
                    {


                        ListViewItem item = new ListViewItem();
                        for (int j = 1; j <= clos; j++)
                        {
                            if (j == 1)
                            {
                                item.Text = range.Cells[i, j].Value.ToString();
                            }
                            else
                            {
                                item.SubItems.Add(range.Cells[i, j].Value.ToString());
                            }
                        }
                        listView1.Items.Add(item);
                        //if (Connect.Instance.CheckSBD(range.Cells[i, 2].Value.ToString()))
                        //{
                        //    dem++;
                        //    //MessageBox.Show(range.Cells[i, 2].Value.ToString());
                        //    Connect.Instance.ThemTS(range.Cells[i, 1].Value.ToString(), range.Cells[i, 2].Value.ToString());
                        //}
                        //else
                        //{


                        //    //MessageBox.Show(dem + " dòng không được thêm");
                        //}
                        if (Connect.Instance.CheckThemDiem_QL(range.Cells[i, 1].Value.ToString(),int.Parse(range.Cells[i, 2].Value.ToString())))
                        {
                            dem++;
                            Connect.Instance.ThemDiem_QL(range.Cells[i, 1].Value.ToString(), int.Parse(range.Cells[i, 2].Value.ToString()),float.Parse(range.Cells[i, 3].Value.ToString()));
                            
                        }
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.ToString());
                }

                MessageBox.Show(dem + " dòng thêm thành công vào database", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                grbThemThuCong.Visible = true;
                grbImport.Visible = false;
            }
            else
            {
                grbThemThuCong.Visible = false;
                grbImport.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ID = Connect.Instance.GetIDMon_QL(comboBox1.SelectedValue.ToString());
            //MessageBox.Show(ID + "");
        }
    }
}
