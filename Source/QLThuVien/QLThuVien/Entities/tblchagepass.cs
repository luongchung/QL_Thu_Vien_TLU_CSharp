using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Entities
{
    class tblchagepass
    {
        string TenNV;
        string MK;
        public string TenNV1
        {
            get
            {
                return TenNV;
            }

            set
            {
                TenNV = value;
            }
        }

        public string MK1
        {
            get
            {
                return MK;
            }

            set
            {
                MK = value;
            }
        }
    }
}
