using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NganHang_PhanTan
{
    public partial class fmThongKeKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public fmThongKeKhachHang(string quyen)
        {
            InitializeComponent();
            this.sP_THONGKE_KHACHHANGTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.sP_THONGKE_KHACHHANGTableAdapter.Fill(this.DS.SP_THONGKE_KHACHHANG);
        }

    }
}
