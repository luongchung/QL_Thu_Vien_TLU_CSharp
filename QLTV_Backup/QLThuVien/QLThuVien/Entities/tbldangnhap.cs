using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Entities
{
    class tbldangnhap
    {
        string MaNV;
        string Pass;

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

        public string Pass1
        {
            get
            {
                return Pass;
            }

            set
            {
                Pass = value;
            }
        }
    }
}
