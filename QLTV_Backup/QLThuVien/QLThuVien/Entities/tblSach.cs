using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Entities
{
    class tblSach
    {
        int Id;
        string MaS;
        string MaL;
        public int Id1
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
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
        public string MaL1
        {
            get
            {
                return MaL;
            }

            set
            {
                MaL = value;
            }
        }
    }
}
