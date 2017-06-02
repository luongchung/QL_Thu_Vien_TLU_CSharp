using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace QLThuVien.DAL
{
    class ClassDAL
    {
        /// <summary>
        /// lopNM
        /// </summary>
        Dataservices ds;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public ClassDAL()
        {
            ds = new Dataservices();
        }
        public DataTable getallNM()
        {
            string sql = "Prd_NM_SelectAll";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception )
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }
        public DataTable getMaNM(string Ma)
        {
            string sql = "Prd_SelectMaNM";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNM", SqlDbType.NVarChar).Value = Ma;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception )
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public bool InsertNM(Entities.tblnguoimuon nm)
        {
            bool kt = false;
            string sql = "Prd_NM_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql,con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNM", SqlDbType.NVarChar).Value = nm.MaNM;
                cmd.Parameters.Add("@TenNM", SqlDbType.NVarChar).Value = nm.TenNM;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = nm.GioiTinh;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nm.NgaySinh;
                cmd.Parameters.Add("@Khoa", SqlDbType.NVarChar).Value = nm.Khoa;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nm.DiaChi;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = nm.GhiChu;
                cmd.Parameters.Add("@DongPhi", SqlDbType.Bit).Value = nm.DongPhi;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public bool UpdateNM(Entities.tblnguoimuon nm)
        {
            bool kt = false;
            string sql = "Prd_NM_Update";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = nm.Id;
                cmd.Parameters.Add("@MaNM", SqlDbType.NVarChar).Value = nm.MaNM;
                cmd.Parameters.Add("@TenNM", SqlDbType.NVarChar).Value = nm.TenNM;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = nm.GioiTinh;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nm.NgaySinh;
                cmd.Parameters.Add("@Khoa", SqlDbType.NVarChar).Value = nm.Khoa;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nm.DiaChi;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = nm.GhiChu;
                cmd.Parameters.Add("@DongPhi", SqlDbType.Bit).Value = nm.DongPhi;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception )
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public bool DeleteNM(Entities.tblnguoimuon lp)
        {
            bool kt = false;
            string sql = "Prd_NM_Delete";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = lp.Id;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception )
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        /// <summary>
        /// lớp sách
        /// </summary>
        public DataTable GetMaL(string s)
        {

            string sql = "Prd_LoaiSach_SelectMaL";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaL", SqlDbType.NVarChar).Value = s;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }    
        ////////////////////lớp nhân viên/////////////////////////////////////////
        public DataTable getallNV()
        {
            string sql = "Pro_NV_SelectAll";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);
            }
            catch(Exception )
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public bool InsertNV(Entities.tblNhanVien nv)
        {
            bool kt = false;
            string sql = "Prd_NV_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV1;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nv.TenNV1;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nv.SDT1;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi1;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception )
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public bool UpdateNV(Entities.tblNhanVien nv)
        {
            bool kt = false;
            string sql = "Prd_NV_Update";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = nv.Id;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV1;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nv.TenNV1;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nv.SDT1;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi1;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception )
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public bool DeleteNV(Entities.tblNhanVien nv)
        {
            bool kt = false;
            string sql = "Prd_NV_Delete";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = nv.Id;               
                cmd.ExecuteNonQuery();
                kt = true;
                
            }
            catch (Exception )
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public DataTable SelectMaNV(string Ma)
        {
            string sql = "Prd_NV_SelectTKMaNV";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = Ma;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        /////////////lớp loại  sách///////////////////////////
        public DataTable getallLoaiSach()
        {
            string sql = "Prd_LoaiSach_SelectAll";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception )
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public bool Insert_loaiSach(Entities.tblLoaiSach ls)
        {
            bool kt = false;
            string sql = "Prd_LoaiSach_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaL", SqlDbType.NVarChar).Value = ls.MaloaiS1;
                cmd.Parameters.Add("@TenS", SqlDbType.NVarChar).Value = ls.TenS1;
                cmd.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = ls.NXB1;
                cmd.Parameters.Add("@NamXB", SqlDbType.NVarChar).Value = ls.NamXB1;
                cmd.Parameters.Add("@GiaSach", SqlDbType.Money).Value = ls.GiaSach1;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception )
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public bool Update_loaiSach(Entities.tblLoaiSach ls)
        {
            bool kt = false;
            string sql = "Prd_LoaiSach_Update";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql,con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaL", SqlDbType.NVarChar).Value = ls.MaloaiS1;
                cmd.Parameters.Add("@TenS", SqlDbType.NVarChar).Value = ls.TenS1;
                cmd.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = ls.NXB1;
                cmd.Parameters.Add("@NamXB", SqlDbType.NVarChar).Value = ls.NamXB1;
                cmd.Parameters.Add("@GiaSach", SqlDbType.Money).Value = ls.GiaSach1;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception )
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public bool Delete_Loaisach(Entities.tblLoaiSach ls)
        {
            bool kt = false;
            string sql = "Prd_LoaiSach_Delete";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaL", SqlDbType.NVarChar).Value = ls.MaloaiS1;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception )
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        /////////////////////////////////////////ngoài///
        public DataTable GetTenS(string s)
        {
            string sql = "Prd_TenS_MaS";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaS", SqlDbType.NVarChar).Value = s;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch(Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        /////////////////////đăng nhâp/////
        public bool login(Entities.tbldangnhap dn)
        {
            bool kt = false;
            string sql = "checkpass";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = dn.MaNV1;
                cmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = dn.Pass1;               
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        ////////////////////lớp sách////////// 
        public DataTable GetSelectall_S()
        {

            string sql = "Prd_Sach_SelectAll";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }
        public bool Insert_Sach(Entities.tblSach s)
        {
            bool kt = false;
            string sql = "Prd_Sach_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaS", SqlDbType.NVarChar).Value = s.MaS1;
                cmd.Parameters.Add("@MaL", SqlDbType.NVarChar).Value = s.MaL1;              
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public bool Update_S(Entities.tblSach s)
        {
            bool kt = false;
            string sql = "Prd_Sach_Update";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = s.Id1;
                cmd.Parameters.Add("@MaS", SqlDbType.NVarChar).Value = s.MaS1;
                cmd.Parameters.Add("@MaL", SqlDbType.NVarChar).Value = s.MaL1;               
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public bool Delete_S(Entities.tblSach s)
        {
            bool kt = false;
            string sql = "Prd_Sach_Delete";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = s.Id1;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public DataTable GetCB()
        {
            string sql = "Prd_S_SelectAll";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }
        public DataTable GetSelectMaS(string s)
        {

            string sql = "Prd_Sach_SelectAll2";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaS", SqlDbType.NVarChar).Value = s;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public bool Insert_MuonS(Entities.tblHDMuon m)
        {
            bool kt = false;
            string sql = "Prd_Muon_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNM", SqlDbType.NVarChar).Value = m.MaNM1;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = m.ManNV1;
                cmd.Parameters.Add("@SoHD", SqlDbType.Int).Value = m.SoHDMuon1;
                cmd.Parameters.Add("@NgayM", SqlDbType.Date).Value = m.NgayM1;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = m.GhiChu1;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public bool Insert_ChiTietM(Entities.tblChiTietMuon m)
        {
            bool kt = false;
            string sql = "Prd_ChiTietMuon_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaS", SqlDbType.NVarChar).Value = m.MaS1;
                cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = m.SoHD1;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public DataTable GetMaHD(int s)
        {
            string sql = "Prd_DSHD";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = s;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public bool Delete_MaS(string s)
        {
            bool kt = false;
            string sql = "Prd_ChiTietM_XoaS";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaS", SqlDbType.NVarChar).Value = s;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public bool Delete_HDAll(int s)
        {
            bool kt = false;
            string sql = "Prd_XoaHDAll";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = s;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public bool UpdatePass(Entities.tbldangnhap nm)
        {
            bool kt = false;
            string sql = "Prd_Updatepass";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nm.MaNV1;
                cmd.Parameters.Add("@PassNV", SqlDbType.NVarChar).Value = nm.Pass1;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public DataTable Getall_MaS(string s)
        {
            string sql = "Prd_Tra_SelectMaS";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaS", SqlDbType.NVarChar).Value = s;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public bool Insert_Tra(Entities.tblTra s)
        {
            bool kt = false;
            string sql = "Prd_Tra_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = s.MaNV1;
                cmd.Parameters.Add("@MaS", SqlDbType.NVarChar).Value = s.MaS1;
                cmd.Parameters.Add("@NgayT", SqlDbType.Date).Value = s.NgayT1;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = s.GhiChu1;
                cmd.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return kt;
        }
        public DataTable getallTra()
        {
            string sql = "Prd_Tra_SelectAll";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }
        public DataTable SoHDMax()
        {
            string sql = "Prd_MaxSoHD";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }
        public DataTable getMaNV(string Ma)
        {
            string sql = "Prd_NV_SelectMaNV";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = Ma;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        /////timfkieems/////
        public DataTable SelectMaS(string Ma)
        {
            string sql = "Prd_TK_SelectMaS";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaS", SqlDbType.NVarChar).Value = Ma;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public DataTable SelectMaL(string Ma)
        {
            string sql = "Prd_TK_SelectMaL";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaL", SqlDbType.NVarChar).Value = Ma;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public DataTable SelectMaNM(string Ma)
        {
            string sql = "Prd_TK_SelectMaNM";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNM", SqlDbType.NVarChar).Value = Ma;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public DataTable getThongKeSach()
        {
            string sql = "Prd_Thongke_Sach";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }
        public DataTable getSachdangmuon()
        {
            string sql = "Prd_Sachdangmuon";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }
        public DataTable getSachquahan()
        {
            string sql = "Prd_QuaHan";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }
        public DataTable getsoluongloai()
        {
            string sql = "Prd_SLLoai";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }
        public DataTable getsoluongton()
        {
            string sql = "Prd_Sachton";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }
        public DataTable getTKDG()
        {
            string sql = "Prd_Thongkedocgia";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }
        public DataTable getDGCDP()
        {
            string sql = "Prd_Chuadongphi";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }
        public DataTable getDGQH()
        {
            string sql = "Prd_DGQH";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }
        public DataTable getDGDM()
        {
            string sql = "Prd_DGDM";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            return dt;
        }




        public DataTable getSachDocGia(string madocgia)
        {
            string sql = "Prd_tracudocgia";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNM", SqlDbType.NVarChar).Value = madocgia;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }













    }
}
