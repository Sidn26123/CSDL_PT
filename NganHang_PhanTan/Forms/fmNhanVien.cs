using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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
using NganHang_PhanTan.Util;
using NganHang_PhanTan.SubForm;
using NganHang_PhanTan.Component;
using System.Data.SqlClient;

namespace NganHang_PhanTan
{
    public partial class fmNhanVien : Form
    {
        String maCn = "";
        int vitri = 0;

        private LinkedList<ActionData> undoStack = new LinkedList<ActionData>();
        private LinkedList<ActionData> redoStack = new LinkedList<ActionData>();

        private string lastAcionSaveBtn = "";

        sfrmChuyenNV chuyenNVForm;

        public fmNhanVien()
        {
            InitializeComponent();
        }
        public void closeForm()
        {
            this.Dispose();
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
            this.NhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.NhanVienTableAdapter.FillTe(this.DS.NhanVien);

            this.GD_CTTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.GD_CTTableAdapter.Fill(this.DS.GD_CHUYENTIEN);

            this.GD_GRTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.GD_GRTableAdapter.Fill(this.DS.GD_GOIRUT);

            maCn = ((DataRowView)NV_BdS[0])["MaCN"].ToString();
            CNCombox.DataSource = Program.dspmBdS;
            CNCombox.DisplayMember = "TENCN";
            CNCombox.SelectedIndex = Program.CNIndex;

            BindingSource copyBindingSource = new BindingSource();

            // Sao chép dữ liệu từ dspmBdS sang copyBindingSource
            foreach (var item in Program.dspmBdS.List)
            {
                copyBindingSource.Add(item);
            }

            // Gán copyBindingSource làm DataSource cho changeCNCombox
            changeCNCombox.DataSource = Program.idDataSource;

            enableNormalState();
        }

        private void nhanVienGridControl_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "CMND")
            {
                if (e.DisplayText.Length > 9)
                {
                    e.DisplayText = e.DisplayText.Substring(0, 9);
                }
            }
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
            int posInGid = NV_BdS.Position;
            NV_BdS.AddNew();
            MaCNTextEdit.Text = maCn;

            enableAddState();


            //addToUndo(new ActionData(ActionData.EventType.DELETE, null, posInGid));

            ActionDataControl.ResolveStackStorage(undoStack);
            redoStack.Clear();

            lastAcionSaveBtn = "insert";

        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String manv = ((DataRowView)NV_BdS[NV_BdS.Position])["MaNV"].ToString().Trim();
            NhanVien nv = new NhanVien();

            if (manv.Equals(Program.username))
            {
                MessageUtil.ShowErrorMsgDialog("Không thể tự xóa bản thân.");
                return;
            }
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

            if (MessageUtil.ShowWarnConfirmDialog($"Xác nhận xóa nhân viên có mã số {manv}?") == DialogResult.OK)
            {

                try
                {
                    manv = ((DataRowView)NV_BdS[NV_BdS.Position])["MANV"].ToString();
                    nv = new NhanVien((DataRowView)NV_BdS[NV_BdS.Position]);
                    nv.MaNV = manv;
                    NV_BdS.RemoveCurrent();
                    //this.DS.NhanVien.AcceptChanges();

                    //this.NhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.NhanVienTableAdapter.Update(this.DS.NhanVien);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa nhân viên! Thử lại lần nữa\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.NhanVienTableAdapter.FillTe(this.DS.NhanVien);
                    NV_BdS.Position = NV_BdS.Find("MANV", manv);
                    return;
                }
            }

            addToUndo(new ActionData(ActionData.EventType.INSERT, nv, -1));
            ActionDataControl.ResolveStackStorage(undoStack);

            redoStack.Clear();

            updateActionState();

