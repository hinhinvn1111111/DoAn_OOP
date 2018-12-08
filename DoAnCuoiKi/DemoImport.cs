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
    public partial class DemoImport : Form
    {
        public DemoImport()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "(Tất cả các tệp)|*.*|(Tất cả các tệp)|*.xlsx";
            op.ShowDialog();
            if (op.FileName != "")
            {
                label1.Text = op.FileName;
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
                    for(int c=1; c <= clos; c++)
                    {
                        string clname = range.Cells[1,c].Value.ToString();
                        ColumnHeader col = new ColumnHeader();
                        col.Text = clname;
                        col.Width = 120;
                        //MessageBox.Show(clname);
                        listView1.Columns.Add(col);
                    }
                    for(int i = 2; i <= rows; i++)
                    {
                        ListViewItem item = new ListViewItem();
                        for(int j = 1; j <= clos; j++)
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
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
