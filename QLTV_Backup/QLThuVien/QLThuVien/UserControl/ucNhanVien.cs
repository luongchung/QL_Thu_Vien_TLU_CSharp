using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.GUI
{
    public partial class ucNhanVien : UserControl
    {
        DAL.GetPath gp = new DAL.GetPath();  
        Entities.tblNhanVien nv01;
        string checkmenu = "";
        DataTable dt;
        BLL.ClassBLL bll_NV;
        public ucNhanVien()
        {            
            InitializeComponent();
            lockbuttonNV();
        }
        public void reload_NV()
        {
            bll_NV = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_NV.getallNV();
            grcNV.DataSource = dt;
        }
        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            reload_NV();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            UnlockbuttonNV();
            btnhoantat.Text = "Hoàn tất thêm";
            checkmenu = "add";
            txtMaNV.Focus();
        }
        private void btnhoantat_Click(object sender, EventArgs e)
        {
            nv01 = new Entities.tblNhanVien();
            nv01.Id = int.Parse(txtId.Text);
            nv01.MaNV1 = txtMaNV.Text;
            nv01.TenNV1 = txtTenNV.Text;
            nv01.SDT1 = txtSDT.Text;
            nv01.DiaChi1 = txtDiaChi.Text;
            if (checkmenu == "xoa")
            {
                bool kt = bll_NV.DeleteNV(nv01);
                if (kt)
                {
                    MessageBox.Show("Bạn vừa xóa thành công !", "xóa thành công", MessageBoxButtons.OK);
                    Reset();
                    reload_NV();
                    binding();
                    return;
                }
                else
                    MessageBox.Show("Lỗi, Không thể xóa được!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (checkObject())
            {
                
                if(checkmenu=="add")
                {
                    bool kt = bll_NV.InsertNV(nv01);
                    if(kt)
                    {
                        MessageBox.Show("Bạn vừa lưu thành công !", "Thêm thành công", MessageBoxButtons.OK);
                        Reset();
                        reload_NV();
                    }
                    else
                        MessageBox.Show("Trùng mã nhân viên, xin vui lòng nhập lại !", "Thêm không thành công", MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }
                if (checkmenu == "sua")
                {
                    bool kt = bll_NV.UpdateNV(nv01);
                    if (kt)
                    {
                        MessageBox.Show("Bạn vừa sửa thành công !", "sửa thành công", MessageBoxButtons.OK);
                        Reset();
                        reload_NV();
                        binding();

                    }
                    else
                        MessageBox.Show("Lỗi, Không thể sửa được! có thể trùng mã nhân viên", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }              



            }
            
        }
        public bool checkObject()
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Bạn chư nhập mã nhân viên, xin vui lòng nhập!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Bạn chư nhập Tên nhân viên, xin vui lòng nhập!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return false;

            }           

            return true;
        }
        public void lockbuttonNV()
        {
            txtTenNV.ReadOnly= true;
            txtSDT.ReadOnly = true;
            txtMaNV.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnhoantat.Enabled = false;
            btnchuyen.Enabled = false;
        }
        public void UnlockbuttonNV()
        {
            txtTenNV.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtMaNV.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnhoantat.Enabled = true;
            btnchuyen.Enabled = true;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {           
            lockbuttonNV();
            reload_NV();
            Reset();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            
        }
        public void binding()
        {
            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("Text", grcNV.DataSource, "Id");
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", grcNV.DataSource, "MaNV");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", grcNV.DataSource, "TenNV");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", grcNV.DataSource, "SDT");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", grcNV.DataSource, "DiaChi");
        }
        public void Reset()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";         
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            lockdelete();
            btnhoantat.Text = "Hoàn tất xóa";
            checkmenu = "xoa";            
            binding();
            
        }
        public void lockdelete()
        {
            txtTenNV.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtMaNV.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnhoantat.Enabled = true;
            btnchuyen.Enabled = true;
        }

        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            string FileName = gp.getPath() + "Tatcanhanvien.xls";
            grcNV.ExportToXls(FileName);
            if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "Tatcanhanvien.xls'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = FileName;
                prc.Start();
            }
        }
    }
    
}
