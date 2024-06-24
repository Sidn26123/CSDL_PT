using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NganHang_PhanTan
{
    public partial class fmThongKeTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public fmThongKeTaiKhoan(string quyen, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            InitializeComponent();
            lbNgayGD.Text = "(Từ ngày " + ngaybatdau.ToString().Substring(0, 10) + " đến ngày " + ngayketthuc.ToString().Substring(0, 10) + ")";
            this.sP_THONGKE_TAIKHOANTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.sP_THONGKE_TAIKHOANTableAdapter.Fill(this.DS.SP_THONGKE_TAIKHOAN, ngaybatdau, ngayketthuc);

        }

    }
}
