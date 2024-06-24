using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;


namespace NganHang_PhanTan
{
    public partial class fmThongKe : DevExpress.XtraEditors.XtraForm
    {
        public fmThongKe()
        {
            InitializeComponent();
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChiNhanh.SelectedValue == null) return;
            if (cbbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cbbChiNhanh.SelectedValue.ToString();

            if (cbbChiNhanh.SelectedIndex != 0)
            {
                Program.mlogin = Program.remoteLogin;
                Program.mpassword = Program.remotePassword;
            }
            else
            {
                Program.mlogin = Program.login;
                Program.mpassword = Program.password;
            }
            bool rs = db_connect.KTDangNhap(Program.mlogin, Program.mpassword);
            if (!rs)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                //try
                //{
                //    btnDSGiaoDich.Enabled = true;
                //    this.sP_DS_TAIKHOANTableAdapter.Connection.ConnectionString = Program.connectionstring;
                //    this.sP_DS_TAIKHOANTableAdapter.Fill(this.cN_NGANHANG.SP_DS_TAIKHOAN);
                //}
                //catch (System.Data.SqlClient.SqlException ex)
                //{
                //    btnDSGiaoDich.Enabled = false;
                //    return;
                //}

            }
        }
   

        private void rbtnHienTai_CheckedChanged(object sender, EventArgs e)
        {
            rbtnTatCa.Checked = !rbtnHienTai.Checked;
        }

        private void rbtnTatCa_CheckedChanged(object sender, EventArgs e)
        {
            rbtnHienTai.Checked = !rbtnTatCa.Checked;
        }

        private void rbtnGiaoDich_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGiaoDich.Checked)
            {
                rbtnTaiKhoan.Checked = rbtnKhachHang.Checked = false;
            }

        }

        private void rbtnTaiKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTaiKhoan.Checked)
            {
                rbtnGiaoDich.Checked = rbtnKhachHang.Checked = false;
            }
        }

        private void rbtnKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKhachHang.Checked)
            {
                rbtnGiaoDich.Checked = rbtnTaiKhoan.Checked = false;
            }

        }

        private void btnPreView_Click(object sender, EventArgs e)
        {
            string quyen = "CHINHANH";
            if (rbtnTatCa.Checked == true)
            {
                quyen = "NGANHANG";
            }

            if (rbtnKhachHang.Checked == true)
            {
                fmThongKeKhachHang rpt = new fmThongKeKhachHang(quyen);
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            else if (rbtnTaiKhoan.Checked == true)
            {

                fmThongKe_TK thongke_TK = new fmThongKe_TK(quyen);
                thongke_TK.Owner = this;
                thongke_TK.Show();

            }
            else if (rbtnGiaoDich.Checked == true)
            {

            }

        }

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiNhanhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void fmThongKe_Load(object sender, EventArgs e)
        {
            rbtnHienTai.Checked = true;
            rbtnGiaoDich.Checked = true;
            cbbChiNhanh.DataSource = Program.dspmBdS;
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";

            if (Program.mGroup.Trim() == "CHINHANH")
            {
                cbbChiNhanh.Enabled = false;
                rbtnTatCa.Enabled = false;
                rbtnHienTai.Enabled = false;
            }

        }
    }
}