using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class ThongTinNhanVien : DevExpress.XtraEditors.XtraForm
    {
        BLL.ClassBLL bll_MT;
        DataTable dt;
        public ThongTinNhanVien(string m)
        {
            InitializeComponent();
            bll_MT = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_MT.getMaNV(m);
            gridTT.DataSource = dt;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void bindingTT()
        {
            labDiaChi.DataBindings.Clear();
            labDiaChi.DataBindings.Add("Text", gridTT.DataSource, "DiaChi");
            labMaNV.DataBindings.Clear();
            labMaNV.DataBindings.Add("Text", gridTT.DataSource, "MaNV");
            labTenNV.DataBindings.Clear();
            labTenNV.DataBindings.Add("Text", gridTT.DataSource, "TenNV");
            labSDT.DataBindings.Clear();
            labSDT.DataBindings.Add("Text", gridTT.DataSource, "SDT");
        }

        private void gridTT_Load(object sender, EventArgs e)
        {
            bindingTT();
        }
    }
}
