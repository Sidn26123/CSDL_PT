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
using NganHang_PhanTan.Util;
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
            if (string.IsNullOrEmpty(stkTxt.Text.Trim()) || string.IsNullOrEmpty(dateStartDE.Text.Trim()) || string.IsNullOrEmpty(dateEndDE.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ!", "", MessageBoxButtons.OK);
                return; // Nếu có trường nào thiếu thông tin, thoát khỏi phương thức
            }
            string stk = stkTxt.Text.Trim();
            string dateStart = "";
            string dateEnd = "";
            try
            {
                 dateStart = dateStartDE.DateTime.Date.ToString("yyyy-MM-dd");
                 dateEnd = dateEndDE.DateTime.Date.ToString("yyyy-MM-dd");
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng format!", "", MessageBoxButtons.OK);
                return;
            }
            DateTime dateEndDT = dateEndDE.DateTime;
            System.Console.WriteLine("date: " + dateStart);

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
            String stk = stkTxt.Text.Trim();
            if (stk == "")
            {
                return;
            }
            else if ( !FormatValidator.isSTKInputValid(stk))
            {
                MessageUtil.ShowErrorMsgDialog("STK không hợp lệ (STK chỉ chứa số)");
                stkTxt.Focus();
                return;
            }
            try
            {

                string execStr = "EXEC SP_LayTTKH " + stkTxt.Text.Trim();
                SqlDataReader dr = Program.ExecSqlDataReader(execStr);
                dr.Read();
                nameSTKTxt.Text = "";

                if (dr.IsDBNull(0))
                {
                    MessageBox.Show("Stk không tồn tại", "", MessageBoxButtons.OK);
                    stkTxt.Focus();
                    return;
                }
                nameSTKTxt.Text = dr.GetString(0);
                hoten = dr.GetString(0);
                /*
                String a = "";
                if (!dr.IsDBNull(1))
                {
                    a = dr.GetDecimal(1).ToString("F0");
                    // Tiếp tục xử lý với giá trị của 'a' ở đây
                }
                */
                dr.Close();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
