using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLThuVien.BLL
{
    class ClassBLL
    {
        DAL.ClassDAL dal;
        public ClassBLL()
        {
            dal = new DAL.ClassDAL();
        }
        public DataTable getallNM()
        {
            return dal.getallNM();
        }
        public DataTable getMaNM(string _Ma)
        {
            return dal.getMaNM(_Ma);
        }
        public bool InsertNM(Entities.tblnguoimuon nm1)
        {
            return dal.InsertNM(nm1);
        }
        public bool UpdateNM(Entities.tblnguoimuon nm)
        {
            return dal.UpdateNM(nm);
        }
        public bool DeleteNM(Entities.tblnguoimuon nm)
        {
            return dal.DeleteNM(nm);
        }
        ///////////////////////////////////// lớp nhân viên
        public DataTable getallNV()
        {
            return dal.getallNV();
        }
        public bool InsertNV(Entities.tblNhanVien nv)
        {
            return dal.InsertNV(nv);
        }
        public bool UpdateNV(Entities.tblNhanVien nv)
        {
            return dal.UpdateNV(nv);
        }
        public bool DeleteNV(Entities.tblNhanVien nv)
        {
            return dal.DeleteNV(nv);
        }
        ///////////////////////////////////lớp loạisách
        public DataTable getall_LoaiSach()
        {
            return dal.getallLoaiSach();
        }
        public bool insert_LoaiSach(Entities.tblLoaiSach s)
        {
            return dal.Insert_loaiSach(s);
        }
        public bool Update_LoaiSach(Entities.tblLoaiSach s)
        {
            return dal.Update_loaiSach(s);
        }
        public bool Delete_LoaiSach(Entities.tblLoaiSach s)
        {
            return dal.Delete_Loaisach(s);
        }
        public DataTable GetTenS(string s)
        {
            return dal.GetTenS(s);
        }
        /////dang nhap/////
        public bool dangnhap(Entities.tbldangnhap dn)
        {
            return dal.login(dn);
        }
        /////////////lớp sách//////////
        public DataTable getMaLoai(string s)
        {
            return dal.GetMaL(s);
        }
        public DataTable Getselectall_sach()
        {
            return dal.GetSelectall_S();
        }
        public bool Insert_Sach(Entities.tblSach s)
        {
            return dal.Insert_Sach(s);
        }
        public bool Update_S(Entities.tblSach s)
        {
            return dal.Update_S(s);
        }
        public bool Delete_S(Entities.tblSach s)
        {
            return dal.Delete_S(s);
        }
        ////////
        public DataTable GetCB()
        {
            return dal.GetCB();
        }
        public DataTable GetSelectMaS(string s)
        {
            return dal.GetSelectMaS(s);
        }
        public bool Insert_MuonS(Entities.tblHDMuon m)
        {
            return dal.Insert_MuonS(m);
        }
        public bool Insert_ChiTietM(Entities.tblChiTietMuon m)
        {
            return dal.Insert_ChiTietM(m);
        }
        public DataTable GetMaHD(int s)
        {
            return dal.GetMaHD(s);
        }
        public bool Delete_MaS(string s)
        {
            return dal.Delete_MaS(s);
        }
        public bool Delete_HDAll(int s)
        {
            return dal.Delete_HDAll(s);
        }
        /////////////
        public bool UpdatePass(Entities.tbldangnhap nm)
        {
            return dal.UpdatePass(nm);
        }
        public DataTable Getall_MaS(string s)
        {
            return dal.Getall_MaS(s);
        }
        public bool Insert_Tra(Entities.tblTra s)
        {
            return dal.Insert_Tra(s);
        }
        public DataTable getallTra()
        {
            return dal.getallTra();
        }
        public DataTable SoHDMax()
        {
            return dal.SoHDMax();
        }
        public DataTable getMaNV(string ma)
        {
            return dal.getMaNV(ma);
        }
        public DataTable SelectMaNV(string Ma)
        {
            return dal.SelectMaNV(Ma);
        }
        public DataTable SelectMaS(string Ma)
        {
            return dal.SelectMaS(Ma);
        }
        public DataTable SelectMaL(string Ma)
        {
            return dal.SelectMaL(Ma);
        }
        public DataTable SelectMaNM(string Ma)
        {
            return dal.SelectMaNM(Ma);
        }
        public DataTable getThongKeSach()
        {
            return dal.getThongKeSach();
        }
        public DataTable getSachdangmuon()
        {
            return dal.getSachdangmuon();
        }
        public DataTable getSachquahan()
        {
            return dal.getSachquahan();
        }
        public DataTable getsoluongloai()
        {
            return dal.getsoluongloai();
        }
        public DataTable getsoluongton()
        {
            return dal.getsoluongton();
        }
        public DataTable getTKDG()
        {
            return dal.getTKDG();
        }
        public DataTable getDGCDP()
        {
            return dal.getDGCDP();
        }
        public DataTable getDGQH()
        {
            return dal.getDGQH();
        }
        public DataTable getDGDM()
        {
            return dal.getDGDM();
        }
        public DataTable getSachDocGia(string madocgia)
        {
            return dal.getSachDocGia(madocgia);
        }
    }
}
