using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang_PhanTan
{
    public partial class fmNhanVien : Form
    {
        String maCn = "";
        int vitri = 0;
        public fmNhanVien()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.NV_BdS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void fmNhanVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.NhanVienTableAdapter.Fill(this.DS.NhanVien);
            // TODO: This line of code loads data into the 'DS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.GD_CTTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.GD_CTTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
            // TODO: This line of code loads data into the 'DS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.GD_GRTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.GD_GRTableAdapter.Fill(this.DS.GD_GOIRUT);

            maCn = ((DataRowView)NV_BdS[0])["MaCN"].ToString();
            CNCombox.DataSource = Program.dspmBdS;
            CNCombox.DisplayMember = "TENCN";
            CNCombox.SelectedIndex = Program.CNIndex;

            addBtn.Enabled = deleteBtn.Enabled = modifyBtn.Enabled = undoBtn.Enabled = saveBtn.Enabled = cancelActionBtn.Enabled = false;

            if (Program.mGroup == "NganHang")
            {
                CNCombox.Enabled = true;
            }

            else if (Program.mGroup == "ChiNhanh" || Program.mGroup == "db_owner") ;
            {
                addBtn.Enabled = deleteBtn.Enabled = modifyBtn.Enabled = undoBtn.Enabled = saveBtn.Enabled = true;
                CNCombox.Enabled = true;
            }
        }

        private void nhanVienGridControl_Click(object sender, EventArgs e)
        {

        }

        private void hOLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_DockChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = NV_BdS.Position;
            groupBox1.Enabled = true;
            NV_BdS.AddNew();
            MaCNTextEdit.Text = maCn;

            addBtn.Enabled = deleteBtn.Enabled = modifyBtn.Enabled = reloadBtn.Enabled =  false;
            cancelActionBtn.Enabled = saveBtn.Enabled = undoBtn.Enabled = true;
            NVGridControll.Enabled = false;
        }

        private void undoBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NV_BdS.CancelEdit();
            if (addBtn.Enabled == false)
            {
                NV_BdS.Position = vitri;
            }
            NVGridControll.Enabled = true;
            groupBox1.Enabled = false;
            addBtn.Enabled = deleteBtn.Enabled = modifyBtn.Enabled = exitBtn.Enabled = true;
            saveBtn.Enabled = undoBtn.Enabled = cancelActionBtn.Enabled = false;
        }

        private void modifyBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = NV_BdS.Position;
            groupBox1.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = modifyBtn.Enabled = undoBtn.Enabled = reloadBtn.Enabled = exitBtn.Enabled =  false;
            saveBtn.Enabled = undoBtn.Enabled = cancelActionBtn.Enabled = true;
            NVGridControll.Enabled = false;
        }

        private void reloadBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Console.WriteLine("L: " + Program.servername);
            try
            {
                this.NhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.NhanVienTableAdapter.Fill(this.DS.NhanVien);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void saveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MaNVTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống", "", MessageBoxButtons.OK);
                MaNVTextBox.Focus();
                return;
            }


            if (HoTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống", "", MessageBoxButtons.OK);
                HoTextEdit.Focus();
                return;
            }


            if (TenTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống", "", MessageBoxButtons.OK);
                TenTextEdit.Focus();
                return;
            }


            if (CMNDTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("CMND không được để trống", "", MessageBoxButtons.OK);
                CMNDTextEdit.Focus();
                return;
            }
            

            if (PhaiTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Phái không được để trống", "", MessageBoxButtons.OK);
                PhaiTextEdit.Focus();
                return;
            }


            if (SoDTTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được để trống", "", MessageBoxButtons.OK);
                SoDTTextEdit.Focus();
                return;
            }
            else if (SoDTTextEdit.Text.Trim().Length < 9 || SoDTTextEdit.Text.Trim().Length > 12)
            {
                MessageBox.Show("Số điện thoại phải có từ 9 đến 12 ký tự", "", MessageBoxButtons.OK);
                SoDTTextEdit.Focus();
                return;
            }
            else if (!Regex.IsMatch(SoDTTextEdit.Text.Trim(), @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa các ký tự số", "", MessageBoxButtons.OK);
                SoDTTextEdit.Focus();
                return;
            }


            if (CMNDTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("CMND không được để trống", "", MessageBoxButtons.OK);
                CMNDTextEdit.Focus();
                return;
            }
            else if (CMNDTextEdit.Text.Length != 9 && CMNDTextEdit.Text.Length != 12)
            {
                MessageBox.Show("CMND phải có 9 hoặc 12 ký tự", "", MessageBoxButtons.OK);
                CMNDTextEdit.Focus();
                return;
            }
            else if (!Regex.IsMatch(CMNDTextEdit.Text, @"^\d+$"))
            {
                MessageBox.Show("CMND chỉ được chứa các ký tự số", "", MessageBoxButtons.OK);
                CMNDTextEdit.Focus();
                return;
            }

            try
            {
                NV_BdS.EndEdit();
                NV_BdS.ResetCurrentItem();
                this.NhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.NhanVienTableAdapter.Update(this.DS.NhanVien);
                reloadBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            NVGridControll.Enabled = true;
            addBtn.Enabled = modifyBtn.Enabled = deleteBtn.Enabled = reloadBtn.Enabled = exitBtn.Enabled = true;
            saveBtn.Enabled = undoBtn.Enabled = cancelActionBtn.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void exitBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 manv = 0;
            if (GD_GR_BdS.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã từng thực hiện giao dịch gởi rút", "", MessageBoxButtons.OK);
                return;
            }

            if (GD_CT_BdS.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã từng thực hiện giao dịch chuyển tiền", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Xác nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK) ;
            {
                try
                {
                    manv = int.Parse(((DataRowView)NV_BdS[NV_BdS.Position])["MANV"].ToString());
                    NV_BdS.RemoveCurrent();
                    this.NhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.NhanVienTableAdapter.Update(this.DS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa nhân viên! Thử lại lần nữa\n" + ex.Message, "",
                            MessageBoxButtons.OK);
                    this.NhanVienTableAdapter.Fill(this.DS.NhanVien);
                    NV_BdS.Position = NV_BdS.Find("MANV", manv);
                    return;
                }
            }

            if (NV_BdS.Count == 0) deleteBtn.Enabled = false;
        }

        private void CNCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CNCombox.DataSource = Program.dspmBdS;
            CNCombox.DisplayMember = "TENCN";
            CNCombox.ValueMember = "TENSERVER";
            System.Console.WriteLine("combox: " + CNCombox.SelectedValue.ToString());
            if (CNCombox.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                System.Console.WriteLine(":" + Program.servername);
                return;
            }

            Program.servername = CNCombox.SelectedValue.ToString();
            System.Console.WriteLine("P:" + Program.servername);
            if (CNCombox.SelectedIndex != Program.CNIndex)
            {
                Program.mlogin = Program.remoteLogin;
                Program.mpassword = Program.remotePassword;
            }
            else
            {
                Program.mlogin = Program.login;
                Program.mpassword = Program.password;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối tới chi nhánh!", "", MessageBoxButtons.OK);
            }
            else
            {
                this.NhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.NhanVienTableAdapter.Fill(this.DS.NhanVien);
                this.GD_CTTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.GD_CTTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
                this.GD_GRTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.GD_GRTableAdapter.Fill(this.DS.GD_GOIRUT);
            }
        }



        private void cancelActionBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NV_BdS.CancelEdit();
            //NVGridControll.Refresh();
            vitri = vitri--;
            NV_BdS.Position = vitri;
            NVGridControll.Enabled = true;
            groupBox1.Enabled = false;
            addBtn.Enabled = deleteBtn.Enabled = modifyBtn.Enabled = undoBtn.Enabled = exitBtn.Enabled = reloadBtn.Enabled =true;
            saveBtn.Enabled = undoBtn.Enabled = cancelActionBtn.Enabled = false;
        }
    }
}
