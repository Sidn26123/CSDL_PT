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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                System.Console.WriteLine("connect str: " + Program.connectStr);
                // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.nhanVienTableAdapter.FillByMaCN(this.dS.NhanVien, Program.idDataSource[Program.CNIndex]);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String manv = maNVTxt.Text.Trim();
            System.Console.WriteLine("abc: " + manv);

            try
            {
                System.Console.WriteLine("abc");

                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                if (!string.IsNullOrEmpty(manv))
                {
                    System.Console.WriteLine("abc");
                    using (SqlCommand command = new SqlCommand("SP_TaoLogin", Program.conn))
                    {
                        // Xác định kiểu command là stored procedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        command.Parameters.AddWithValue("@LGNAME", manv);
                        command.Parameters.AddWithValue("@PASS", "2612");
                        command.Parameters.AddWithValue("@USERNAME", manv);
                        command.Parameters.AddWithValue("@ROLE", Program.mGroup);
                        System.Console.WriteLine("abc");
                        if (Program.conn.State == ConnectionState.Closed)
                        {
                            Program.conn.Open();
                        }
                        // Thêm tham số output để lấy giá trị return
                        SqlParameter returnValue = new SqlParameter();
                        returnValue.Direction = ParameterDirection.ReturnValue;
                        command.Parameters.Add(returnValue);
                        System.Console.WriteLine("abc");

                        // Thực thi command
                        command.ExecuteNonQuery();
                        System.Console.WriteLine("abc");
                        int result = (int)returnValue.Value;

                        System.Console.WriteLine("Return value: " + result);

                        Program.conn.Close();
                    }
                }
                MessageBox.Show("Tạo tài khoản cho " + manv+ " thành công.\n", "", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo tài khoản cho nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

        }


            
    }
}
