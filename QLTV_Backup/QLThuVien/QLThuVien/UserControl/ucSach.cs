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
    public partial class ucSach : UserControl
    {
        DAL.GetPath gp = new DAL.GetPath();
        Entities.tblSach ss;
        BLL.ClassBLL bll_ls;
        DataTable dt;
        string checkmenu_s = "";        
        public ucSach()
        {
            InitializeComponent();
            lockbutton_S();
        }
        private void btnthemloaisach_Click(object sender, EventArgs e)
        {
            QLThuVien.Themloaisach dt = new Themloaisach();
            dt.Show();
        }
        public void loadcheck(string sl)
        {
            bll_ls = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_ls.getMaLoai(sl);
            grccheck.DataSource = dt;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
        public void binding_MaL()
        {
            labMaL.DataBindings.Clear();
            labMaL.DataBindings.Add("Text", grccheck.DataSource, "MaL");
            labTenSach.DataBindings.Clear();
            labTenSach.DataBindings.Add("Text", grccheck.DataSource, "TenS");
            labNXB.DataBindings.Clear();
            labNXB.DataBindings.Add("Text", grccheck.DataSource, "NXB");
            labNamXB.DataBindings.Clear();
            labNamXB.DataBindings.Add("Text", grccheck.DataSource, "NamXB");
            labGiaSach.DataBindings.Clear();
            labGiaSach.DataBindings.Add("Text", grccheck.DataSource, "GiaSach");
        }
        public void Reset()
        {
            labMaL.Text = "";
            labTenSach.Text = "";
            labNXB.Text = "";
            labNamXB.Text = "";
            labGiaSach.Text = "";
        }
        private void txtTenS_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Reset();            
        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
            Load_sach();
        }
        public void Load_sach()
        {
            bll_ls = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_ls.Getselectall_sach();
            gridControl1.DataSource = dt;
        }
        //////////////////////////////////////////
        private void btnthem_Click(object sender, EventArgs e)
        {
            Unlockbutton_S();
            btnhoantat.Text = "Hoàn tất thêm";
            checkmenu_s = "add";
            txtMaS.Focus();
            CN_Combobox();
        }
        public void lockbutton_S()
        {
            txtMaL.Enabled = false;
            txtMaS.ReadOnly = true;          
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnhoantat.Enabled = false;
            btnchuyen.Enabled = false;
        }
        public void Unlockbutton_S()
        {
            txtMaL.Enabled = true;
            txtMaS.ReadOnly = false;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnhoantat.Enabled = true;
            btnchuyen.Enabled = true;
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            Unlockbutton_S();
            btnhoantat.Text = "Hoàn tất sửa";
            checkmenu_s = "sua";
            txtMaS.Focus();
            binding_s();           
        }
        public void binding_s()
        {
            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("Text", gridControl1.DataSource, "Id");
            txtMaS.DataBindings.Clear();
            txtMaS.DataBindings.Add("Text", gridControl1.DataSource, "MaS");
            txtMaL.DataBindings.Clear();
            txtMaL.DataBindings.Add("Text", gridControl1.DataSource, "MaL");
           
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            lockdelete_s();
            btnhoantat.Text = "Hoàn tất xóa";
            checkmenu_s = "xoa";
            binding_s();
        }
        public void lockdelete_s()
        {           
            txtMaS.ReadOnly = true;
            txtMaL.Enabled = false;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnhoantat.Enabled = true;
            btnchuyen.Enabled = true;
        }
        private void btnchuyen_Click(object sender, EventArgs e)
        {
            lockbutton_S();
            Load_sach();
            Reset_s();
        }
        public void Reset_s()
        {
            txtMaL.Text = "";
            txtMaS.Text = "";
        }
        private void btnhoantat_Click(object sender, EventArgs e)
        {
            ss = new Entities.tblSach();
                     
            if (checkmenu_s == "xoa")
            {
                ss.Id1 = int.Parse(txtId.Text);
                bool kt = bll_ls.Delete_S(ss);
                if (kt)
                {
                    MessageBox.Show("Bạn vừa xóa thành công !", "xóa thành công", MessageBoxButtons.OK);
                    Reset();
                    Load_sach();
                    binding_s();
                    return;
                }
                else
                    MessageBox.Show("Lỗi, Không thể xóa được!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (checkObject_s())
            {
                

                if (checkmenu_s == "add")
                {
                    ss.MaL1 = txtMaL.Text;
                    ss.MaS1 = txtMaS.Text;
                    bool kt = bll_ls.Insert_Sach(ss);
                    if (kt)
                    {
                        MessageBox.Show("Bạn vừa lưu thành công !", "Thêm thành công", MessageBoxButtons.OK);
                        Reset();
                        Load_sach();
                    }
                    else
                        MessageBox.Show("Không thành công, xin vui lòng thực hiện lại !", "Thêm không thành công", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                if (checkmenu_s == "sua")
                {
                    ss.Id1 = int.Parse(txtId.Text);
                    ss.MaL1 = txtMaL.Text;
                    ss.MaS1 = txtMaS.Text;
                    bool kt = bll_ls.Update_S(ss);
                    if (kt)
                    {
                        MessageBox.Show("Bạn vừa sửa thành công !", "sửa thành công", MessageBoxButtons.OK);
                        Reset();
                        Load_sach();
                        binding_s();

                    }
                    else
                        MessageBox.Show("Lỗi, Không thể sửa được! có thể trùng mã nhân viên", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
        }
        public bool checkObject_s()
        {
            if (string.IsNullOrEmpty(txtMaS.Text))
            {
                MessageBox.Show("Bạn chư nhập mã nhân viên, xin vui lòng nhập!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaS.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtMaL.Text))
            {
                MessageBox.Show("Bạn chư nhập Tên nhân viên, xin vui lòng nhập!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaL.Focus();
                return false;

            }

            return true;
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if((checkmenu_s=="sua") || (checkmenu_s=="xoa"))
            { 
            binding_s();
            }
        }
        public void CN_Combobox()
        {
            bll_ls = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_ls.GetCB();      
            txtMaL.DataSource = dt;
            txtMaL.ValueMember = "MaL";
            txtMaL.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMaL.AutoCompleteSource = AutoCompleteSource.ListItems;          

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CN_Combobox();
        }
        private void txtMaL_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtMaL.Text != null)
            {
                loadcheck(txtMaL.Text);
                binding_MaL();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã loại sách !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaL.Focus();
            }
        }

        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            string FileName = gp.getPath() + "Tatcasach.xls";
            gridControl1.ExportToXls(FileName);
            if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "Tatcasach.xls'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = FileName;
                prc.Start();
            }
        }
    }
}
