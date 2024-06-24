
namespace NganHang_PhanTan
{
    partial class fmMoTaiKhoanKH
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
            this.btnKiemTraThongTin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNhapSoCMND = new System.Windows.Forms.TextBox();
            this.DS = new NganHang_PhanTan.DS();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NganHang_PhanTan.DSTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NganHang_PhanTan.DSTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.rtbDiaChi = new System.Windows.Forms.RichTextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbSoDu = new System.Windows.Forms.TextBox();
            this.tbSoTK = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbChiNhanh = new System.Windows.Forms.TextBox();
            this.tbHo = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKiemTraThongTin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbNhapSoCMND);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 57);
            this.panel1.TabIndex = 1;
            // 
            // btnKiemTraThongTin
            // 
            this.btnKiemTraThongTin.Location = new System.Drawing.Point(451, 12);
            this.btnKiemTraThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKiemTraThongTin.Name = "btnKiemTraThongTin";
            this.btnKiemTraThongTin.Size = new System.Drawing.Size(87, 28);
            this.btnKiemTraThongTin.TabIndex = 2;
            this.btnKiemTraThongTin.Text = "Kiểm tra";
            this.btnKiemTraThongTin.UseVisualStyleBackColor = true;
            this.btnKiemTraThongTin.Click += new System.EventHandler(this.btnKiemTraThongTin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số CMND:";
            // 
            // tbNhapSoCMND
            // 
            this.tbNhapSoCMND.Location = new System.Drawing.Point(247, 15);
            this.tbNhapSoCMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNhapSoCMND.Name = "tbNhapSoCMND";
            this.tbNhapSoCMND.Size = new System.Drawing.Size(177, 22);
            this.tbNhapSoCMND.TabIndex = 0;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.DS;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NganHang_PhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnTaoTK);
            this.groupBox1.Controls.Add(this.rtbDiaChi);
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.tbSoDu);
            this.groupBox1.Controls.Add(this.tbSoTK);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.tbChiNhanh);
            this.groupBox1.Controls.Add(this.tbHo);
            this.groupBox1.Controls.Add(this.tbCMND);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1112, 353);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(747, 187);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 26);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(881, 187);
            this.btnTaoTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(92, 26);
            this.btnTaoTK.TabIndex = 15;
            this.btnTaoTK.Text = "Xác nhận";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // rtbDiaChi
            // 
            this.rtbDiaChi.Location = new System.Drawing.Point(460, 160);
            this.rtbDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbDiaChi.Name = "rtbDiaChi";
            this.rtbDiaChi.Size = new System.Drawing.Size(161, 52);
            this.rtbDiaChi.TabIndex = 14;
            this.rtbDiaChi.Text = "";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(107, 164);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(161, 22);
            this.tbSDT.TabIndex = 13;
            // 
            // tbSoDu
            // 
            this.tbSoDu.Location = new System.Drawing.Point(832, 103);
            this.tbSoDu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSoDu.Name = "tbSoDu";
            this.tbSoDu.Size = new System.Drawing.Size(161, 22);
            this.tbSoDu.TabIndex = 12;
            // 
            // tbSoTK
            // 
            this.tbSoTK.Location = new System.Drawing.Point(832, 41);
            this.tbSoTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSoTK.Name = "tbSoTK";
            this.tbSoTK.Size = new System.Drawing.Size(161, 22);
            this.tbSoTK.TabIndex = 11;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(460, 100);
            this.tbTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(161, 22);
            this.tbTen.TabIndex = 11;
            // 
            // tbChiNhanh
            // 
            this.tbChiNhanh.Location = new System.Drawing.Point(460, 41);
            this.tbChiNhanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbChiNhanh.Name = "tbChiNhanh";
            this.tbChiNhanh.Size = new System.Drawing.Size(161, 22);
            this.tbChiNhanh.TabIndex = 10;
            // 
            // tbHo
            // 
            this.tbHo.Location = new System.Drawing.Point(107, 100);
            this.tbHo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHo.Name = "tbHo";
            this.tbHo.Size = new System.Drawing.Size(161, 22);
            this.tbHo.TabIndex = 9;
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(107, 41);
            this.tbCMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(161, 22);
            this.tbCMND.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(779, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số dư:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(743, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số tài khoản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thông tin KH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Họ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số CMND:";
            // 
            // fmMoTaiKhoanKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "fmMoTaiKhoanKH";
            this.Text = "fmMoTaiKhoanKH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmMoTaiKhoanKH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKiemTraThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNhapSoCMND;
        private DS DS;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.RichTextBox rtbDiaChi;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbSoDu;
        private System.Windows.Forms.TextBox tbSoTK;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbChiNhanh;
        private System.Windows.Forms.TextBox tbHo;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}