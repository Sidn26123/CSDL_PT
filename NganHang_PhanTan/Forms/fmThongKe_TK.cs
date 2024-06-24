using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang_PhanTan
{
    public partial class fmThongKe_TK : DevExpress.XtraEditors.XtraForm
    {
        String quyen = "";
        public fmThongKe_TK(string quyen)
        {
            this.quyen = quyen;
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            fmThongKeTaiKhoan rpt = new fmThongKeTaiKhoan(quyen, ngayBatDauTK.Value, ngayKetThucTK.Value);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiNhanhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void fmThongKe_TK_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }

        private void fmThongKe_TK_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}