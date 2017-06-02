using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QLThuVien.DAL
{
    class GetPath
    {
        string tr;
        public GetPath()
        {
            tr = @"D:\";
        }
        public string getPath()
        {
            return tr;
        }
    }
}
