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
    public partial class Thongkesach : Form
    {
        DAL.GetPath gp = new DAL.GetPath();
        BLL.ClassBLL bll_TK;
        DataTable dt;
        string s = "";
        public Thongkesach()
        {
            InitializeComponent();
            HideGrid();
            Reset();
            
        }
        private void Thongkesach_Load(object sender, EventArgs e)
        {
            NapThongke();
            NapSachdangmuon();
            NapSachquahan();
            Napsoluongtheoloai();
            Napsoluongton();
            binding();
        }
        public void NapThongke()
        {
            bll_TK = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_TK.getThongKeSach();
            gridThongKeS.DataSource = dt;
        }
        public void Napsoluongton()
        {
            bll_TK = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_TK.getsoluongton();
            gridsachton.DataSource = dt;
        }
        public void NapSachdangmuon()
        {
            bll_TK = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_TK.getSachdangmuon();
            gridSachdangmuon.DataSource = dt;
        }
        public void Napsoluongtheoloai()
        {
            bll_TK = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_TK.getsoluongloai();
            gridsoluongtheoloai.DataSource = dt;
        }
        public void NapSachquahan()
        {
            bll_TK = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_TK.getSachquahan();
            gridQuaHan.DataSource = dt;
        }
        public void Reset()
        {
            labSachCM.Text = "";
            labSachQH.Text = "";
            labSachTK.Text = "";
            labTongS.Text = "";
        }
        public void binding()
        {
            labSachCM.DataBindings.Clear();
            labSachCM.DataBindings.Add("Text", gridThongKeS.DataSource, "SachCM");
            labSachQH.DataBindings.Clear();
            labSachQH.DataBindings.Add("Text", gridThongKeS.DataSource, "QuaH");
            labSachTK.DataBindings.Clear();
            labSachTK.DataBindings.Add("Text", gridThongKeS.DataSource, "SachTK");
            labTongS.DataBindings.Clear();
            labTongS.DataBindings.Add("Text", gridThongKeS.DataSource, "TongS");
        }
        private void btnSachdangmuon_Click(object sender, EventArgs e)
        {
            ShowGrid();
            s = "d";
            gridSachdangmuon.BringToFront();
        }
        public void HideGrid()
        {
            gridSachdangmuon.Hide();
            gridQuaHan.Hide();
            gridsoluongtheoloai.Hide();
            gridsachton.Hide();
        }
        public void ShowGrid()
        {
            gridQuaHan.Show();
            gridSachdangmuon.Show();
            gridsoluongtheoloai.Show();
            gridsachton.Show();
        }

        private void btnsachquahan_Click(object sender, EventArgs e)
        {
            ShowGrid();
            s = "a";
            gridQuaHan.BringToFront();
        }

        private void btnslsachtl_Click(object sender, EventArgs e)
        {
            ShowGrid();
            s = "b";
            gridsoluongtheoloai.BringToFront();
        }

        private void btnsachton_Click(object sender, EventArgs e)
        {
            ShowGrid();
            s = "c";
            gridsachton.BringToFront();
        }

        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            if (s == "a")
            {
                string FileName = gp.getPath()+"Sachquahan.xls";
                gridQuaHan.ExportToXls(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:"+ gp.getPath()+"Sachquahan.xls'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "b")
            {
                string FileName = gp.getPath() + "Thongkesoluongloaisach.xls";
                gridsoluongtheoloai.ExportToXls(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "Thongkesoluongloaisach.xls'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "c")
            {
                string FileName = gp.getPath() + "Thongkesachton.xls";
                gridsachton.ExportToXls(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "Thongkesachton.xls'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "d")
            {
                string FileName = gp.getPath() + "Thongkesachdangmuon.xls";
                gridSachdangmuon.ExportToXls(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "Thongkesachdangmuon.xls'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (s == "a")
            {
                string FileName = gp.getPath() + "Sachquahan.pdf";
                gridQuaHan.ExportToPdf(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "Sachquahan.pdf'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "b")
            {
                string FileName = gp.getPath() + "Thongkesoluongloaisach.pdf";
                gridsoluongtheoloai.ExportToPdf(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "Thongkesoluongloaisach.pdf'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "c")
            {
                string FileName = gp.getPath() + "Thongkesachton.pdf";
                gridsachton.ExportToPdf(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "Thongkesachton.pdf'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "d")
            {
                string FileName = gp.getPath() + "Thongkesachdangmuon.pdf";
                gridSachdangmuon.ExportToPdf(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn: " + gp.getPath() + "Thongkesachdangmuon.pdf'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
        }

        private void btnHTML_Click(object sender, EventArgs e)
        {
            if (s == "a")
            {
                string FileName = @"C:\Users\chung\OneDrive\Documents\FileExport\Sachquahan.html";
                gridQuaHan.ExportToHtml(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn: 'C:\\Users\\chung\\OneDrive\\Documents\\FileExport\\Sachquahan.html'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "b")
            {
                string FileName = @"C:\Users\chung\OneDrive\Documents\FileExport\Thongkesoluongloaisach.html";
                gridsoluongtheoloai.ExportToHtml(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn: 'C:\\Users\\chung\\OneDrive\\Documents\\FileExport\\Thongkesoluongloaisach.html'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "c")
            {
                string FileName = @"C:\Users\chung\OneDrive\Documents\FileExport\Thongkesachton.html";
                gridsachton.ExportToHtml(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn: 'C:\\Users\\chung\\OneDrive\\Documents\\FileExport\\Thongkesachton.html'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "d")
            {
                string FileName = @"C:\Users\chung\OneDrive\Documents\FileExport\Thongkesachdangmuon.html";
                gridSachdangmuon.ExportToHtml(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn: 'C:\\Users\\chung\\OneDrive\\Documents\\FileExport\\Thongkesachdangmuon.html'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
