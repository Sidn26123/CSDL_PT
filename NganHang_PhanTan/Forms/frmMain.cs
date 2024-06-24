using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NganHang_PhanTan.Component;
namespace NganHang_PhanTan
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            baoCaoRib.Visible = nghiepVuRib.Visible = false;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void setRibControll(bool value)
        {
            nghiepVuRibControll.Enabled = value;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void loginBarBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.username.Trim() != "")
            {
                MessageBox.Show("Bạn đã đăng nhập", "", MessageBoxButtons.OK);
                return;
            }
            Form frm = this.CheckExists(typeof(frmLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void MANV_Click(object sender, EventArgs e)
        {

        }

        public void showMenu()
        {
            MANV.Text = "Mã NV: " + Program.username;
            HOTEN.Text = "Họ tên: " + Program.mHoTen;
            NHOM.Text = "Nhóm: " + Program.mGroup;
            createAccountBarBtnItem.Enabled = true;
            if (Program.mGroup == "KhachHang")
            {
                nghiepVuRib.Visible = false;
                createAccountBarBtnItem.Enabled = false;
                createAccountBarBtnItem.Enabled = false;

            }
            else if (Program.mGroup == "NganHang")
            {
                chuyenTienBarActionBtn.Enabled = guiRutTienBtn.Enabled = false;
            }
            baoCaoRib.Visible = nghiepVuRib.Visible = true;
            
        }



        private void manageNVBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*
            if (Program.isLogin() == false)
            {
                MessageBox.Show("Bạn cần đăng nhập!", "", MessageBoxButtons.OK);
                return;
            }
            */
            Form frm = this.CheckExists(typeof(fmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                fmNhanVien f = new fmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void logoutBarBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Program.username != "")
                {
                    closeFormsWhenLogout();
                    Program.conn.Close();
                    Program.connectStr = "";
                    Program.username = "";
                    Program.mlogin = "";
                    Program.mHoTen = "";
                    Program.mGroup = "";
                    MANV.Text = "Mã NV: " + Program.username;
                    HOTEN.Text = "Họ tên: " + Program.mHoTen;
                    NHOM.Text = "Nhóm: " + Program.mGroup;
                    baoCaoRib.Visible = nghiepVuRib.Visible = false;


                    MessageBox.Show("Đăng xuất thành công", "", MessageBoxButtons.OK);

                }
            }
            catch (Exception ex){
                MessageBox.Show("Đăng xuất thất bại. Lỗi:\n" + ex.Message, "", MessageBoxButtons.OK);
            }

        }

        private void guiRutTienBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGoiRutTien));
            if (frm != null) frm.Activate();
            else
            {
                frmGoiRutTien f = new frmGoiRutTien();
                f.MdiParent = this;
                f.Show();
            }
        }


        private void chuyenTienBarActionBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmChuyenKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmChuyenKhoan f = new frmChuyenKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void saoKeBarBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmRp_SaoKe));
            if (frm != null) frm.Activate();
            else
            {
                frmRp_SaoKe f = new frmRp_SaoKe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void closeFormsWhenLogout()
        {
            Form frm = this.CheckExists(typeof(fmNhanVien));
            if (frm != null) frm.Dispose();
            Form frmGR = this.CheckExists(typeof(frmGoiRutTien));
            if (frmGR != null) frmGR.Dispose();
            Form frmCK = this.CheckExists(typeof(frmChuyenKhoan));
            if (frmCK != null) frmCK.Dispose();
            Form frmSK = this.CheckExists(typeof(frmRp_SaoKe));
            if (frmSK != null) frmSK.Dispose();

        }

        private void createAccountBarBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaiKhoan f = new frmTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void managekh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(fmKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                fmKhachHang f = new fmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThongKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(fmThongKe));
            if (frm != null) frm.Activate();
            else
            {
                fmThongKe f = new fmThongKe();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
