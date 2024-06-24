
namespace NganHang_PhanTan
{
    partial class fmThongKe_TK
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
            this.ngayBatDauTK = new System.Windows.Forms.DateTimePicker();
            this.ngayKetThucTK = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.DS = new NganHang_PhanTan.DS();
            this.chiNhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiNhanhTableAdapter = new NganHang_PhanTan.DSTableAdapters.ChiNhanhTableAdapter();
            this.tableAdapterManager = new NganHang_PhanTan.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ngayBatDauTK
            // 
            this.ngayBatDauTK.Location = new System.Drawing.Point(125, 67);
            this.ngayBatDauTK.Name = "ngayBatDauTK";
            this.ngayBatDauTK.Size = new System.Drawing.Size(200, 23);
            this.ngayBatDauTK.TabIndex = 0;
            // 
            // ngayKetThucTK
            // 
            this.ngayKetThucTK.Location = new System.Drawing.Point(512, 67);
            this.ngayKetThucTK.Name = "ngayKetThucTK";
            this.ngayKetThucTK.Size = new System.Drawing.Size(200, 23);
            this.ngayKetThucTK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày kết thúc:";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(320, 158);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(92, 41);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê ";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
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
            // fmThongKe_TK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 291);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ngayKetThucTK);
            this.Controls.Add(this.ngayBatDauTK);
            this.Name = "fmThongKe_TK";
            this.Text = "fmThongKe_TKK";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmThongKe_TK_FormClosed);
            this.Load += new System.EventHandler(this.fmThongKe_TK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ngayBatDauTK;
        private System.Windows.Forms.DateTimePicker ngayKetThucTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private DS DS;
        private System.Windows.Forms.BindingSource chiNhanhBindingSource;
        private DSTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}