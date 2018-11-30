using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoAnCuoiKi
{
    class Connect
    {
        private static Connect instance;
        public static Connect Instance
        {
            get
            {
                if (instance == null)
                    instance = new Connect();
                return instance;
            }
            private set { instance = value; }
        }
        private Connect() { }
        
        
        public SqlConnection conn;

        public void ConnectDatabase()
        {
            string connectionString = @"Data Source=DESKTOP-7THJV1N;Initial Catalog=DoAnCuoiKiOOP;Integrated Security=True";
            conn = new SqlConnection(connectionString);
        }    
        public Boolean CheckDangNhap()
        {
            ConnectDatabase();
            conn.Open();
            string qr = "Select * from Login where usn = '"+DangNhap.usn+"' and pw = '"+DangNhap.pw+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
            DataTable table = new DataTable();
            DataSet data = new DataSet();
            adapter.Fill(table);
            conn.Close();
            if (table.Rows.Count > 0)
                return true;
            return false;
        }

        public Boolean CheckDangKi()
        {
            ConnectDatabase();
            conn.Open();
            string qr = "Select * from Login where usn = '" + DangKi.usnDK + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
            DataTable table = new DataTable();
            DataSet data = new DataSet();
            adapter.Fill(table);
            conn.Close();
            if (table.Rows.Count > 0)
                return true;
            return false;
        }
        public void DangKiTaiKhoan()
        {
            ConnectDatabase();
            conn.Open();
            string qr = "Insert into Login values('"+DangKi.usnDK+"','"+DangKi.pwDK+"','1')";
            SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
            using (SqlCommand command = new SqlCommand(qr, conn))
            {
                command.ExecuteNonQuery();
            }
            conn.Close();
        }
        public List<string> Checked()
        {
            List<string> arr=new List<string>();
            ConnectDatabase();
            conn.Open();
            string qr = "Select * from Checked";
            SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
            DataTable table = new DataTable();
            DataSet data = new DataSet();
            adapter.Fill(table);
            conn.Close();
            string ischecked = (string)table.Rows[0][0];
            string usn = (string)table.Rows[0][1];
            string pw = (string)table.Rows[0][2];
            arr.Add(ischecked);
            arr.Add(usn);
            arr.Add(pw);
            return arr;
        }

        public void ChangeCheckLogin()
        {
            ConnectDatabase();
            conn.Open();
            string qr = "update Checked set checked = '"+DangNhap.isChecked+"',usn='"+DangNhap.usn+"',pw='"+DangNhap.pw+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
            using (SqlCommand command = new SqlCommand(qr, conn))
            {
                command.ExecuteNonQuery();
            }
            conn.Close();
        }
    }
}
