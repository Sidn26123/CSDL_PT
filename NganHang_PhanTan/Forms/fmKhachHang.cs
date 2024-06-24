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
    public partial class fmKhachHang : Form
    {
        String maCn = "";
        private string CMNDKhachHangTruoc = "";
        private bool themKhachHang = false;
        int vitri = 0;
        public fmKhachHang()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void fmKhachHang_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connectStr;
            // TODO: This line of code loads data into the 'DS.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.DS.KhachHang);

            maCn = ((DataRowView)bdsKH[0])["MaCN"].ToString();
            cbChiNhanh.DataSource = Program.dspmBdS;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.SelectedIndex = Program.CNIndex;
            btnPhucHoi.Enabled = true;
            btnSua.Enabled = btnMoTaiKhoan.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLuu.Enabled = true;
            Console.WriteLine("fmKhachHang_Load: Các nút được bật");
            maChiNhanh.Enabled = SDTKhachHang.Enabled = gioiTinh.Enabled = hoKhachHang.Enabled = tenKhachHang.Enabled = ngayCapCMND.Enabled = CMNDKhachHang.Enabled = diaChiKH.Enabled = false;
            if (Program.mGroup == "NganHang")
            {
                cbChiNhanh.Enabled = true;
            }

            else if (Program.mGroup == "ChiNhanh" || Program.mGroup == "db_owner")
            {
                btnSua.Enabled = btnMoTaiKhoan.Enabled = btnXoa.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnLuu.Enabled = true;
                cbChiNhanh.Enabled = true;
            }
        }

        bool kiemTraSo(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CMNDKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập sô chứng minh khách hàng", "", MessageBoxButtons.OK);
                CMNDKhachHang.Focus();
                return;
            }
            else if (!kiemTraSo(CMNDKhachHang.Text.Trim()))
            {
                MessageBox.Show("Định dạng CMND chưa phù hợp! Vui lòng nhập lại", "", MessageBoxButtons.OK);
                CMNDKhachHang.Focus();
                return;
            }
            else if (CMNDKhachHang.Text.Trim().Length != 9 && CMNDKhachHang.Text.Trim().Length != 12)
            {
                MessageBox.Show("CMND phải có 9 hoặc 12 ký tự", "", MessageBoxButtons.OK);
                CMNDKhachHang.Focus();
                return;
            }
            else if (hoKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập họ khách hàng", "", MessageBoxButtons.OK);
                hoKhachHang.Focus();
                return;
            }
            else if (hoKhachHang.Text.Length > 50)
            {
                MessageBox.Show("Họ khách hàng chứa tối đa là 50 kí tự");
                hoKhachHang.Focus();
                return;
            }
            else if (tenKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "", MessageBoxButtons.OK);
                tenKhachHang.Focus();
                return;
            }
            else if (tenKhachHang.Text.Length > 10)
            {
                MessageBox.Show("Tên khách hàng chứa tối đa 10 kí tự");
                tenKhachHang.Focus();
                return;
            }
            else if (diaChiKH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "", MessageBoxButtons.OK);
                diaChiKH.Focus();
                return;
            }
            else if (diaChiKH.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ khách hàng chứa tối đa 100 kí tự");
                diaChiKH.Focus();
                return;
            }
            else if (SDTKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng", "", MessageBoxButtons.OK);
                SDTKhachHang.Focus();
                return;
            }
            else if (!kiemTraSo(SDTKhachHang.Text))
            {
                MessageBox.Show("Định dạng số điện thoại chưa phù hợp! Vui lòng nhập lại", "", MessageBoxButtons.OK);
                SDTKhachHang.Focus();
                return;
            }
            else if (SDTKhachHang.Text.Length > 15)
            {
                MessageBox.Show("Số điện thoại chứa tối đa là 15 số");
                SDTKhachHang.Focus();
                return;
            }

            else
            {
                string cmndkh = CMNDKhachHang.Text;
                // MessageBox.Show(KT_KhachHang.KiemTraSoCMND(CMNDKhachHang.Text).ToString());
              /*  if ((!cmndkh.Equals(CMNDKhachHangTruoc) && (CMNDKhachHangTruoc != "")) || (themKhachHang == true))
                {
                    //MessageBox.Show("hello " + CMNDKhachHangTruoc);*/

                    if (KT_KhachHang.KiemTraSoCMND(CMNDKhachHang.Text) == 0)
                    {
                      
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                    Console.WriteLine("btnThem.Enabled, btnSua.Enabled, btnXoa.Enabled = true");
                    maChiNhanh.Enabled = diaChiKH.Enabled = hoKhachHang.Enabled = CMNDKhachHang.Enabled = SDTKhachHang.Enabled = tenKhachHang.Enabled = gioiTinh.Enabled = ngayCapCMND.Enabled = false;
                        bdsKH.EndEdit();
                        bdsKH.ResetCurrentItem();
                        this.khachHangTableAdapter.Connection.ConnectionString = Program.connectStr;
                        this.khachHangTableAdapter.Update(this.DS);
                        khachHangGridControl.Enabled = true;
                        themKhachHang = false;
                        btnMoTaiKhoan.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Số CMND bị trùng! Vui lòng nhập lại");
                    }
               /* }
                else
                {
                    // MessageBox.Show(CMNDKhachHangTruoc);
                    
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                    maChiNhanh.Enabled = diaChiKH.Enabled = hoKhachHang.Enabled = CMNDKhachHang.Enabled = SDTKhachHang.Enabled = tenKhachHang.Enabled = gioiTinh.Enabled = ngayCapCMND.Enabled = false;
                    bdsKH.EndEdit();
                    bdsKH.ResetCurrentItem();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.khachHangTableAdapter.Update(this.DS);
                    khachHangGridControl.Enabled = true;
                    btnMoTaiKhoan.Enabled = true;
                }
*/


            }






            /* try
             {
                 bdsKH.EndEdit();
                 bdsKH.ResetCurrentItem();
                 this.khachHangTableAdapter.Connection.ConnectionString = Program.connectStr;
                 this.khachHangTableAdapter.Update(this.DS.KhachHang);
                 //reloadBtn.Enabled = true;
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Lỗi lưu khach hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                 return;
             }

             khachHangGridControl.Enabled = true;
             btnPhucHoi.Enabled = true;
             btnSua.Enabled = btnMoTaiKhoan.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLuu.Enabled = false;
             btnThem.Enabled  = btnXoa.Enabled =  true;
             btnLuu.Enabled = false;

             groupBox1.Enabled = false;*/





        }

        // XONG
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*btnSua.Enabled = btnXoa.Enabled = false;
            btnThem.Enabled = false;
            diaChiKH.Enabled = hoKhachHang.Enabled = CMNDKhachHang.Enabled = SDTKhachHang.Enabled = tenKhachHang.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = ngayCapCMND.Enabled = true;
            btnMoTaiKhoan.Enabled = false;
            gridView1.AddNewRow();
            maChiNhanh.Text = ((DataRowView)bdsKH[0])["MaCN"].ToString();
            khachHangGridControl.Enabled = false;
            themKhachHang = true;
            gioiTinhNam.Checked = true;*/

            vitri = bdsKH.Position;
            groupBox1.Enabled = true;
            bdsKH.AddNew();
            maChiNhanh.Text = ((DataRowView)bdsKH[0])["MACN"].ToString();
            diaChiKH.Enabled = hoKhachHang.Enabled = CMNDKhachHang.Enabled = SDTKhachHang.Enabled = tenKhachHang.Enabled = gioiTinh.Enabled= ngayCapCMND.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled= false;
            Console.WriteLine("btnSua.Enabled, btnXoa.Enabled = false");
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            khachHangGridControl.Enabled = false;
        }

        //XONG
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*CMNDKhachHangTruoc = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString();
            btnMoTaiKhoan.Enabled = false;
            khachHangGridControl.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = false;
            btnSua.Enabled = false;
            CMNDKhachHang.Enabled = false;
            diaChiKH.Enabled = hoKhachHang.Enabled = SDTKhachHang.Enabled = tenKhachHang.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = ngayCapCMND.Enabled = true;
        */
            vitri = bdsKH.Position;
            groupBox1.Enabled = true;
            diaChiKH.Enabled = hoKhachHang.Enabled = SDTKhachHang.Enabled = tenKhachHang.Enabled = gioiTinh.Enabled = ngayCapCMND.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            Console.WriteLine("btnThem.Enabled, btnXoa.Enabled = false");
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            khachHangGridControl.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin khách hàng", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (KT_KhachHang.KiemTraXoaKhachHang(CMNDKhachHang.Text) == 0)
                {


                    gridView1.DeleteSelectedRows();
                    bdsKH.EndEdit();
                    bdsKH.ResetCurrentItem();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.khachHangTableAdapter.Update(this.DS);
                    khachHangGridControl.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Không thể xóa khách hàng vì khách hàng đã tồn tại tài khoản");
                    return;
                }
            }
        }

        //XONG
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKH.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsKH.Position = vitri;
            }
            khachHangGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
            Console.WriteLine("btnThem.Enabled, btnSua.Enabled, btnXoa.Enabled = true");

        }

        private void btnMoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           

            fmMoTaiKhoanKH moTaiKhoan = new fmMoTaiKhoanKH(maChiNhanh.Text);
            moTaiKhoan.Owner = this;
            moTaiKhoan.Show();
            
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Console.WriteLine("btnThem.Enabled, btnSua.Enabled, btnXoa.Enabled = true");
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }


        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbChiNhanh.DataSource = Program.dspmBdS;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            System.Console.WriteLine("combox: " + cbChiNhanh.SelectedValue.ToString());
            if (cbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                System.Console.WriteLine(":" + Program.servername);
                return;
            }

            Program.servername = cbChiNhanh.SelectedValue.ToString();
            System.Console.WriteLine("P:" + Program.servername);
            if (cbChiNhanh.SelectedIndex != Program.CNIndex)
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
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.khachHangTableAdapter.Fill(this.DS.KhachHang);
                
            }
        }

       

        

        private void Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.khachHangTableAdapter.Fill(this.DS.KhachHang);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
