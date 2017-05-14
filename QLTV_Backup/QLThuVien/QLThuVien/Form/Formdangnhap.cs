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
    
    public partial class Formdangnhap : DevExpress.XtraEditors.XtraForm
    {
        BLL.ClassBLL bll_LI = new BLL.ClassBLL();
        Entities.tbldangnhap dn01 = new Entities.tbldangnhap();
        string A;
        public Formdangnhap()
        {
            InitializeComponent();
            lab1.Text = "QUẢN LÝ SÁCH THƯ VIỆN ĐẠI HỌC THỦY LỢI";
            TachNenFull();            
        }
        public void TachNen(Label t,PictureBox p)
        {
            var a = this.PointToScreen(t.Location);
            a = p.PointToClient(a);
            t.Parent = p;
            t.Location = a;
            t.BackColor = Color.Transparent;            
        }
        public void TachNenFull()
        {
           
            TachNen(lab1, pictureBox2);
            TachNen(label1, pictureBox2);
            TachNen(label2, pictureBox2);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (checkdn())
            {
                dn01.MaNV1 = txtuser.Text;
                dn01.Pass1 = txtpass.Text;            
                bool kt = bll_LI.dangnhap(dn01);
                if (!kt)
                {
                    this.Hide();
                    FormMain td = new FormMain(txtuser.Text);
                    td.Show();
                }
                else
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
            txtuser.Clear();
            txtuser.Focus();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
           if(DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn thoát không ?", "OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            Application.Exit();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            int d = 0, x;
            x = A.Length;
            d++;
            string a = A.Substring(0, 1);
            A = A.Substring(1, A.Length - 1);
            lab1.Text = lab1.Text + a;            
            if (d == x)
            {                
                A = lab1.Text;
                lab1.Text = "";                
                timer0.Start();                               
            }
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ admin để lấy lại !","Quên Pass",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
        public bool checkdn()
        {
            if (string.IsNullOrEmpty(txtuser.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập ! xin vui lòng nhập.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuser.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu ! xin vui lòng nhập.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Focus();
                return false;
            }
            return true;
        }
        private void Formdangnhap_Load(object sender, EventArgs e)
        {
            A = lab1.Text;                              
            lab1.Text = "";           
            timer0.Start();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
