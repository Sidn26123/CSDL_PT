
namespace NganHang_PhanTan
{
    partial class fmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmKhachHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnMoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.DS = new NganHang_PhanTan.DS();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new NganHang_PhanTan.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new NganHang_PhanTan.DSTableAdapters.TableAdapterManager();
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.CMNDKhachHang = new System.Windows.Forms.TextBox();
            this.hoKhachHang = new System.Windows.Forms.TextBox();
            this.tenKhachHang = new System.Windows.Forms.TextBox();
            this.diaChiKH = new System.Windows.Forms.RichTextBox();
            this.ngayCapCMND = new DevExpress.XtraEditors.DateEdit();
            this.SDTKhachHang = new System.Windows.Forms.TextBox();
            this.maChiNhanh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gioiTinh = new System.Windows.Forms.TextBox();
            cMNDLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapCMND.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapCMND.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(52, 32);
            cMNDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(58, 13);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "Số CMND:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(84, 83);
            hOLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(24, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(363, 82);
            tENLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(29, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(350, 137);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(43, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(62, 134);
            pHAILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(50, 13);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "Giới tính:";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(296, 32);
            nGAYCAPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(91, 13);
            nGAYCAPLabel.TabIndex = 10;
            nGAYCAPLabel.Text = "Ngày cấp CMND:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(592, 82);
            sODTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(73, 13);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "Số điện thoại:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(590, 32);
            mACNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(75, 13);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "Mã chi nhánh:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnPhucHoi,
            this.btnThoat,
            this.btnMoTaiKhoan,
            this.Reload});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(375, 170);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMoTaiKhoan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu lại";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Reset";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnMoTaiKhoan
            // 
            this.btnMoTaiKhoan.Caption = "Mở tài khoản";
            this.btnMoTaiKhoan.Id = 7;
            this.btnMoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoTaiKhoan.ImageOptions.Image")));
            this.btnMoTaiKhoan.Name = "btnMoTaiKhoan";
            this.btnMoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoTaiKhoan_ItemClick);
            // 
            // Reload
            // 
            this.Reload.Caption = "Reload";
            this.Reload.Id = 8;
            this.Reload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Reload.ImageOptions.Image")));
            this.Reload.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload.ItemAppearance.Disabled.Options.UseFont = true;
            this.Reload.Name = "Reload";
            this.Reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Reload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            this.bar2.Visible = false;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(1028, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 455);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(1028, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 394);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1028, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 394);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbChiNhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 37);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi nhánh:";
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(284, 9);
            this.cbChiNhanh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(216, 21);
            this.cbChiNhanh.TabIndex = 0;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KhachHang";
            this.bdsKH.DataSource = this.DS;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang_PhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.bdsKH;
            this.khachHangGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.khachHangGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.khachHangGridControl.Location = new System.Drawing.Point(0, 98);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.khachHangGridControl.MenuManager = this.barManager1;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(1028, 213);
            this.khachHangGridControl.TabIndex = 6;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gridView1.DetailHeight = 692;
            this.gridView1.GridControl = this.khachHangGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 46;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 170;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 46;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 170;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 46;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 170;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 46;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 170;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 46;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 170;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 46;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 170;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 46;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 170;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 46;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 170;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Mở tài khoản";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Mở tài khoản";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Mở tài khoản";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thoát";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // CMNDKhachHang
            // 
            this.CMNDKhachHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "CMND", true));
            this.CMNDKhachHang.Location = new System.Drawing.Point(112, 30);
            this.CMNDKhachHang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CMNDKhachHang.Name = "CMNDKhachHang";
            this.CMNDKhachHang.Size = new System.Drawing.Size(119, 20);
            this.CMNDKhachHang.TabIndex = 1;
            // 
            // hoKhachHang
            // 
            this.hoKhachHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "HO", true));
            this.hoKhachHang.Location = new System.Drawing.Point(112, 80);
            this.hoKhachHang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.hoKhachHang.Name = "hoKhachHang";
            this.hoKhachHang.Size = new System.Drawing.Size(119, 20);
            this.hoKhachHang.TabIndex = 3;
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "TEN", true));
            this.tenKhachHang.Location = new System.Drawing.Point(395, 80);
            this.tenKhachHang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tenKhachHang.Name = "tenKhachHang";
            this.tenKhachHang.Size = new System.Drawing.Size(119, 20);
            this.tenKhachHang.TabIndex = 5;
            // 
            // diaChiKH
            // 
            this.diaChiKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "DIACHI", true));
            this.diaChiKH.Location = new System.Drawing.Point(395, 132);
            this.diaChiKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diaChiKH.Name = "diaChiKH";
            this.diaChiKH.Size = new System.Drawing.Size(271, 41);
            this.diaChiKH.TabIndex = 7;
            this.diaChiKH.Text = "";
            // 
            // ngayCapCMND
            // 
            this.ngayCapCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "NGAYCAP", true));
            this.ngayCapCMND.EditValue = null;
            this.ngayCapCMND.Location = new System.Drawing.Point(395, 31);
            this.ngayCapCMND.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ngayCapCMND.MenuManager = this.barManager1;
            this.ngayCapCMND.Name = "ngayCapCMND";
            this.ngayCapCMND.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapCMND.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapCMND.Size = new System.Drawing.Size(118, 20);
            this.ngayCapCMND.TabIndex = 11;
            // 
            // SDTKhachHang
            // 
            this.SDTKhachHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "SODT", true));
            this.SDTKhachHang.Location = new System.Drawing.Point(668, 80);
            this.SDTKhachHang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SDTKhachHang.Name = "SDTKhachHang";
            this.SDTKhachHang.Size = new System.Drawing.Size(119, 20);
            this.SDTKhachHang.TabIndex = 13;
            // 
            // maChiNhanh
            // 
            this.maChiNhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "MACN", true));
            this.maChiNhanh.Location = new System.Drawing.Point(668, 31);
            this.maChiNhanh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maChiNhanh.Name = "maChiNhanh";
            this.maChiNhanh.Size = new System.Drawing.Size(119, 20);
            this.maChiNhanh.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gioiTinh);
            this.groupBox1.Controls.Add(mACNLabel);
            this.groupBox1.Controls.Add(this.maChiNhanh);
            this.groupBox1.Controls.Add(sODTLabel);
            this.groupBox1.Controls.Add(this.SDTKhachHang);
            this.groupBox1.Controls.Add(nGAYCAPLabel);
            this.groupBox1.Controls.Add(this.ngayCapCMND);
            this.groupBox1.Controls.Add(pHAILabel);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.diaChiKH);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.tenKhachHang);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.hoKhachHang);
            this.groupBox1.Controls.Add(cMNDLabel);
            this.groupBox1.Controls.Add(this.CMNDKhachHang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 311);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(1028, 144);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "PHAI", true));
            this.gioiTinh.Location = new System.Drawing.Point(115, 132);
            this.gioiTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Size = new System.Drawing.Size(76, 20);
            this.gioiTinh.TabIndex = 16;
            // 
            // fmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.khachHangGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fmKhachHang";
            this.Text = "fmKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapCMND.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapCMND.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnMoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsKH;
        private DS DS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khachHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraBars.BarButtonItem Reload;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maChiNhanh;
        private System.Windows.Forms.TextBox SDTKhachHang;
        private DevExpress.XtraEditors.DateEdit ngayCapCMND;
        private System.Windows.Forms.RichTextBox diaChiKH;
        private System.Windows.Forms.TextBox tenKhachHang;
        private System.Windows.Forms.TextBox hoKhachHang;
        private System.Windows.Forms.TextBox CMNDKhachHang;
        private System.Windows.Forms.TextBox gioiTinh;
    }
}