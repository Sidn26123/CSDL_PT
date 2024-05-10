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
using NganHang_PhanTan.Util;

namespace NganHang_PhanTan
{
    public partial class frmChuyenKhoan : Form
    {
        public frmChuyenKhoan()
        {
            InitializeComponent();
        }


        private void takeActionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String stkChuyen = stkChuyenTextEdit.Text.Trim();
                String stkDich = stkDichTextEdit.Text.Trim();
                String soTien = sotienTextEdit.EditValue.ToString().Trim();

                System.Console.WriteLine(soTien);
                if (stkChuyen.Length == 0 || stkDich.Length == 0 || soTien.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập thông tin đầy đủ!", "", MessageBoxButtons.OK);
                    return;
                }

                String sqlStr = "EXEC SP_GDChuyenKhoan " + stkChuyen + ", " + stkDich + ", " + soTien + ", " + Program.username;
                Program.ExecSqlQuery(sqlStr, Program.connectStr);

                System.Console.WriteLine(sqlStr);
                MessageBox.Show("Giao dịch thành công!", "", MessageBoxButtons.OK);
                String ex = "EXEC SP_LayTTKH " + stkChuyenTextEdit.Text.Trim();
                SqlDataReader dr = Program.ExecSqlDataReader(ex);
                dr.Read();
                nameOfSTKOwnerTxt.Text = dr.GetString(0);
                String a = "";
                if (!dr.IsDBNull(1))
                {
                    a = dr.GetDecimal(1).ToString("F0");
                    // Tiếp tục xử lý với giá trị của 'a' ở đây
                }
                amountTKChuyenTxt.Text = MoneyUtil.formatMoneyStr(a, ",");
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void stkChuyenTextEdit_Leave(object sender, EventArgs e)
        {
            /*
            nameOfSTKOwnerTxt.Text;
            amountTKChuyenTxt;
            nameOfSTKDichTxt
            */
            if (stkChuyenTextEdit.Text == "")
            {
                return;
            }

            try
            {
                String ex = "EXEC SP_LayTTKH " + stkChuyenTextEdit.Text;
                SqlDataReader dr = Program.ExecSqlDataReader(ex);
                dr.Read();
                nameOfSTKOwnerTxt.Text = dr.GetString(0);
                String a = "";
                if (!dr.IsDBNull(1))
                {
                    a = dr.GetDecimal(1).ToString("F0");
                }
                amountTKChuyenTxt.Text = MoneyUtil.formatMoneyStr(a, ",");
                dr.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void sotienTextEdit_Leave(object sender, EventArgs e)
        {

        }

        private void stkDichTextEdit_Leave(object sender, EventArgs e)
        {
            String ex = "EXEC SP_LayTTKH " + stkDichTextEdit.Text;
            SqlDataReader dr = Program.ExecSqlDataReader(ex);
            dr.Read();
            nameOfSTKDichTxt.Text = dr.GetString(0);
            String a = "";
            if (!dr.IsDBNull(1))
            {
                a = dr.GetDecimal(1).ToString("F0");
                // Tiếp tục xử lý với giá trị của 'a' ở đây
            }
            dr.Close();

        }
    }
}
