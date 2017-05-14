using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLThuVien
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public FormMain(string tendangnhap)
        {
            
            InitializeComponent();
            txtUserdn.Text = "User: "+tendangnhap;
            GUI.ucMuonTra uc = new GUI.ucMuonTra(tendangnhap);//gắn uc vào from
            uc.Dock = DockStyle.Fill;
            xtraTabPage1.Controls.Add(uc);            

            //tille chính đổi trong suốt
            var a = this.PointToScreen(labelmain.Location);
            a = picturemain.PointToClient(a);
            labelmain.Parent = picturemain;
            labelmain.Location = a;
            labelmain.BackColor = Color.Transparent;
            //labelmain.Text="Demo library";
            uc2();//gắn uc2 vào tab 2
            uc3();// gắn uc3 vào tab 3
            if (tendangnhap == "admin" || tendangnhap == "ADMIN")
                uc4();//gắn uc 4--->tab4
            else
                uc5();
         }
        public void uc2()
        {
            GUI.ucSach uc = new GUI.ucSach();//gắn uc vào from
            uc.Dock = DockStyle.Fill;
            xtraTabPage4.Controls.Add(uc);
        }
        public void uc3()
        {
            GUI.ucNguoiMuon uc1 = new GUI.ucNguoiMuon();
            uc1.Dock = DockStyle.Fill;
            xtraTabPage3.Controls.Add(uc1);
        }
        public void uc4()
        {
            GUI.ucNhanVien uc_NV = new GUI.ucNhanVien();
            uc_NV.Dock = DockStyle.Fill;
            xtraTabPage5.Controls.Add(uc_NV);
        }
        public void uc5()
        {
            GUI.ucAn uc_NV = new GUI.ucAn();
            uc_NV.Dock = DockStyle.Fill;
            xtraTabPage5.Controls.Add(uc_NV);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formdangnhap td = new Formdangnhap();
            td.Show();
        }

        private void labelmain_Click(object sender, EventArgs e)
        {

        }
    }
    
}
