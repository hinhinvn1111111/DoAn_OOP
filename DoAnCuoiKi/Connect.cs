using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string connectionString = @"Data Source=DESKTOP-7THJV1N;Initial Catalog=hihi;Integrated Security=True";
            conn = new SqlConnection(connectionString);
        }    
        public Boolean CheckDangNhap(string usn, string pw)
        {
            ConnectDatabase();
            conn.Open();
            if (!Regex.IsMatch(usn, @"^[a-zA-Z'./s]{1,50}$"))
                return false;
            if (!Regex.IsMatch(pw, @"^[1-9]{3,8}$"))
                return false;
            string qr = "Select * from Login where usn = '" + usn + "' and pw = '" + pw + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
            DataTable table = new DataTable();
            DataSet data = new DataSet();
            adapter.Fill(table);
            conn.Close();
            if (table.Rows.Count > 0)
                return true;
            return false;

            //ConnectDatabase();
            //conn.Open();
            //string qr = "Select * from Login where usn = @usn and pw = @pw";


            //using (SqlCommand command = new SqlCommand(qr, conn))
            //{
            //    command.Parameters.AddWithValue("@usn", DangNhap.usn);
            //    command.Parameters.AddWithValue("@pw", DangNhap.pw);
            //    try
            //    {
            //        command.ExecuteNonQuery();

            //    }
            //    catch
            //    {
            //        mes = true;
            //        throw new Exception("aaaaa");
            //    }
            //}
            //string qr1 = "Select * from Login where usn = N'"+DangNhap.usn+"' and pw = N'"+DangNhap.pw+"'";
            //SqlDataAdapter adapter = new SqlDataAdapter(qr1, conn);
            //DataTable table = new DataTable();
            //DataSet data = new DataSet();
            //adapter.Fill(table);
            //conn.Close();
            //if (table.Rows.Count > 0)
            //    return true;
            //return false;
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
        public int DangKiTaiKhoan(string usn,string pw)
        {
            ConnectDatabase();
            conn.Open();
            if (!Regex.IsMatch(usn, @"^[a-zA-Z'./s]{3,50}$"))
                return 1;
            if (!Regex.IsMatch(pw, @"^[1-9]{3,8}$"))
                return 2;
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
            return 0;

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
            catch
            {
               // throw new Exception("Error" + ex.ToString());
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

        public void Update_ThiSinh(string Hoten,string SBD)
        {
            ConnectDatabase();
            conn.Open();
            try
            {
                string qr = "Update ThiSinh set HoTen=N'"+Hoten+"' where SBD=N'"+SBD+"'";
                //SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                using (SqlCommand command = new SqlCommand(qr, conn))
                {
                    command.ExecuteNonQuery();
                }
                
            }
            catch (Exception)
            {
                mes = true;
            }
            conn.Close();
        }

        public void Delete_ThiSinh(string SBD)
        {
            ConnectDatabase();
            conn.Open();
            try
            {
                string qr = "Delete from ThiSinh where SBD = N'"+SBD+"'";
                //SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                using (SqlCommand command = new SqlCommand(qr, conn))
                {
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                mes = true;
            }
            conn.Close();
        }

        public void Update_MatKhau(string usn, string pw)
        {
            ConnectDatabase();
            conn.Open();
            try
            {
                string qr = "Update Login set pw=N'"+pw+"' where usn=N'"+usn+"'";
                //SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                using (SqlCommand command = new SqlCommand(qr, conn))
                {
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                mes = true;
            }
            conn.Close();
        }

        public DataTable GetMonThi_QL()
        {
            ConnectDatabase();
            conn.Open();
            DataTable table = new DataTable();
            try
            {
                string qr = "select *from MonThi";
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

        public DataTable GetDiemThi_QL(string mon)
        {
            ConnectDatabase();
            conn.Open();
            DataTable table = new DataTable();
            try
            {
                string qr = "select t.SBD,t.HoTen,d.Diem from ThiSinh as t, MonThi as m, DiemThi as d where t.SBD=d.SBD and m.ID=d.ID_Mon and m.TenMon=N'"+mon+"'";
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


        public int GetIDMon_QL(string mon)
        {
            ConnectDatabase();
            conn.Open();
            int ID = 0;
            try
            {
                string qr = "select ID from MonThi where TenMon = N'"+mon+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                DataTable table = new DataTable();
                DataSet data = new DataSet();
                adapter.Fill(table);
                conn.Close();
                ID = (int)table.Rows[0][0];
            }
            catch
            {
                //throw new Exception("Error" + ex.ToString());
            }

            return ID;
                
        }

        public void ThemDiem_QL(string SBD, int ID,float diem)
        {
            ConnectDatabase();
            conn.Open();
            try
            {
                string qr = "Insert into DiemThi (SBD,ID_Mon,Diem) values(@SBD,@ID,@Diem)";
                //SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                using (SqlCommand command = new SqlCommand(qr, conn))
                {
                    command.Parameters.AddWithValue("@SBD", SBD);
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@Diem", diem);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                mes = true;
            }
            conn.Close();
        }

        public void Update_DiemThi(string SBD, int ID,float diem)
        {
            ConnectDatabase();
            conn.Open();
            try
            {
                string qr = "update DiemThi set Diem="+diem+" where SBD=N'"+SBD+"' and ID_Mon="+ID+"";
                //SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                using (SqlCommand command = new SqlCommand(qr, conn))
                {
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                mes = true;
            }
            conn.Close();
        }

        public Boolean CheckThemDiem_QL(string SBD,int ID)
        {
            ConnectDatabase();
            conn.Open();
            DataTable table = new DataTable();
            try
            {
                string qr = "select * from DiemThi Where SBD = N'"+SBD+"' and ID_Mon="+ID+"";
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
        public int GetIDTruong(string TenTruong)
        {
            ConnectDatabase();
            conn.Open();
            int ID = 0;
            try
            {
                string qr = "select ID from Truong where TenTruong = N'" + TenTruong + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                DataTable table = new DataTable();
                DataSet data = new DataSet();
                adapter.Fill(table);
                conn.Close();
                ID = (int)table.Rows[0][0];
            }
            catch
            {
                //throw new Exception("Error" + ex.ToString());
            }

            return ID;

        }
        public void Update_DiemSan(int ID, float diem)
        {
            ConnectDatabase();
            conn.Open();
            try
            {
                string qr = "update DiemSan set Diem=" + diem + " where ID_Truong='"+ID+"'";
                //SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                using (SqlCommand command = new SqlCommand(qr, conn))
                {
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                mes = true;
            }
            conn.Close();
        }
        public void Delete_DiemThi(string SBD,int ID)
        {
            ConnectDatabase();
            conn.Open();
            try
            {
                string qr = "Delete from DiemThi where SBD=N'"+SBD+"' and ID_Mon='"+ID+"'";
                //SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                using (SqlCommand command = new SqlCommand(qr, conn))
                {
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                mes = true;
            }
            conn.Close();
        }
        public void Delete_DiemSan(int ID)
        {
            ConnectDatabase();
            conn.Open();
            try
            {
                string qr = "Delete from DiemSan where ID_Truong='"+ID+"'";
                //SqlDataAdapter adapter = new SqlDataAdapter(qr, conn);
                using (SqlCommand command = new SqlCommand(qr, conn))
                {
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                mes = true;
            }
            conn.Close();
        }
        public DataTable GetDiemSan_Search(string key)
        {
            ConnectDatabase();
            conn.Open();
            DataTable table = new DataTable();
            try
            {
                string qr = "select t.TenTruong,ds.Diem from DiemSan as ds,Truong as t ,NamTuyenSinh as n where ds.ID_Truong = t.ID and ds.ID_Nam=n.ID and n.Nam='"+year+"' and t.TenTruong = '"+key+"'";
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
        public DataTable GetDiemChuan(string truong)
        {
            ConnectDatabase();
            conn.Open();
            DataTable table = new DataTable();
            try
            {
                string qr = "select n.TenNganh, d.Khoi, d.Diem from Truong as t, DiemChuan as d, Nganh as n where t.ID = d.ID_Truong and n.ID= d.ID_Nganh and t.TenTruong= N'"+truong+"'";
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
        //select n.TenNganh, d.Khoi, d.Diem from Truong as t, DiemChuan as d, Nganh as n where t.ID = d.ID_Truong and n.ID= d.ID_Nganh and t.TenTruong= ''
    }
}
