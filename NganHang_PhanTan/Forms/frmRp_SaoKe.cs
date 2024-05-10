using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NganHang_PhanTan.Report;
namespace NganHang_PhanTan
{

    public partial class frmRp_SaoKe : Form
    {
        private string hoten;

        public frmRp_SaoKe()
        {
            InitializeComponent();
        }

        private void nameOfSTKOwnerTxt_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            string stk = stkTxt.Text.Trim();
            string dateStart = dateStartDE.DateTime.Date.ToString("yyyy-MM-dd");
            string dateEnd = dateEndDE.DateTime.Date.ToString("yyyy-MM-dd");
            DateTime dateEndDT = dateEndDE.DateTime;
            XtraReport1 rpt = new XtraReport1(stk, dateStart, dateEnd);

            rpt.lbTieuDe.Text = "SAO KÊ TÀI KHOẢN " + stk + " TỪ " + dateStart +" ĐẾN " + dateEnd;


            rpt.lbHoTen.Text = hoten;
            ReportPrintTool print = new ReportPrintTool(rpt);

            print.ShowPreviewDialog();
        }

        private void stkTxt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void stkTxt_EnabledChanged(object sender, EventArgs e)
        {
  
        }

        private void stkTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (stkTxt.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Stk không được để trống", "", MessageBoxButtons.OK);
                    stkTxt.Focus();
                    return;
                }
                string execStr = "EXEC SP_LayTTKH " + stkTxt.Text.Trim();
                SqlDataReader dr = Program.ExecSqlDataReader(execStr);
                dr.Read();
                if (dr.IsDBNull(0))
                {
                    MessageBox.Show("Stk không tồn tại", "", MessageBoxButtons.OK);
                    stkTxt.Focus();
                    return;
                }
                nameSTKTxt.Text = dr.GetString(0);
                hoten = dr.GetString(0);
                String a = "";
                if (!dr.IsDBNull(1))
                {
                    a = dr.GetDecimal(1).ToString("F0");
                    // Tiếp tục xử lý với giá trị của 'a' ở đây
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
