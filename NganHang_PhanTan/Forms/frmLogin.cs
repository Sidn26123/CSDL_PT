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

namespace NganHang_PhanTan
{
    public partial class frmLogin : Form
    {
        private SqlConnection conPub = new SqlConnection();

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conPub.State == ConnectionState.Closed) conPub.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conPub);
            da.Fill(dt);
            conPub.Close();
            Program.dspmBdS.DataSource = dt;
            CNcombox.DataSource = Program.dspmBdS;
            CNcombox.DisplayMember = "TENCN";
            CNcombox.ValueMember = "TENSERVER";



        }
        private int getKetNoi()
        {
            if (conPub != null && conPub.State == ConnectionState.Open)
            {
                conPub.Close();
            }
            try
            {
                conPub.ConnectionString = Program.connectStr_Pub;
                System.Console.WriteLine("con");
                conPub.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối tới DB.\n Kiểm tra lại tên server của publisher và tên CSDL trong DB");
                return 0;
            }
        }

        public frmLogin()
        {
            InitializeComponent();
            accountTxt.Text = "NV0003";
            passTxt.Text = "2612";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (getKetNoi() == 0) return;
            LayDSPM("SELECT * FROM Get_Subscribers");
            CNcombox.SelectedIndex = 1;
            CNcombox.SelectedIndex = 0;
        }

        private void CNcombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = CNcombox.SelectedValue.ToString();
                Program.CNIndex = CNcombox.SelectedIndex;
            }
            catch (Exception)
            {

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            
            Close();
            Program.frmChinh.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (Program.username.Trim() != "")
            {
                MessageBox.Show("Bạn đã đăng nhập", "", MessageBoxButtons.OK);
                return;
            }

            if (accountTxt.Text.Trim() == "" || passTxt.Text.Trim() == "")
            {
                MessageBox.Show("Login name và pass không được để trống", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = accountTxt.Text;
            Program.mpassword = passTxt.Text;
            if (Program.KetNoi() == 0) return;

            Program.CN = CNcombox.SelectedValue.ToString();
            System.Console.WriteLine(Program.CN);
            Program.login = Program.mlogin;
            Program.password = Program.mpassword;

            String execStr = "EXEC SP_LayThongTinNhanVien '" + Program.login + "'";

            Program.myReader = Program.ExecSqlDataReader(execStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login nhập không có quyền");
                return;
            }

            Program.mHoTen = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(3);
            Program.myReader.Close();
            Program.conn.Close();

            Program.frmChinh.MANV.Text = "Ma NV : " + Program.username;
            Program.frmChinh.HOTEN.Text = "Ho Ten: " + Program.mHoTen;
            Program.frmChinh.NHOM.Text = "Nhom: " + Program.mGroup;
            Program.frmChinh.showMenu();

            //MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OK);
            loginBtn.Enabled = false;
            Close();
        }
    }
}
