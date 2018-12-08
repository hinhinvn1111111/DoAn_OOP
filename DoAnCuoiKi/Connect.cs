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

        public int year = DateTime.Now.Year;

        public static Boolean mes = false;
        

        public void ConnectDatabase()
        {
            string connectionString = @"Data Source=DESKTOP-7THJV1N;Initial Catalog=DA_OOP;Integrated Security=True";
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
        public void DangKiTaiKhoan(string usn,string pw)
        {
            ConnectDatabase();
            conn.Open();
            string qr = "Insert into Login (usn,pw,ID_Role) values(@usn,@pw,@ID_role)";
            //SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
            using (SqlCommand command = new SqlCommand(qr, conn))
            {
                command.Parameters.AddWithValue("@usn", usn);
                command.Parameters.AddWithValue("@pw", pw);
                command.Parameters.AddWithValue("@ID_role", "1");
                command.ExecuteNonQuery();
            }
            conn.Close();
        }
        public List<string> Checked()
        {
            List<string> arr=new List<string>();
            ConnectDatabase();
            conn.Open();
            try
            {
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
            }
            catch(Exception ex)
            {
                throw new Exception("Error" + ex.ToString());
            }
            
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
        public DataTable GetDiemSan_ThongKe()
        {
            ConnectDatabase();
            conn.Open();
            DataTable table = new DataTable();
            try
            {
                string qr = "select t.TenTruong,ds.Diem from DiemSan as ds,Truong as t ,NamTuyenSinh as n where ds.ID_Truong = t.ID and ds.ID_Nam=n.ID and n.Nam="+year+"";
                SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                DataSet data = new DataSet();
                adapter.Fill(table);
            }
            catch(Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }
            
            conn.Close();
            return table;
        }

        public DataTable GetTenTruong()
        {
            ConnectDatabase();
            conn.Open();
            DataTable table = new DataTable();
            try
            {
                string qr = "select * from Truong";
                SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                DataSet data = new DataSet();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            conn.Close();
            return table;
        }

        public DataTable GetTenDiemChuan_ThongKe()
        {
            ConnectDatabase();
            conn.Open();
            DataTable table = new DataTable();
            try
            {
                string qr = "select n.TenNganh, dc.Khoi,dc.Diem from DiemChuan as dc, Nganh as n, Truong as t,NamTuyenSinh as nts where dc.ID_Nganh = n.ID and dc.ID_Truong = t.ID  and dc.ID_Nam = nts.ID and nts.Nam = "+year+" and t.TenTruong=N'"+ThongKeDiemChuan.Truong+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                DataSet data = new DataSet();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            conn.Close();
            return table;
        }

        public DataTable GetDanhSachThiSinh()
        {
            ConnectDatabase();
            conn.Open();
            DataTable table = new DataTable();
            try
            {
                string qr = "Select HoTen,SBD from ThiSinh";
                SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                DataSet data = new DataSet();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            conn.Close();
            return table;
        }

        public Boolean CheckSBD(string SBD)
        {
            ConnectDatabase();
            conn.Open();
            DataTable table = new DataTable();
            try
            {
                string qr = "Select * from ThiSinh where SBD = '" + SBD + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);               
                DataSet data = new DataSet();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.ToString());
            }
            conn.Close();
            if (table.Rows.Count > 0)
                return false;
            return true;
        }

        public void ThemTS(string hoten,string SBD)
        {
            ConnectDatabase();
            conn.Open();
            try
            {
                string qr = "Insert into ThiSinh (HoTen,SBD) values(@HoTen,@SBD)";
                //SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                using (SqlCommand command = new SqlCommand(qr, conn))
                {
                    command.Parameters.AddWithValue("@HoTen", hoten);
                    command.Parameters.AddWithValue("@SBD", SBD);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                mes=true;
            }
            conn.Close();
        }

    }
}
