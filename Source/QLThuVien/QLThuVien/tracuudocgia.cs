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
    public partial class tracuudocgia : DevExpress.XtraEditors.XtraForm
    {
        BLL.ClassBLL kt;
        DataTable dt;
        public tracuudocgia()
        {
            InitializeComponent();
        }
        private void binding_ten()
        {
            txt_docgia.DataBindings.Clear();
            txt_docgia.DataBindings.Add("Text", grid_tracuudocgia.DataSource, "TenNM");
        }
        private void searchTK_DG_EditValueChanged_1(object sender, EventArgs e)
        {
            kt = new BLL.ClassBLL();
            dt = new DataTable();
            dt = kt.getSachDocGia(searchTK_DG.Text);
            grid_tracuudocgia.DataSource = dt;
            binding_ten();
        }
    }
}
