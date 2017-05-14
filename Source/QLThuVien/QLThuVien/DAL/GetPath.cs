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
            tr = @"C:\Users\chung\OneDrive\Documents\FileExport\";
        }
        public string getPath()
        {
            return tr;
        }
    }
}
