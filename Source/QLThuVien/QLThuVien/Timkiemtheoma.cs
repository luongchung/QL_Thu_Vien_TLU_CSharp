using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QLThuVien
{
    public partial class Timkiemtheoma : DevExpress.XtraEditors.XtraForm
    {
        
        BLL.ClassBLL kt;
        DataTable dt;
        string s = "";       
        public Timkiemtheoma()
        {
            InitializeComponent();
            txtThanh.Text = "";
            searchTK.Enabled = false;
            Hidegird();

        }

        private void txtMaL_SelectedValueChanged(object sender, EventArgs e)
        {
            searchTK.Enabled = true;
            if (txtThanh.Text == "MÃ OR TÊN NHÂN VIÊN")
            {
                s = "nv";
                searchTK.Text = "";
                Showgird();
                gridTKMaNV.BringToFront();
            }
            if (txtThanh.Text == "MÃ OR TÊN SÁCH")
            {
                s = "s";
                searchTK.Text = "";
                Showgird();
                gridTKMaS.BringToFront();                
            }
            if (txtThanh.Text == "MÃ LOẠI SÁCH")
            {
                s = "ls";
                searchTK.Text = "";
                Showgird();
                gridMLS.BringToFront();
            }
            if (txtThanh.Text == "MÃ OR TÊN ĐỘC GIẢ")
            {
                s = "dg";
                searchTK.Text = "";
                Showgird();
                gridTKNM.BringToFront();
            }

        }
        public void Showgird()
        {
            gridTKMaNV.Show();
            gridTKMaS.Show();
            gridMLS.Show();
        }
        public void Hidegird()
        {
            gridTKMaNV.Hide();
            gridTKMaS.Hide();
            gridMLS.Hide();
        }

        private void searchTK_EditValueChanged(object sender, EventArgs e)
        {
           if(s=="nv")
            {
                kt = new BLL.ClassBLL();
                dt = new DataTable();
                dt = kt.SelectMaNV(searchTK.Text);
                gridTKMaNV.DataSource = dt;
            }
            if (s == "s")
            {
                kt = new BLL.ClassBLL();
                dt = new DataTable();
                dt = kt.SelectMaS(searchTK.Text);
                gridTKMaS.DataSource = dt;
            }
            if (s == "ls")
            {
                kt = new BLL.ClassBLL();
                dt = new DataTable();
                dt = kt.SelectMaL(searchTK.Text);
                gridMLS.DataSource = dt;
            }
            if (s == "dg")
            {
                kt = new BLL.ClassBLL();
                dt = new DataTable();
                dt = kt.SelectMaNM(searchTK.Text);
                gridTKNM.DataSource = dt;
            }

        }
    }
}
