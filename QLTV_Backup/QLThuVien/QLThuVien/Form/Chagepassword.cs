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
    public partial class Chagepassword : DevExpress.XtraEditors.XtraForm
    {
        BLL.ClassBLL bll_LI = new BLL.ClassBLL();
        Entities.tbldangnhap dn01 = new Entities.tbldangnhap();
        string user="";
        public Chagepassword(string s)
        {
            InitializeComponent();
            Hide1.Checked = true;
            user = s;
            Kichhoat(s);
            
            
        }
        public bool checknull()
        {
            if (string.IsNullOrEmpty(txtMKcu.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ ! xin vui lòng nhập.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKcu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMKmoi.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới ! xin vui lòng nhập.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKmoi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMKmoi1.Text))
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu mới ! xin vui lòng nhập.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKmoi1.Focus();
                return false;
            }
            return true;
        }
        public bool checktrung()
        {
            if (txtMKmoi.Text == txtMKmoi1.Text)
            {                
                return true;
            }  
            else
            {
                txtMKmoi1.Focus();
                return false;
            }             
           
        }
        private void btnHoantat_Click(object sender, EventArgs e)
        {
            if (checknull())
            {
                if (checktrung())
                {
                    dn01.MaNV1 = user;
                    dn01.Pass1 = txtMKcu.Text;
                    bool kt = bll_LI.dangnhap(dn01);
                    if (!kt)
                    {
                        dn01.MaNV1 = user;
                        dn01.Pass1 = txtMKmoi.Text;
                        bool kt2 = bll_LI.UpdatePass(dn01);
                        if (kt2)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                        }
                        else
                            MessageBox.Show("Đổi mật khẩu không thành công", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMKcu.Focus();
                    }
                }
                else
                    MessageBox.Show("Mật khẩu mới không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Kichhoat(string s)
        {
            if (s == "admin" || s == "ADMIN" || s == "Admin")
            {
                link.Enabled = true;
                txtTDN.Enabled = true;
            }

            else
            {
                link.Enabled = false;
                txtTDN.Enabled = false;
            }
               
        }

        private void Hide1_CheckedChanged(object sender, EventArgs e)
        {
            if (Hide1.Checked == true)
            {
                txtMKcu.UseSystemPasswordChar = true;
                txtMKmoi.UseSystemPasswordChar = true;
                txtMKmoi1.UseSystemPasswordChar = true;
            }
            else
            {
                txtMKcu.UseSystemPasswordChar = false;
                txtMKmoi.UseSystemPasswordChar = false;
                txtMKmoi1.UseSystemPasswordChar = false;
            }
        }

        private void link_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTDN.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập muốn lấy lại.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {

                dn01.MaNV1 = txtTDN.Text;
                dn01.Pass1 = "123456";
                bool kt2 = bll_LI.UpdatePass(dn01);
                if (kt2)
                {
                    MessageBox.Show("Lấy khẩu thành công, mật khẩu mặc định là :123456", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();                    
                }
                else
                    MessageBox.Show("Không thành công! có thể tên tài khoản chưa đúng", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
