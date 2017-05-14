using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Entities
{
    class tblHDMuon
    {
        string MaNM;
        string ManNV;
        int SoHDMuon;
        DateTime NgayM;
        string GhiChu;       
        public int SoHDMuon1
        {
            get
            {
                return SoHDMuon;
            }

            set
            {
                SoHDMuon = value;
            }
        }
        public DateTime NgayM1
        {
            get
            {
                return NgayM;
            }

            set
            {
                NgayM = value;
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

        public string MaNM1
        {
            get
            {
                return MaNM;
            }

            set
            {
                MaNM = value;
            }
        }

        public string ManNV1
        {
            get
            {
                return ManNV;
            }

            set
            {
                ManNV = value;
            }
        }
    }
}
