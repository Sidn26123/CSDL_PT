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
namespace NganHang_PhanTan.SubForm
{
    public partial class sfrmChuyenNV : Form
    {

        private string MaNVChuyen;
        private string hoten;
        public sfrmChuyenNV(string MaNV, string hoten)
        {
            InitializeComponent();
            this.MaNVChuyen = MaNV;
            this.hoten = hoten;
        }

        private void chuyenCNBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedBrandId = ((DataRowView)sP_LayDsChiNhanhKhacBindingSource[sP_LayDsChiNhanhKhacBindingSource.Position])["MACN"].ToString();
                if (MessageUtil.ShowWarnConfirmDialog("Xác nhận chuyển nhân viên?") == DialogResult.OK)
                {
                    string query = "EXEC dbo.sp_ChuyenNhanVien " + MaNVChuyen.ToString().Trim() + ", " + selectedBrandId;

                    Program.ExecSqlQuery(query, Program.connectStr);
                    System.Console.WriteLine(query);
                    /*
                    SqlDataReader s = Program.ExecSqlDataReader(query);
                    s.Read();

                    System.Console.WriteLine(s.GetString(0));
                    */
                    MessageUtil.ShowInfoMsgDialog("Chuyển nhân viên thành công");
                }
            }
            catch (Exception ex)
            {
                MessageUtil.ShowErrorMsgDialog("Có lỗi!\n" + ex.Message);
                return;
            }
        }

        private void sfrmChuyenNV_Load(object sender, EventArgs e)
        {

            if (Program.conn == null) return;

            this.sP_LayDsChiNhanhKhacTableAdapter.Connection.ConnectionString = Program.connectStr;

            this.sP_LayDsChiNhanhKhacTableAdapter.Fill(this.DS.SP_LayDsChiNhanhKhac);
            chuyenCNBtn.Enabled = this.sP_LayDsChiNhanhKhacBindingSource.Count > 0;
            MaNVTxt.Text = this.MaNVChuyen;
            HoTenNVTxt.Text = this.hoten;
            CNHienTaiTxt.Text = Program.CN;
        }

        private void sP_LayDsChiNhanhKhacBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
