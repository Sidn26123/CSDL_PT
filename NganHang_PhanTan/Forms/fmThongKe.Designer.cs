
namespace NganHang_PhanTan
{
    partial class fmThongKe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreView = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnKhachHang = new System.Windows.Forms.CheckBox();
            this.rbtnTaiKhoan = new System.Windows.Forms.CheckBox();
            this.rbtnGiaoDich = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnTatCa = new System.Windows.Forms.CheckBox();
            this.rbtnHienTai = new System.Windows.Forms.CheckBox();
            this.DS = new NganHang_PhanTan.DS();
            this.chiNhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiNhanhTableAdapter = new NganHang_PhanTan.DSTableAdapters.ChiNhanhTableAdapter();
            this.tableAdapterManager = new NganHang_PhanTan.DSTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbChiNhanh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 107);
            this.panel1.TabIndex = 0;
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(354, 31);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(173, 24);
            this.cbbChiNhanh.TabIndex = 1;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPreView);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(1, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 571);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // btnPreView
            // 
            this.btnPreView.Location = new System.Drawing.Point(354, 310);
            this.btnPreView.Name = "btnPreView";
            this.btnPreView.Size = new System.Drawing.Size(97, 34);
            this.btnPreView.TabIndex = 2;
            this.btnPreView.Text = "Preview";
            this.btnPreView.UseVisualStyleBackColor = true;
            this.btnPreView.Click += new System.EventHandler(this.btnPreView_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnKhachHang);
            this.groupBox3.Controls.Add(this.rbtnTaiKhoan);
            this.groupBox3.Controls.Add(this.rbtnGiaoDich);
            this.groupBox3.Location = new System.Drawing.Point(113, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 103);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại thống kê:";
            // 
            // rbtnKhachHang
            // 
            this.rbtnKhachHang.AutoSize = true;
            this.rbtnKhachHang.Location = new System.Drawing.Point(458, 43);
            this.rbtnKhachHang.Name = "rbtnKhachHang";
            this.rbtnKhachHang.Size = new System.Drawing.Size(103, 21);
            this.rbtnKhachHang.TabIndex = 2;
            this.rbtnKhachHang.Text = "Khách hàng";
            this.rbtnKhachHang.UseVisualStyleBackColor = true;
            this.rbtnKhachHang.CheckedChanged += new System.EventHandler(this.rbtnKhachHang_CheckedChanged);
            // 
            // rbtnTaiKhoan
            // 
            this.rbtnTaiKhoan.AutoSize = true;
            this.rbtnTaiKhoan.Location = new System.Drawing.Point(241, 43);
            this.rbtnTaiKhoan.Name = "rbtnTaiKhoan";
            this.rbtnTaiKhoan.Size = new System.Drawing.Size(89, 21);
            this.rbtnTaiKhoan.TabIndex = 1;
            this.rbtnTaiKhoan.Text = "Tài khoản";
            this.rbtnTaiKhoan.UseVisualStyleBackColor = true;
            this.rbtnTaiKhoan.CheckedChanged += new System.EventHandler(this.rbtnTaiKhoan_CheckedChanged);
            // 
            // rbtnGiaoDich
            // 
            this.rbtnGiaoDich.AutoSize = true;
            this.rbtnGiaoDich.Location = new System.Drawing.Point(53, 43);
            this.rbtnGiaoDich.Name = "rbtnGiaoDich";
            this.rbtnGiaoDich.Size = new System.Drawing.Size(85, 21);
            this.rbtnGiaoDich.TabIndex = 0;
            this.rbtnGiaoDich.Text = "Giao dịch";
            this.rbtnGiaoDich.UseVisualStyleBackColor = true;
            this.rbtnGiaoDich.CheckedChanged += new System.EventHandler(this.rbtnGiaoDich_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnTatCa);
            this.groupBox2.Controls.Add(this.rbtnHienTai);
            this.groupBox2.Location = new System.Drawing.Point(113, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 96);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê trên Server:";
            // 
            // rbtnTatCa
            // 
            this.rbtnTatCa.AutoSize = true;
            this.rbtnTatCa.Location = new System.Drawing.Point(395, 37);
            this.rbtnTatCa.Name = "rbtnTatCa";
            this.rbtnTatCa.Size = new System.Drawing.Size(68, 21);
            this.rbtnTatCa.TabIndex = 1;
            this.rbtnTatCa.Text = "Tất cả";
            this.rbtnTatCa.UseVisualStyleBackColor = true;
            this.rbtnTatCa.CheckedChanged += new System.EventHandler(this.rbtnTatCa_CheckedChanged);
            // 
            // rbtnHienTai
            // 
            this.rbtnHienTai.AutoSize = true;
            this.rbtnHienTai.Location = new System.Drawing.Point(102, 37);
            this.rbtnHienTai.Name = "rbtnHienTai";
            this.rbtnHienTai.Size = new System.Drawing.Size(74, 21);
            this.rbtnHienTai.TabIndex = 0;
            this.rbtnHienTai.Text = "Hiện tại";
            this.rbtnHienTai.UseVisualStyleBackColor = true;
            this.rbtnHienTai.CheckedChanged += new System.EventHandler(this.rbtnHienTai_CheckedChanged);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiNhanhBindingSource
            // 
            this.chiNhanhBindingSource.DataMember = "ChiNhanh";
            this.chiNhanhBindingSource.DataSource = this.DS;
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = this.chiNhanhTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang_PhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 684);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "fmThongKe";
            this.Text = "fmThongKee";
            this.Load += new System.EventHandler(this.fmThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPreView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox rbtnKhachHang;
        private System.Windows.Forms.CheckBox rbtnTaiKhoan;
        private System.Windows.Forms.CheckBox rbtnGiaoDich;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox rbtnTatCa;
        private System.Windows.Forms.CheckBox rbtnHienTai;
        private DS DS;
        private System.Windows.Forms.BindingSource chiNhanhBindingSource;
        private DSTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}