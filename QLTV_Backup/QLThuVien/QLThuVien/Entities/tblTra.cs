using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Entities
{
    class tblTra
    {
        string MaNV;
        string MaS;
        DateTime NgayT;
        string GhiChu;

        public string MaNV1
        {
            get
            {
                return MaNV;
            }

            set
            {
                MaNV = value;
            }
        }

        public string MaS1
        {
            get
            {
                return MaS;
            }

            set
            {
                MaS = value;
            }
        }

        public DateTime NgayT1
        {
            get
            {
                return NgayT;
            }

            set
            {
                NgayT = value;
            }
        }

        public string GhiChu1
        {
            get
            {
                return GhiChu;
            }

            set
            {
                GhiChu = value;
            }
        }
    }
}
