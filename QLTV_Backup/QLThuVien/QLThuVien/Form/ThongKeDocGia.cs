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
    public partial class ThongKeDocGia : DevExpress.XtraEditors.XtraForm
    {
        BLL.ClassBLL bll_TK;
        DataTable dt;
        DAL.GetPath gp = new DAL.GetPath();
        string s = "";
        public ThongKeDocGia()
        {
            InitializeComponent();
            Reset();
            HideGrid();

        }

        private void ThongKeDocGia_Load(object sender, EventArgs e)
        {
            NapThongke();
            NapDGCDP();
            NapDGQH();
            NapDGDM();
            binding();
        }
        public void NapThongke()
        {
            bll_TK = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_TK.getTKDG();
            gridthongkeDG.DataSource = dt;
        }
        public void NapDGCDP()
        {
            bll_TK = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_TK.getDGCDP();
            gridchuanopphi.DataSource = dt;
        }
        public void NapDGDM()
        {
            bll_TK = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_TK.getDGDM();
            gridDGDM.DataSource = dt;
        }
        public void NapDGQH()
        {
            bll_TK = new BLL.ClassBLL();
            dt = new DataTable();
            dt = bll_TK.getDGQH();
            gridDGQH.DataSource = dt;
        }
        public void Reset()
        {
            labDGdangmuon.Text = "";
            labdocgiachuadongphi.Text = "";
            labdocgiaquahan.Text = "";
            labTongDG.Text = "";
        }
        public void HideGrid()
        {
            gridchuanopphi.Hide();
            gridDGDM.Hide();
            gridDGQH.Hide();
        }
        public void ShowGird()
        {
            gridchuanopphi.Show();
            gridDGQH.Show();
            gridDGDM.Show();
        }
        public void binding()
        {
            labDGdangmuon.DataBindings.Clear();
            labDGdangmuon.DataBindings.Add("Text", gridthongkeDG.DataSource, "DGDM");
            labdocgiachuadongphi.DataBindings.Clear();
            labdocgiachuadongphi.DataBindings.Add("Text", gridthongkeDG.DataSource, "DGCDP");
            labdocgiaquahan.DataBindings.Clear();
            labdocgiaquahan.DataBindings.Add("Text", gridthongkeDG.DataSource, "DGQH");
            labTongDG.DataBindings.Clear();
            labTongDG.DataBindings.Add("Text", gridthongkeDG.DataSource, "TongDG");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ShowGird();
            s = "a";
            gridchuanopphi.BringToFront();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ShowGird();
            s = "b";
            gridDGQH.BringToFront();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ShowGird();
            s = "c";
            gridDGDM.BringToFront();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if(s=="a")
            {
                string FileName = gp.getPath() + "Docgiachuadongphi.xls";
                gridchuanopphi.ExportToXls(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn: " + gp.getPath() + "Docgiachuadongphi.xls'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName; 
                    prc.Start();
                }
            }
            if (s == "b")
            {
                string FileName = gp.getPath() + "Docgiaquahan.xls";
                gridDGQH.ExportToXls(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "Docgiaquahan.xls'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "c")
            {
                string FileName = gp.getPath() + "Docgiadangmuon.xls";
                gridDGDM.ExportToXls(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn: " + gp.getPath() + "Docgiadangmuon.xls'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
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
                string FileName = gp.getPath() + "chuadongphi.pdf";
                gridchuanopphi.ExportToPdf(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "chuadongphi.pdf'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "b")
            {
                string FileName = gp.getPath() + "Docgiaquahan.pdf";
                gridDGQH.ExportToPdf(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn: " + gp.getPath() + "Docgiaquahan.pdf'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "c")
            {
                string FileName = gp.getPath() + "Docgiadangmuon.pdf";
                gridDGDM.ExportToPdf(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "Docgiadangmuon.pdf'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
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
                string FileName = gp.getPath() + "chuadongphi.html";
                gridchuanopphi.ExportToHtml(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "chuadongphi.html'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "b")
            {
                string FileName =  gp.getPath()+"Docgiaquahan.html";
                gridDGQH.ExportToHtml(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn:" + gp.getPath() + "Docgiaquahan.html'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
            if (s == "c")
            {
                string FileName = gp.getPath() + "Docgiadangmuon.html";
                gridDGDM.ExportToHtml(FileName);
                if (DialogResult.Yes == MessageBox.Show("File đã được tạo tại đường dẫn: " + gp.getPath() + "Docgiadangmuon.html'    Bạn có muốn mở file vừa tạo không?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }
            }
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridDGDM_Click(object sender, EventArgs e)
        {

        }
    }
}
