using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        string s = "";
        string A;
        ThongTinNhanVien tt;
        Thongkesach tks;
        Chagepassword ttt;
        Timkiemtheoma tktm;
        ThongKeDocGia dg;
        public FormMain(string tendangnhap)
        {
            InitializeComponent();
            s = tendangnhap;
            txtUserdn.Text = "User: " + tendangnhap;
            GUI.ucMuonTra uc = new GUI.ucMuonTra(tendangnhap);//gắn uc vào from
            uc.Dock = DockStyle.Fill;
            xtraTabPage1.Controls.Add(uc);                    
            //tille chính đổi trong suốt
            var a = this.PointToScreen(labelmain.Location);
            a = picturemain.PointToClient(a);
            labelmain.Parent = picturemain;
            labelmain.Location = a;
            labelmain.BackColor = Color.Transparent;
          //  labelmain.Text = "Demo library";
            uc2();//gắn uc2 vào tab 2
            uc3();// gắn uc3 vào tab 3
            uc6(tendangnhap);
            if (tendangnhap == "admin")
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
        public void uc6(string s)
        {
            GUI.ucTra uc_NV = new GUI.ucTra(s);
            uc_NV.Dock = DockStyle.Fill;
            xtraTabPage2.Controls.Add(uc_NV);
        }
        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {            
            Chagepassword cp = new Chagepassword(s);
            cp.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = A.Length;
            d++;
            string a = A.Substring(0, 1);
            A = A.Substring(1, A.Length - 1);
            labelmain.Text = labelmain.Text + a;
            if (d == x)
            {
                A = labelmain.Text;
                labelmain.Text = "";
                Thread.Sleep(2000);
                timer1.Start();

            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

           // Chay();
            
        }
        public void Chay()
        {
            A = labelmain.Text;
            labelmain.Text = "";
            timer1.Start();
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            dg = new ThongKeDocGia();
            dg.Show();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tktm = new Timkiemtheoma();
            tktm.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tt = new ThongTinNhanVien(s);
            tt.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void mãĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xtraTabPage1.Show();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xtraTabPage2.Show();
        }

        private void danhMụcQuảnLýNgườiMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xtraTabPage3.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xtraTabPage4.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xtraTabPage5.Show();
        }

        private void khôiPhụcMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            ttt = new Chagepassword(s);
            ttt.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ttt = new Chagepassword(s);
            ttt.Show();
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {          
            tks = new Thongkesach();
            tks.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tt = new ThongTinNhanVien(s);
            tt.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn thoát không ?", "OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tracuudocgia tc = new tracuudocgia();
            tc.Show();
        }
    }
}