            chuyeNvBarBTtn.Enabled = deleteBtn.Enabled;

        }

        private void cancelActionBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lưu lại vị trí hiện tại của grid
            int gridPos = NV_BdS.Position;

            // Tạo một đối tượng NhanVien và gán các thuộc tính từ các trường nhập liệu
            NhanVien nv = new NhanVien
            {
                MaNV = MaNVTextBox.Text.Trim(),
                Ho = HoTextEdit.Text.Trim(),
                Ten = TenTextEdit.Text.Trim(),
                SoDT = SoDTTextEdit.Text.Trim(),
                Phai = PhaiTextEdit.Text,
                Cmnd = CMNDTextEdit.Text.Trim(),
                DiaChi = DiaChiTextEdit.Text.Trim(),
                TrangThaiXoa = trangThaiXoaCheckBox.Checked
            };

            // Thêm hành động vào ngăn xếp hoàn tác
            addToUndo(new ActionData(ActionData.EventType.CANCEL_EDIT, nv, gridPos));

            // Hủy chỉnh sửa và làm mới grid
            NV_BdS.CancelEdit();
            NVGridControll.Refresh();

            //NVGridControll.Enabled = true;
            //groupBox1.Enabled = false;
            MaNVTextBox.Enabled = false;
            cancelActionBtn.Enabled = false;
            // Kích hoạt các nút chức năng

            // Ẩn các điều khiển chuyển chi nhánh
            chuyenCNGroupBox.Visible = false;

            // Cài đặt lại kết nối và tải dữ liệu
            this.NhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.NhanVienTableAdapter.FillTe(this.DS.NhanVien);



            // Xóa ngăn xếp hoàn tác và làm mới trạng thái của nút hoàn tác và nút làm lại
            redoStack.Clear();
            NV_BdS.Position = gridPos;
            enableNormalState();
        }
        
        private void saveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Chứa thông tin nhân viên để có thể restore lại
            NhanVien nv = new NhanVien();
            string manv = "";
            int gridPos = NV_BdS.Position;
            System.Console.WriteLine("type: " + lastAcionSaveBtn + " at: " + gridPos);
            manv = MaNVTextBox.Text.Trim();
            if (!nv.isMaNVValid(manv) && !string.IsNullOrEmpty(manv))
            {
                MessageBox.Show("Mã NV không đúng định dạng! (NV + 0000-9999)", "", MessageBoxButtons.OK);
                MaNVTextBox.Focus();
                return;
            }
            nv.MaNV = manv;
            string honv = HoTextEdit.Text.Trim();
            if (honv == "")
            {
                MessageBox.Show("Họ không được để trống", "", MessageBoxButtons.OK);
                HoTextEdit.Focus();
                return;
            }
            else if (!NameFormatter.IsPureChars(honv))
            {
                MessageBox.Show("Họ không hợp lệ", "", MessageBoxButtons.OK);
                HoTextEdit.Focus();
                return;
            }

            honv = NameFormatter.CapitalizeFirstLetter(NameFormatter.RemoveDuplicateSpace(HoTextEdit.Text.Trim()));
            nv.Ho = honv;
            string tennv = TenTextEdit.Text.Trim();
            if (tennv == "")
            {
                MessageBox.Show("Tên không được để trống", "", MessageBoxButtons.OK);
                TenTextEdit.Focus();
                return;
            }
            else if (!NameFormatter.IsPureChars(tennv))
            {
                MessageBox.Show("Tên không được chứa số", "", MessageBoxButtons.OK);
                TenTextEdit.Focus();
                return;
            }
            tennv = NameFormatter.CapitalizeFirstLetter(NameFormatter.RemoveDuplicateSpace(TenTextEdit.Text.Trim()));
            nv.Ten = tennv;

            string phai = PhaiTextEdit.Text.Trim();
            if (phai == "")
            {
                MessageBox.Show("Phái không được để trống", "", MessageBoxButtons.OK);
                PhaiTextEdit.Focus();
                return;
            }
            nv.Phai = PhaiTextEdit.Text.Trim();

            string sdt = SoDTTextEdit.Text.Trim();

            if ((sdt.Length < 9 || sdt.Length > 12) && sdt.Length > 0)
            {
                MessageBox.Show("Số điện thoại phải có từ 9 đến 12 ký tự", "", MessageBoxButtons.OK);
                SoDTTextEdit.Focus();
                return;
            }
            else if (sdt.Length > 0 && !Regex.IsMatch(sdt, @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa các ký tự số", "", MessageBoxButtons.OK);
                SoDTTextEdit.Focus();
                return;
            }
            nv.SoDT = sdt;

            string cmnd = CMNDTextEdit.Text.Trim();
            if (cmnd == "")
            {
                MessageBox.Show("CMND không được để trống", "", MessageBoxButtons.OK);
                CMNDTextEdit.Focus();
                return;
            }
            else if (cmnd.Length != 9 && cmnd.Length > 0)
            {
                MessageBox.Show("CMND phải có 9 ký tự", "", MessageBoxButtons.OK);
                CMNDTextEdit.Focus();
                return;
            }
            else if (!Regex.IsMatch(cmnd, @"^\d+$"))
            {
                MessageBox.Show("CMND chỉ được chứa các ký tự số", "", MessageBoxButtons.OK);
                CMNDTextEdit.Focus();
                return;
            }
            nv.Cmnd = cmnd;

            nv.DiaChi = DiaChiTextEdit.Text.Trim();

            nv.TrangThaiXoa = trangThaiXoaCheckBox.Checked;
             //NV_BdS.AddNew();
            //Nếu trong trạng thái insert thì cần lấy các thông tin từ phần nhập thông tin nv

            if (lastAcionSaveBtn == "insert")
            {
                try
                {
                    NV_BdS.EndEdit();
                    NV_BdS.ResetCurrentItem();

                    this.NhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                    if (string.IsNullOrEmpty(nv.MaNV))
                    {

                        using (SqlCommand command = new SqlCommand("SP_TaoNVCoOutput", Program.conn))
                        {
                            // Xác định kiểu command là stored procedure
                            command.CommandType = CommandType.StoredProcedure;

                            // Thêm các tham số cho stored procedure
                            command.Parameters.AddWithValue("@MaCN", maCn);
                            command.Parameters.AddWithValue("@Ho", nv.Ho);
                            command.Parameters.AddWithValue("@Ten", nv.Ten);
                            command.Parameters.AddWithValue("@Diachi", nv.DiaChi);
                            command.Parameters.AddWithValue("@CMND", nv.Cmnd);
                            command.Parameters.AddWithValue("@Phai", nv.Phai);
                            command.Parameters.AddWithValue("@SDT", nv.SoDT);

                            // Thêm parameter cho output
                            SqlParameter outputParameter = new SqlParameter();
                            outputParameter.ParameterName = "@MaNVMoi";
                            outputParameter.SqlDbType = SqlDbType.NChar;
                            outputParameter.Size = 10;
                            outputParameter.Direction = ParameterDirection.Output;
                            command.Parameters.Add(outputParameter);

                            // Thực thi command
                            command.ExecuteNonQuery();

                            // Lấy giá trị của biến output
                            string MaNVMoi = command.Parameters["@MaNVMoi"].Value.ToString();
                            MaNVTextBox.Text = MaNVMoi;
                            nv.MaNV = MaNVMoi;
                        }
                    }
                    else
                    {

                        using (SqlCommand command = new SqlCommand("SP_TaoNV", Program.conn))
                        {
                            // Xác định kiểu command là stored procedure
                            command.CommandType = CommandType.StoredProcedure;

                            // Thêm các tham số cho stored procedure
                            command.Parameters.AddWithValue("@MaCN", maCn);
                            command.Parameters.AddWithValue("@MaNV", nv.MaNV);
                            command.Parameters.AddWithValue("@Ho", nv.Ho);
                            command.Parameters.AddWithValue("@Ten", nv.Ten);
                            command.Parameters.AddWithValue("@Diachi", nv.DiaChi);
                            command.Parameters.AddWithValue("@CMND", nv.Cmnd);
                            command.Parameters.AddWithValue("@Phai", nv.Phai);
                            command.Parameters.AddWithValue("@SDT", nv.SoDT);


                            // Thực thi command
                            command.ExecuteNonQuery();

                            // Lấy giá trị của biến output
                        }
                    }
                    MessageBox.Show("Tạo nhân viên thành công.\n", "", MessageBoxButtons.OK);

                    reloadBtn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tạo nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }

            }
            else if (lastAcionSaveBtn == "update")
            {
                try
                {
                    NV_BdS.EndEdit();
                    // Đặt thông tin nhân viên mới lên grid control
                    NV_BdS.ResetCurrentItem();
                    this.NhanVienTableAdapter.Update(this.DS.NhanVien);
                    MessageBox.Show("Chỉnh sửa nhân viên thành công.\n", "", MessageBoxButtons.OK);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            //System.Console.WriteLine("type: " + lastAcionSaveBtn + " " + nv.MaNV + " "+ MaNVTextBox.Text);

            //this.NhanVienTableAdapter.Update(this.DS.NhanVien);
            this.DS.NhanVien.AcceptChanges();
            this.NhanVienTableAdapter.FillTe(this.DS.NhanVien);

            NV_BdS.Position = NV_BdS.Find(NhanVien.MANV_HEADER, nv.MaNV);
            gridPos = NV_BdS.Position;

            enableSaveState();


            undoBtn.Enabled = true;

            ActionData action = new ActionData(ActionData.EventType.UPDATE);
            if (lastAcionSaveBtn == "insert")
            {
                action.Type = ActionData.EventType.DELETE;
                System.Console.WriteLine(action.Type);
                action.Content = nv;

            }
            else if (lastAcionSaveBtn == "update")
            {
                action.Type = ActionData.EventType.UPDATE;
                action.Content = nv;
            }
            action.PositionInGird = gridPos;

            addToUndo(new ActionData(ActionData.EventType.CANCEL_EDIT, nv, gridPos));
            ActionDataControl.ResolveStackStorage(undoStack); //đảm bảo số lượng phần tử không quá max
            //Save nên sẽ xóa redo đi
            redoStack.Clear();
        }
        /*

        private void saveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string actionType = lastAcionSaveBtn;
            NhanVien nv = new NhanVien();

            int gridPos = NV_BdS.Position;
            Console.WriteLine("type: " + actionType + " at: " + gridPos);

            if (actionType == "update")
            {
                nv = GetEmployeeInfoFromForm();
            }
            else if (actionType == "insert")
            {
                if (!ValidateEmployeeInput(out nv))
                    return;
            }

            try
            {
                SaveEmployeeToDatabase(actionType, nv);
                reloadBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            RefreshEmployeeDataAndGrid(nv);

            ActionData action = new ActionData(ActionData.EventType.UPDATE);
            action.Type = actionType == "insert" ? ActionData.EventType.INSERT : ActionData.EventType.UPDATE;
            action.Content = nv;
            action.PositionInGird = gridPos;

            ActionDataControl.ResolveStackStorage(undoStack);
            Console.WriteLine("pos: " + NV_BdS.Position + " " + nv.MaNV);
            redoStack.Clear();
        }
        */


        private void modifyBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int gridPos = NV_BdS.Position;

            // Tạo một đối tượng NhanVien và gán các thuộc tính từ các trường nhập liệu
            NhanVien nv = new NhanVien
            {
                Ho = HoTextEdit.Text.Trim(),
                Ten = TenTextEdit.Text.Trim(),
                SoDT = SoDTTextEdit.Text.Trim(),
                Phai = PhaiTextEdit.Text,
                Cmnd = CMNDTextEdit.Text.Trim(),
                DiaChi = DiaChiTextEdit.Text.Trim(),
                MaNV = MaNVTextBox.Text.Trim(),
                TrangThaiXoa = trangThaiXoaCheckBox.Checked
            };

            // Thêm hành động vào ngăn xếp hoàn tác
            addToUndo(new ActionData(ActionData.EventType.UPDATE, nv, gridPos));

            redoStack.Clear();

            enableUpdateState();

            MaNVTextBox.Enabled = false;

            lastAcionSaveBtn = "update";
        }

        private void reloadBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.NhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.NhanVienTableAdapter.FillTe(this.DS.NhanVien);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void exitBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
            Program.conn.Close();
            Program.frmChinh.Close();
        }


        private void allowChuyenCNCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            chuyenCNGroupBox.Enabled = allowChuyenCNCheckbox.Checked;
        }

        private void chuyeNvBarBTtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maNVChuyen = ((DataRowView)NV_BdS[NV_BdS.Position])["MaNV"].ToString().Trim();
            string hoten = ((DataRowView)NV_BdS[NV_BdS.Position])["Ho"].ToString().Trim() + " " + ((DataRowView)NV_BdS[NV_BdS.Position])["Ten"].ToString().Trim();
            // Không thể chuyển nhân viên đang là user
            if (maNVChuyen.Equals(Program.username))
            {
                MessageUtil.ShowErrorMsgDialog("Không thể tự chuyển sang chi nhánh khác.");
                return;
            }
            chuyenNVForm = new sfrmChuyenNV(maNVChuyen, hoten);

            chuyenNVForm.ShowDialog(this);

            this.NhanVienTableAdapter.FillTe(this.DS.NhanVien);
            chuyenNVForm.Close();
        }

        private void undoBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoStack.Count > 0)
            {
                printUndoStack();
                ActionData action = undoStack.Last();
                undoStack.RemoveLast();
                //System.Console.Write("undo type: " + action.Type + " - " );
                switch (action.Type)
                {
                    case ActionData.EventType.CANCEL_EDIT:
                        {
                            int res = execEditingAction(action);
                            if (res == 0)
                            {
                                action.Type = ActionData.EventType.DELETE;
                                NV_BdS.Position = action.PositionInGird;
                                redoStack.AddLast(action);
                            }
                            else if (res == 0)
                            {

                            }
                            break;
                        }
                    case ActionData.EventType.INSERT:
                        {
                            int gridPos = NV_BdS.Position;
                            int res = execInsertAction(action);
                            lastAcionSaveBtn = "insert";
                            if (res == 1)
                            {
                                action.Type = ActionData.EventType.DELETE;
                                action.PositionInGird = gridPos;
                                redoStack.AddLast(action);
                            }
                            else
                            {
                                addToUndo(action);
                            }
                            break;
                        }
                    case ActionData.EventType.DELETE:
                        {

                            int res = execDeleteAction(action);

                            if (res == 1)
                            {
                                action.Type = ActionData.EventType.INSERT;
                                redoStack.AddLast(action);
                                NV_BdS.Position = action.PositionInGird;
                            }
                            else if (res == 0)
                            {
                                addToUndo(action);
                            }
                            else if (res == 2)
                            {
                                action.Type = ActionData.EventType.INSERT;
                                redoStack.AddLast(action);
                                NV_BdS.Position = action.PositionInGird;
                            }
                            break;
                        }
                    case ActionData.EventType.UPDATE:
                        {
                            lastAcionSaveBtn = "update";
                            NhanVien oldNhanVien = new NhanVien(((DataRowView)NV_BdS[NV_BdS.Find(NhanVien.MANV_HEADER, ((NhanVien)action.Content).MaNV)]));
                            int res = execUpdateAction(action);
                            if (res == 1)
                            {
                                action.Type = ActionData.EventType.UPDATE;
                                action.Content = oldNhanVien;
                                redoStack.AddLast(action);
                            }
                            else
                            {
                                addToUndo(action);
                            }
                            break;
                        }
                    default:
                        break;
                }
                redoBtn.Enabled = (redoStack.Count > 0);
            }
            undoBtn.Enabled = (undoStack.Count > 0);
        }
        private void redoBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (redoStack.Count > 0)
            {
                printRedoStack();
                ActionData action = redoStack.Last();
                redoStack.RemoveLast();
                System.Console.Write("redo type: " + action.Type + " - ");
                switch (action.Type)
                {
                    case ActionData.EventType.INSERT:
                        {
                            int gridPos = NV_BdS.Position;
                            int res = execInsertAction(action);
                            if (res == 1)
                            {
                                action.Type = ActionData.EventType.DELETE;
                                action.PositionInGird = gridPos;
                                addToUndo(action);
                            }
                            else if (res == 0)
                            {
                                redoStack.AddLast(action);
                            }
                            break;
                        }
                    case ActionData.EventType.DELETE:
                        {
                            int res = execDeleteAction(action);
                            if (res == 0)
                            {
                                action.Type = ActionData.EventType.INSERT;
                                addToUndo(action);
                                NV_BdS.Position = action.PositionInGird;
                            }
                            else if (res == 0)
                            {
                                redoStack.AddLast(action);
                            }
                            break;
                        }
                    case ActionData.EventType.UPDATE:
                        {
                            NhanVien oldNhanVien = new NhanVien(((DataRowView)NV_BdS[NV_BdS.Find(NhanVien.MANV_HEADER, ((NhanVien)action.Content).MaNV)]));
                            if (execUpdateAction(action) == 1)
                            {
                                action.Type = ActionData.EventType.UPDATE;
                                action.Content = oldNhanVien;
                                addToUndo(action);
                            }
                            else
                            {
                                redoStack.AddLast(action);
                            }
                            break;
                        }
                    default:
                        break;
                }
                undoBtn.Enabled = (undoStack.Count > 0);
            }
            updateActionState();
            redoBtn.Enabled = (redoStack.Count > 0);
        }


        private void CNCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Console.WriteLine("cahnge" + Program.username);
            if (Program.username == "")
            {
                return;
            }
            CNCombox.DataSource = Program.dspmBdS;
            CNCombox.DisplayMember = "TENCN";
            CNCombox.ValueMember = "TENSERVER";
            if (CNCombox.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }

            Program.servername = CNCombox.SelectedValue.ToString();

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
            System.Console.WriteLine(Program.connectStr);

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối tới chi nhánh!", "", MessageBoxButtons.OK);
            }
            else
            {
                this.NhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.NhanVienTableAdapter.FillTe(this.DS.NhanVien);
                this.GD_CTTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.GD_CTTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
                this.GD_GRTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.GD_GRTableAdapter.Fill(this.DS.GD_GOIRUT);
            }
        }


        private int execInsertAction(ActionData action)
        {
            if (action == null || action.Content == null)
            {
                NV_BdS.AddNew();

                HoTextEdit.Text = "";
                TenTextEdit.Text = "";
                MaCNTextEdit.Text = maCn;
                CMNDTextEdit.Text = "";
                PhaiTextEdit.Text = "";
                SoDTTextEdit.Text = "";
                DiaChiTextEdit.Text = "";
                MaNVTextBox.Text = "";

                enableAddState();

                updateActionState();
                return -1;

            }

            NV_BdS.AddNew();
            NhanVien nv = (NhanVien)action.Content;

            HoTextEdit.Text = nv.Ho;
            TenTextEdit.Text = nv.Ten;
            MaCNTextEdit.Text = maCn;
            CMNDTextEdit.Text = nv.Cmnd;
            PhaiTextEdit.Text = nv.Phai;
            SoDTTextEdit.Text = nv.SoDT;
            DiaChiTextEdit.Text = nv.DiaChi;
            MaNVTextBox.Text = nv.MaNV;
            trangThaiXoaCheckBox.Checked = nv.TrangThaiXoa;
            try
            {
                // Lưu thông tin trên binding source
                NV_BdS.EndEdit();
                // Đặt thông tin nhân viên mới lên grid control
                NV_BdS.ResetCurrentItem();
                NhanVienTableAdapter.Update(this.DS.NhanVien);
                NhanVienTableAdapter.FillTe(this.DS.NhanVien);
                if (!string.IsNullOrEmpty(nv.Cmnd))
                {
                    NV_BdS.Position = NV_BdS.Find(NhanVien.CMND_HEADER, nv.Cmnd);
                }
                chuyeNvBarBTtn.Enabled = Program.mGroup == "ChiNhanh";
            }
            catch (Exception ex)
            {
                MessageUtil.ShowErrorMsgDialog($"Lỗi không thể khôi phục nhân viên đã xóa có CMND {nv.Cmnd}.\nChi tiết: {ex.Message}");
                return 0;
            }
            NVGridControll.Enabled = true;
            groupBox1.Enabled = false;
            updateActionState();
            return 1;
        }

        private int execDeleteAction(ActionData action)
        {
            if (action == null || action.Content == null)
            {
                NV_BdS.RemoveCurrent();
                NV_BdS.Position -= 1;
                enableNormalState();
                return 2;
            }

            NhanVien nv = (NhanVien)action.Content;
            if (string.IsNullOrEmpty(nv.MaNV))
            {
                NV_BdS.RemoveCurrent();
                NhanVienTableAdapter.FillTe(this.DS.NhanVien);
                enableNormalState();
                return 1;
            }
            NV_BdS.Position = NV_BdS.Find(NhanVien.MANV_HEADER, nv.MaNV);

            if (GD_GR_BdS.Count > 0 || GD_CT_BdS.Count > 0)
            {
                MessageUtil.ShowErrorMsgDialog("Không thể xóa nhân viên đã thực hiện giao dịch cho khách hàng");
                return -1;
            }

            if (MessageUtil.ShowWarnConfirmDialog($"Xác nhận xóa nhân viên có mã số {nv.MaNV}?") != DialogResult.OK)
                return 0;

            try
            {
                // Xóa trên máy trước
                NV_BdS.RemoveCurrent();
                // Xóa trên server
                NhanVienTableAdapter.Update(this.DS.NhanVien);
            }
            catch (Exception ex)
            {
                // Phục hồi nếu xóa không thành công
                MessageUtil.ShowErrorMsgDialog($"Lỗi không thể xóa nhân viên. Thử thực hiện lại.\nChi tiết: {ex.Message}");
                NhanVienTableAdapter.FillTe(this.DS.NhanVien);
                NV_BdS.Position = NV_BdS.Find(NhanVien.MANV_HEADER, nv.MaNV);
                return 1;
            }
            chuyeNvBarBTtn.Enabled = deleteBtn.Enabled = NV_BdS.Count != 0;


            return 0;
        }

        private int execUpdateAction(ActionData action)
        {
            NhanVien updatedNhanVien = (NhanVien)action.Content;

            NV_BdS.Position = NV_BdS.Find(NhanVien.MANV_HEADER, updatedNhanVien.MaNV);

            HoTextEdit.Text = updatedNhanVien.Ho;
            TenTextEdit.Text = updatedNhanVien.Ten;
            DiaChiTextEdit.Text = updatedNhanVien.DiaChi;
            SoDTTextEdit.Text = updatedNhanVien.SoDT;
            PhaiTextEdit.SelectedItem = updatedNhanVien.Phai;

            PhaiTextEdit.DataBindings[0].WriteValue();

            try
            {
                // Lưu thông tin trên binding source
                NV_BdS.EndEdit();
                // Đặt thông tin nhân viên mới lên grid control
                NV_BdS.ResetCurrentItem();
                NV_BdS.Position = NV_BdS.Find(NhanVien.MANV_HEADER, updatedNhanVien.MaNV);
                NhanVienTableAdapter.Update(this.DS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageUtil.ShowErrorMsgDialog($"Lỗi không thể hiệu chỉnh nhân viên.Thử thực hiện lại.\nChi tiết: {ex.Message}");
                return 0;
            }
            NV_BdS.Position = NV_BdS.Find(NhanVien.MANV_HEADER, updatedNhanVien.MaNV);
            return 1;
        }

        private int execEditingAction(ActionData action)
        {
            try
            {
                //NV_BdS.AddNew();

                NVGridControll.Enabled = true;
                NhanVien updatedNhanVien = (NhanVien)action.Content;

                NV_BdS.Position = NV_BdS.Find(NhanVien.MANV_HEADER, updatedNhanVien.MaNV);

                //NV_BdS.RemoveCurrent();

                //NV_BdS.AddNew();

                HoTextEdit.Text = updatedNhanVien.Ho;
                TenTextEdit.Text = updatedNhanVien.Ten;
                DiaChiTextEdit.Text = updatedNhanVien.DiaChi;
                SoDTTextEdit.Text = updatedNhanVien.SoDT;
                PhaiTextEdit.SelectedItem = updatedNhanVien.Phai;
                MaNVTextBox.Text = updatedNhanVien.MaNV;
                CMNDTextEdit.Text = updatedNhanVien.Cmnd;
                PhaiTextEdit.DataBindings[0].WriteValue();
                trangThaiXoaCheckBox.Checked = updatedNhanVien.TrangThaiXoa;


                enableAddState();
                if (updatedNhanVien.isNVValid())
                {
                    lastAcionSaveBtn = "update";
                }
                else
                {
                    lastAcionSaveBtn = "";
                }
                return 0;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return 1;
            }
        }
        private void updateActionState()
        {
            undoBtn.Enabled = undoStack.Count > 0;
            redoBtn.Enabled = redoStack.Count > 0;
            if (Program.mGroup == "ChiNhanh")
            {
                deleteBtn.Enabled = NV_BdS.Count > 0;

            }
            else
            {
                deleteBtn.Enabled = false;
            }
        }

        private void enableNormalState()
        {
            addBtn.Enabled = deleteBtn.Enabled = modifyBtn.Enabled = reloadBtn.Enabled = true;
            saveBtn.Enabled = false;
            NVGridControll.Enabled = true;
            groupBox1.Enabled = false;
            if (Program.mGroup == "NganHang")
            {
                CNCombox.Enabled = true;
                addBtn.Enabled = deleteBtn.Enabled = modifyBtn.Enabled = saveBtn.Enabled = chuyeNvBarBTtn.Enabled = cancelActionBtn.Enabled = false;
            }

            else if (Program.mGroup == "ChiNhanh")
            {
               
                CNCombox.Enabled = false;
            }

            gridView1.Columns[0].OptionsColumn.ReadOnly = true;
            chuyenCNGroupBox.Visible = false;

            updateActionState();
        }

        private void enableAddState()
        {

            addBtn.Enabled = deleteBtn.Enabled = modifyBtn.Enabled = reloadBtn.Enabled = false;
            MaNVTextBox.Enabled = true;
            cancelActionBtn.Enabled = saveBtn.Enabled = undoBtn.Enabled = true;
            NVGridControll.Enabled = false;
            chuyenCNGroupBox.Visible = false;
            trangThaiXoaCheckBox.Checked = false;
            trangThaiXoaCheckBox.Enabled = false;
            groupBox1.Enabled = true;

            updateActionState();
        }

        private void enableUpdateState()
        {
            vitri = NV_BdS.Position;
            groupBox1.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = modifyBtn.Enabled = reloadBtn.Enabled = exitBtn.Enabled = false;
            saveBtn.Enabled = undoBtn.Enabled = cancelActionBtn.Enabled = allowChuyenCNCheckbox.Enabled = true;
            MaNVTextBox.Enabled = false; //không cho sửa mã nv
            NVGridControll.Enabled = false;
            trangThaiXoaCheckBox.Enabled = true;

            updateActionState();
        }

        private void enableSaveState()
        {
            NVGridControll.Enabled = true;
            MaNVTextBox.Enabled = false;
            addBtn.Enabled = modifyBtn.Enabled = deleteBtn.Enabled = reloadBtn.Enabled = exitBtn.Enabled = true;
            saveBtn.Enabled = undoBtn.Enabled = cancelActionBtn.Enabled = false;
            groupBox1.Enabled = false;
            chuyenCNGroupBox.Visible = false;
            trangThaiXoaCheckBox.Enabled = true;

            updateActionState();
        }

        private void CMNDTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ActionData action = undoStack.Last();
                if (action.Content == null && action.Type == ActionData.EventType.INSERT && undoStack.Count > 0)
                {
                    undoStack.RemoveLast();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void fillTeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.NhanVienTableAdapter.FillTe(this.DS.NhanVien);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void addToUndo(ActionData action)
        {
            System.Console.WriteLine("Add action type: " + action.Type);
            undoStack.AddLast(action);
        }
        private void printUndoStack()
        {
            int i = 0;
            foreach (ActionData actionData in undoStack)
            {
                Console.WriteLine("STT: " + i + " type: " + actionData.Type);
                i++;
            }
        }

        private void printRedoStack()
        {
            foreach (ActionData actionData in redoStack)
            {
                NhanVien a = (NhanVien)actionData.Content;
                Console.WriteLine("Type: " + actionData.Type);
                Console.WriteLine(" MaNV: " + a.MaNV);
                Console.WriteLine("----------------------------------");
            }

        }

        private void fillByAToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.NhanVienTableAdapter.FillByA(this.DS.NhanVien);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }

}
