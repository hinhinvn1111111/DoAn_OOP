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
    public partial class ThemThiSinh : Form
    {
        public ThemThiSinh()
        {
            InitializeComponent();
        }

        private void ThemThiSinh_Load(object sender, EventArgs e)
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
        }

        private void btnThemThuCong_Click(object sender, EventArgs e)
        {       
            if(txtTen.Text=="" ||txtSBD.Text=="")
            {
                MessageBox.Show("không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Connect.Instance.CheckSBD(txtSBD.Text.ToString()))
                {
                    Connect.Instance.ThemTS(txtTen.Text.ToString(), txtSBD.Text.ToString());
                    if (Connect.mes) MessageBox.Show("Không thêm được");
                    else MessageBox.Show("Thêm thành công");
                    txtTen.Text = "";
                    txtSBD.Text = "";
                }
                else
                {
                    MessageBox.Show("SBD bị trùng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
                        col.Width = 120;
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
                        if (Connect.Instance.CheckSBD(range.Cells[i, 2].Value.ToString()))
                        {
                            dem++;
                            //MessageBox.Show(range.Cells[i, 2].Value.ToString());
                            Connect.Instance.ThemTS(range.Cells[i, 1].Value.ToString(), range.Cells[i, 2].Value.ToString());
                        }
                        else
                        {
                            
                            
                            //MessageBox.Show(dem + " dòng không được thêm");
                        }
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.ToString());
                }

                MessageBox.Show(dem + " dòng thêm thành công vào database","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.None);

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
