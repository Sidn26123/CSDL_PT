
namespace NganHang_PhanTan.SubForm
{
    partial class sfrmChuyenNV
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sP_LayDsChiNhanhKhacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new NganHang_PhanTan.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENCN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNVTxt = new System.Windows.Forms.Label();
            this.HoTenNVTxt = new System.Windows.Forms.Label();
            this.CNHienTaiTxt = new System.Windows.Forms.Label();
            this.chuyenCNBtn = new System.Windows.Forms.Button();
            this.sP_LayDsChiNhanhKhacTableAdapter = new NganHang_PhanTan.DSTableAdapters.SP_LayDsChiNhanhKhacTableAdapter();
            this.tableAdapterManager = new NganHang_PhanTan.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LayDsChiNhanhKhacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sP_LayDsChiNhanhKhacBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.Size = new System.Drawing.Size(763, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sP_LayDsChiNhanhKhacBindingSource
            // 
            this.sP_LayDsChiNhanhKhacBindingSource.DataMember = "SP_LayDsChiNhanhKhac";
            this.sP_LayDsChiNhanhKhacBindingSource.DataSource = this.DS;
            this.sP_LayDsChiNhanhKhacBindingSource.CurrentChanged += new System.EventHandler(this.sP_LayDsChiNhanhKhacBindingSource_CurrentChanged);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMACN,
            this.colTENCN,
            this.colDIACHI});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 0;
            // 
            // colTENCN
            // 
            this.colTENCN.FieldName = "TENCN";
            this.colTENCN.Name = "colTENCN";
            this.colTENCN.OptionsColumn.AllowEdit = false;
            this.colTENCN.Visible = true;
            this.colTENCN.VisibleIndex = 1;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            // 
            // MaNVTxt
            // 
            this.MaNVTxt.AutoSize = true;
            this.MaNVTxt.Location = new System.Drawing.Point(83, 232);
            this.MaNVTxt.Name = "MaNVTxt";
            this.MaNVTxt.Size = new System.Drawing.Size(52, 13);
            this.MaNVTxt.TabIndex = 1;
            this.MaNVTxt.Text = "MaNVTxt";
            // 
            // HoTenNVTxt
            // 
            this.HoTenNVTxt.AutoSize = true;
            this.HoTenNVTxt.Location = new System.Drawing.Point(227, 232);
            this.HoTenNVTxt.Name = "HoTenNVTxt";
            this.HoTenNVTxt.Size = new System.Drawing.Size(35, 13);
            this.HoTenNVTxt.TabIndex = 2;
            this.HoTenNVTxt.Text = "label2";
            // 
            // CNHienTaiTxt
            // 
            this.CNHienTaiTxt.AutoSize = true;
            this.CNHienTaiTxt.Location = new System.Drawing.Point(379, 232);
            this.CNHienTaiTxt.Name = "CNHienTaiTxt";
            this.CNHienTaiTxt.Size = new System.Drawing.Size(35, 13);
            this.CNHienTaiTxt.TabIndex = 3;
            this.CNHienTaiTxt.Text = "label3";
            this.CNHienTaiTxt.Visible = false;
            // 
            // chuyenCNBtn
            // 
            this.chuyenCNBtn.Location = new System.Drawing.Point(230, 302);
            this.chuyenCNBtn.Name = "chuyenCNBtn";
            this.chuyenCNBtn.Size = new System.Drawing.Size(75, 23);
            this.chuyenCNBtn.TabIndex = 4;
            this.chuyenCNBtn.Text = "Chuyển";
            this.chuyenCNBtn.UseVisualStyleBackColor = true;
            this.chuyenCNBtn.Click += new System.EventHandler(this.chuyenCNBtn_Click);
            // 
            // sP_LayDsChiNhanhKhacTableAdapter
            // 
            this.sP_LayDsChiNhanhKhacTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang_PhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sfrmChuyenNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(763, 338);
            this.Controls.Add(this.chuyenCNBtn);
            this.Controls.Add(this.CNHienTaiTxt);
            this.Controls.Add(this.HoTenNVTxt);
            this.Controls.Add(this.MaNVTxt);
            this.Controls.Add(this.gridControl1);
            this.Name = "sfrmChuyenNV";
            this.Text = "Chuyển nhân viên";
            this.Load += new System.EventHandler(this.sfrmChuyenNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LayDsChiNhanhKhacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label MaNVTxt;
        private System.Windows.Forms.Label HoTenNVTxt;
        private System.Windows.Forms.Label CNHienTaiTxt;
        private System.Windows.Forms.Button chuyenCNBtn;
        private DS DS;
        private System.Windows.Forms.BindingSource sP_LayDsChiNhanhKhacBindingSource;
        private DSTableAdapters.SP_LayDsChiNhanhKhacTableAdapter sP_LayDsChiNhanhKhacTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTENCN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
    }
}