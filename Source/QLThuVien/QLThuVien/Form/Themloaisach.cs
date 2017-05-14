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
    public partial class Themloaisach : DevExpress.XtraEditors.XtraForm
    {        
        Entities.tblLoaiSach ls01;
        BLL.ClassBLL bll_ls;
        DataTable dt;
        string checkmenu_ls = "";
        public Themloaisach()
        {
            InitializeComponent();
            lockbuttonLS();
        }

        private void Themloaisach_Load(object sender, EventArgs e)
        {
            Reload_LoaiSach();
        }
        public void Reload_LoaiSach()
        {
            bll_ls = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_ls.getall_LoaiSach();
            grcls.DataSource = dt;
        }      
     
        /// <summary>
        /// cách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            UnlockbuttonLS();
            btnhoantat.Text = "Hoàn tất thêm";
            checkmenu_ls = "add";
            txtMaL.Focus();
        }
        public void binding()
        {            
            txtMaL.DataBindings.Clear();
            txtMaL.DataBindings.Add("Text", grcls.DataSource, "MaL");
            txtTenS.DataBindings.Clear();
            txtTenS.DataBindings.Add("Text", grcls.DataSource, "TenS");
            txtNXB.DataBindings.Clear();
            txtNXB.DataBindings.Add("Text", grcls.DataSource, "NXB");
            txtNamXB.DataBindings.Clear();
            txtNamXB.DataBindings.Add("Text", grcls.DataSource, "NamXB");
            txtGiaSach.DataBindings.Clear();
            txtGiaSach.DataBindings.Add("Text", grcls.DataSource, "GiaSach");
        }
        public void Reset()
        {
            txtMaL.Text = "";
            txtTenS.Text = "";
            txtNXB.Text = "";
            txtNamXB.Text = "";
            txtGiaSach.Value = 0;
        }
        public void lockbuttonLS()
        {
            txtMaL.ReadOnly = true;
            txtTenS.ReadOnly = true;
            txtNXB.ReadOnly = true;
            txtNamXB.ReadOnly = true;
            txtGiaSach.ReadOnly = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnhoantat.Enabled = false;
            btnchuyen.Enabled = false;
        }
        public void UnlockbuttonLS()
        {
            txtMaL.ReadOnly = false;
            txtTenS.ReadOnly = false;
            txtNXB.ReadOnly = false;
            txtNamXB.ReadOnly = false;
            txtGiaSach.ReadOnly = false;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnhoantat.Enabled = true;
            btnchuyen.Enabled = true;
        }
        private void btnchuyen_Click(object sender, EventArgs e)
        {
            lockbuttonLS();
            Reload_LoaiSach();
            Reset();
        }
        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            lockdelete();
            btnhoantat.Text = "Hoàn tất xóa";
            checkmenu_ls = "xoa";
            binding();
        }
        public void lockdelete()
        {
            txtMaL.ReadOnly = true;
            txtTenS.ReadOnly = true;
            txtNXB.ReadOnly = true;
            txtNamXB.ReadOnly = true;
            txtGiaSach.ReadOnly = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnhoantat.Enabled = true;
            btnchuyen.Enabled = true;
        }
        private void btnsua_Click_1(object sender, EventArgs e)
        {
            UnlockbuttonLS();
            btnhoantat.Text = "Hoàn tất sửa";
            checkmenu_ls = "sua";
            txtMaL.Focus();
            binding();
        }
        public bool checkObject()
        {
            if (string.IsNullOrEmpty(txtMaL.Text))
            {
                MessageBox.Show("Bạn chư nhập mã loại sách, xin vui lòng nhập!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaL.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTenS.Text))
            {
                MessageBox.Show("Bạn chư nhập Tên sách, xin vui lòng nhập!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenS.Focus();
                return false;

            }

            return true;
        }
        private void btnhoantat_Click_1(object sender, EventArgs e)
        {

            ls01 = new Entities.tblLoaiSach();         
            ls01.MaloaiS1 = txtMaL.Text;
            ls01.TenS1 = txtTenS.Text;
            ls01.NXB1 = txtNXB.Text;
            ls01.NamXB1 = txtNamXB.Text;
            ls01.GiaSach1 = double.Parse(txtGiaSach.Text);
            if (checkmenu_ls == "xoa")
            {
                bool kt = bll_ls.Delete_LoaiSach(ls01);
                if (kt)
                {
                    MessageBox.Show("Bạn vừa xóa thành công !", "xóa thành công", MessageBoxButtons.OK);
                    Reset();
                    Reload_LoaiSach();
                    binding();
                    return;
                }
                else
                    MessageBox.Show("Lỗi, Không thể xóa được!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (checkObject())
            {

                if (checkmenu_ls == "add")
                {
                    bool kt = bll_ls.insert_LoaiSach(ls01);
                    if (kt)
                    {                        
                        MessageBox.Show("Bạn vừa thêm thành công !", "Thêm thành công", MessageBoxButtons.OK);
                        Reset();
                        Reload_LoaiSach();
                        


                    }
                    else
                        MessageBox.Show("Lỗi, Không thể thêm được! có thể trùng loại sách", "Thêm không thành công", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                if (checkmenu_ls == "sua")
                {
                    bool kt = bll_ls.Update_LoaiSach(ls01);
                    if (kt)
                    {
                        MessageBox.Show("Bạn vừa sửa thành công !", "sửa thành công", MessageBoxButtons.OK);
                        Reset();
                        Reload_LoaiSach();
                        binding();

                    }
                    else
                        MessageBox.Show("Lỗi, Không thể sửa được!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }

        }
        private void grcls_Click(object sender, EventArgs e)
        {
            binding();
        }

        private void grcls_Load(object sender, EventArgs e)
        {
            
        }
    }
}

