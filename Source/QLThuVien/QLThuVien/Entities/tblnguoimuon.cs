using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Entities
{
    class tblnguoimuon
    {
        int _Id;
        string _MaNM;
        string _TenNM;
        bool _GioiTinh;
        DateTime _NgaySinh;
        string _Khoa;
        string _DiaChi;
        string _GhiChu;
        bool _DongPhi;

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }
        public string MaNM
        {
            get
            {
                return _MaNM;
            }

            set
            {
                _MaNM = value;
            }
        }
        public string TenNM
        {
            get
            {
                return _TenNM;
            }

            set
            {
                _TenNM = value;
            }
        }
        public string Khoa
        {
            get
            {
                return _Khoa;
            }

            set
            {
                _Khoa = value;
            }
        }        
        public string GhiChu
        {
            get
            {
                return _GhiChu;
            }

            set
            {
                _GhiChu = value;
            }
        }
        public bool DongPhi
        {
            get
            {
                return _DongPhi;
            }

            set
            {
                _DongPhi = value;
            }
        }
        public bool GioiTinh
        {
            get
            {
                return _GioiTinh;
            }

            set
            {
                _GioiTinh = value;
            }
        }
        public DateTime NgaySinh
        {
            get
            {
                return _NgaySinh;
            }

            set
            {
                _NgaySinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }
    }
}
