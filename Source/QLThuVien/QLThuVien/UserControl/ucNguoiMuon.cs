using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLThuVien.GUI
{
    public partial class ucNguoiMuon : UserControl
    {
        DAL.GetPath gp = new DAL.GetPath();
        Entities.tblnguoimuon nm01;
        BLL.ClassBLL bll_NM;
        DataTable dt;        
        string checkmenu_NM="";       
        public ucNguoiMuon()
        {
            InitializeComponent();
            lockObject();           
        }
        private void ucNguoiMuon_Load(object sender, EventArgs e)
        {
            Reload();
        }
        public void Reload()
        {
            bll_NM = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_NM.getallNM();
            grcNM.DataSource = dt;
            

        }
        public void lockObject()
        {
            btnthem.Enabled = true;//
            btnsua.Enabled = true;//
            btnxoa.Enabled = true;//
            btnhoantat.Enabled = false;
            btnchuyen.Enabled = false;
            txtmathe.ReadOnly = true;
            txtten.ReadOnly = true;           
            txtkhoa.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            txtghichu.ReadOnly = true;
            txtnam.Enabled = false;
            checknu.Enabled = false;
            checknam.Enabled = false;
            checkphi1.Enabled = false;
            checkphi0.Enabled = false;
        }
        public void unlockObject()
        {
            btnthem.Enabled = false;//
            btnsua.Enabled = false;//
            btnxoa.Enabled = false;//
            btnhoantat.Enabled = true;
            btnchuyen.Enabled = true;
            txtmathe.ReadOnly = false;
            txtten.ReadOnly = false;
            txtkhoa.ReadOnly = false;
            txtdiachi.ReadOnly = false;
            txtghichu.ReadOnly = false;
            txtnam.Enabled = true;
            checknu.Enabled = true;
            checknam.Enabled = true;
            checkphi1.Enabled = true;
            checkphi0.Enabled = true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            unlockObject();
            btnhoantat.Text = "Hoàn Tất Thêm";
            checkmenu_NM = "add";
            txtmathe.Focus();
        }
        public bool checkObject()
        {
            if (string.IsNullOrEmpty(txtmathe.Text))
            {
                MessageBox.Show("Bạn chư nhập Mã thẻ thư viện, xin vui lòng nhập!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmathe.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtten.Text))
            {
                MessageBox.Show("Bạn chư nhập Tên, xin vui lòng nhập!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtten.Focus();
                return false;

            }            

            return true;
        }
        private void btnhoantat_Click(object sender, EventArgs e)
        {
            nm01 = new Entities.tblnguoimuon();
            if (checkmenu_NM == "xoa")
            {
                nm01.Id = int.Parse(txtId.Text);
                bool kiemtraxoa = bll_NM.DeleteNM(nm01);
                if (kiemtraxoa)
                {
                    MessageBox.Show("Bạn vừa xóa thành công !", "xóa thành công", MessageBoxButtons.OK);
                    Reset();
                    Reload();
                    binding();
                }
                else
                    MessageBox.Show("Không xóa được, kiểm tra lỗi !", "Lỗi", MessageBoxButtons.OK);
            }
            if (checkObject())
            {


                if (checkmenu_NM == "add")
                {
                    nm01.MaNM = txtmathe.Text;
                    nm01.TenNM = txtten.Text;
                    nm01.Khoa = txtkhoa.Text;
                    nm01.NgaySinh = DateTime.Parse(txtnam.Value.ToString());
                    nm01.GioiTinh = checknam.Checked;
                    nm01.DongPhi = checkphi1.Checked;
                    nm01.DiaChi = txtdiachi.Text;
                    nm01.GhiChu = txtghichu.Text;
                    bool kiemtra = bll_NM.InsertNM(nm01);
                    if (kiemtra)
                    {
                        MessageBox.Show("Bạn vừa lưu thành công !", "Thêm thành công", MessageBoxButtons.OK);
                        Reset();
                        Reload();
                    }
                    else
                        MessageBox.Show("Không thêm được, có thể trùng mã thẻ ", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (checkmenu_NM == "sua")
                {
                    nm01.Id = int.Parse(txtId.Text);
                    nm01.MaNM = txtmathe.Text;
                    nm01.TenNM = txtten.Text;
                    nm01.Khoa = txtkhoa.Text;
                    nm01.NgaySinh = DateTime.Parse(txtnam.Value.ToString());
                    nm01.GioiTinh = checknam.Checked;
                    nm01.DongPhi = checkphi1.Checked;
                    nm01.DiaChi = txtdiachi.Text;
                    nm01.GhiChu = txtghichu.Text;
                    bool kiemtra = bll_NM.UpdateNM(nm01);
                    if (kiemtra)
                    {
                        MessageBox.Show("Bạn vừa lưu thành công !", "Thêm thành công", MessageBoxButtons.OK);
                        Reset();
                        Reload();
                        binding();
                    }
                    else
                        MessageBox.Show("Không sửa được, trùm mã thẻ ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }            
           
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {            
            unlockObject();
            checkmenu_NM = "sua";
            btnhoantat.Text = "Hoàn tất sửa";
            txtmathe.Focus();
            binding(); 
                     

        }
        public void binding()
        {           
            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("Text", grcNM.DataSource, "Id");
            txtmathe.DataBindings.Clear();
            txtmathe.DataBindings.Add("Text", grcNM.DataSource, "MaNM");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", grcNM.DataSource, "TenNM");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", grcNM.DataSource, "DiaChi");
            txtghichu.DataBindings.Clear();
            txtghichu.DataBindings.Add("Text", grcNM.DataSource, "GhiChu");
            txtkhoa.DataBindings.Clear();
            txtkhoa.DataBindings.Add("Text", grcNM.DataSource, "Khoa");
            txtgt.DataBindings.Clear();
            txtgt.DataBindings.Add("Text", grcNM.DataSource, "GioiTinh");
            txtdp.DataBindings.Clear();
            txtdp.DataBindings.Add("Text", grcNM.DataSource, "DongPhi");            
        }        
        private void checkphi1_Click(object sender, EventArgs e)
        {
            checkphi0.Checked = false;
        }
        private void checkphi0_Click(object sender, EventArgs e)
        {
            checkphi1.Checked = false;
        }
        private void checknam_Click(object sender, EventArgs e)
        {
            checknu.Checked = false;
        }
        private void checknu_Click(object sender, EventArgs e)
        {
            checknam.Checked = false;
        }
        private void btnchuyen_Click(object sender, EventArgs e)
        {
            lockObject();
            checkmenu_NM = "chuyen";
            Reload();
            Reset();
        }
        public void Reset()
        {
            txtdiachi.Text = "";
            txtghichu.Text = "";
            txtkhoa.Text = "";
            txtmathe.Text = "";
            txtnam.Text = "";
            txtten.Text = "";
            checknam.Checked = false;
            checknu.Checked = false;
            checkphi0.Checked = false;
            checkphi1.Checked = false;
        }
        public void Load_bd()
        {
            if (txtdp.Text.Equals("Đã Đóng"))
            {
                checkphi1.Checked = true;
                checkphi0.Checked = false;
            }
            if (txtdp.Text.Equals("Chưa Đóng"))
            {
                checkphi1.Checked = false;
                checkphi0.Checked = true;
            }
            if (txtgt.Text.Equals("Nam"))
            {
                checknam.Checked = true;
                checknu.Checked = false;
            }
            if (txtgt.Text.Equals("Nữ"))
            {
                checknam.Checked = false;
                checknu.Checked = true;
            }
        }
        private void grcNM_Click(object sender, EventArgs e)
        {
            if(checkmenu_NM!="add" || checkmenu_NM!="chuyen")
            Load_bd();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            lockdelete();
            btnhoantat.Text = "Hoàn tất xóa";
            checkmenu_NM = "xoa";
            binding();
        }
        public void lockdelete()
        {
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnhoantat.Enabled = true;
            btnchuyen.Enabled = true;
            txtmathe.ReadOnly = true;
            txtten.ReadOnly = true;
            txtkhoa.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            txtghichu.ReadOnly = true;
            txtnam.Enabled = false;
            checknu.Enabled = false;
            checknam.Enabled = false;
            checkphi1.Enabled = false;
            checkphi0.Enabled = false;
        }

        private void txtkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grcNM_Load(object sender, EventArgs e)
        {

        }

        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            string FileName = gp.getPath() + "Tatcadocgia.xls";
            grcNM.ExportToXls(FileName);
            if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "Tatcadocgia.xls'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = FileName;
                prc.Start();
            }
        }
    }
}
           
       

              

   

