using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace QLThuVien.DAL
{
    class Dataservices
    {
        string str;
        public Dataservices()
        {
            str = ConfigurationManager.ConnectionStrings["connect"].ToString();
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(str);
        }
    }
}
