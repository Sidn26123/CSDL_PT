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
    public partial class frmGoiRutTien : Form
    {
        public frmGoiRutTien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void takeActionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String stk = stkTextEdit.Text.Trim();
                String sotien = soTienTextEdit.EditValue.ToString().Trim(); //Nếu lấy như bt thì sẽ có dấu ,  => lỗi nhiều argemunt
                String loaiGD = "";
                object selectedValue = loaiGDRadioGroup.EditValue;
                if (selectedValue != null)
                {
                    loaiGD = selectedValue.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại giao dịch!", "", MessageBoxButtons.OK);
                    return;
                }

                if (stk.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập stk!", "", MessageBoxButtons.OK);
                    return;
                }
                if (sotien.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập số tiền!", "", MessageBoxButtons.OK);
                    return;
                }
                String sqlStr = "SP_GDGoiRut " + stk + ", " + loaiGD + ", " + sotien + ", " + Program.username;
                
                Program.ExecSqlQuery(sqlStr, Program.connectStr);
                
                MessageBox.Show("Giao dịch thành công!", "", MessageBoxButtons.OK);

                updateTTKH();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void stkTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void soTienTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmGoiRutTien_Load(object sender, EventArgs e)
        {

        }

        private void amountMoneyTxt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void stkTextEdit_Leave(object sender, EventArgs e)
        {
            String stk = stkTextEdit.Text.Trim();
            if (stk == "")
            {
                return;
            }
            if (FormatValidator.isSTKInputValid(stk))
            {
                updateTTKH();

            }
            else
            {
                MessageUtil.ShowErrorMsgDialog("STK không hợp lệ");
                stkTextEdit.Focus();
            }
        }

        private void updateTTKH()
        {
            try
            {
                /*
                if (FormatValidator.isSTKInputValid(stkTextEdit.Text.Trim())){
                    MessageUtil.ShowErrorMsgDialog("Số tài khoản không hợp lệ");
                    stkTextEdit.Focus();
                }
                */
                String ex = "EXEC SP_LayTTKH " + stkTextEdit.Text;
                SqlDataReader dr = Program.ExecSqlDataReader(ex);
                dr.Read();
                String moneyTxt = "";
                nameOfSTKOwnerTxt.Text = "";
                amountMoneyTxt.Text = "";
                if (!dr.IsDBNull(1))
                {
                    nameOfSTKOwnerTxt.Text = dr.GetString(0);
                    moneyTxt = dr.GetDecimal(1).ToString("F0");
                    amountMoneyTxt.Text = MoneyUtil.formatMoneyStr(moneyTxt, ",");

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("ex: " + ex.Message);
                MessageUtil.ShowErrorMsgDialog("STK không tồn tại");
                stkTextEdit.Focus();
            }
        }
    }
}
