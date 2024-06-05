
namespace NganHang_PhanTan
{
    partial class frmChuyenKhoan
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
            this.nameOfSTKOwnerTxt = new System.Windows.Forms.Label();
            this.takeActionBtn = new System.Windows.Forms.Button();
            this.sotienTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stkChuyenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameOfSTKDichTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stkDichTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.amountTKChuyenTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sotienTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stkChuyenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stkDichTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameOfSTKOwnerTxt
            // 
            this.nameOfSTKOwnerTxt.AutoSize = true;
            this.nameOfSTKOwnerTxt.Location = new System.Drawing.Point(327, 121);
            this.nameOfSTKOwnerTxt.Name = "nameOfSTKOwnerTxt";
            this.nameOfSTKOwnerTxt.Size = new System.Drawing.Size(0, 13);
            this.nameOfSTKOwnerTxt.TabIndex = 16;
            // 
            // takeActionBtn
            // 
            this.takeActionBtn.Location = new System.Drawing.Point(288, 251);
            this.takeActionBtn.Name = "takeActionBtn";
            this.takeActionBtn.Size = new System.Drawing.Size(75, 23);
            this.takeActionBtn.TabIndex = 15;
            this.takeActionBtn.Text = "Thực hiện";
            this.takeActionBtn.UseVisualStyleBackColor = true;
            this.takeActionBtn.Click += new System.EventHandler(this.takeActionBtn_Click);
            // 
            // sotienTextEdit
            // 
            this.sotienTextEdit.Location = new System.Drawing.Point(275, 204);
            this.sotienTextEdit.Name = "sotienTextEdit";
            this.sotienTextEdit.Properties.EditFormat.FormatString = "#.###";
            this.sotienTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sotienTextEdit.Properties.Mask.EditMask = "n0";
            this.sotienTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.sotienTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.sotienTextEdit.Size = new System.Drawing.Size(134, 20);
            this.sotienTextEdit.TabIndex = 14;
            this.sotienTextEdit.Leave += new System.EventHandler(this.sotienTextEdit_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "STK chuyển:";
            // 
            // stkChuyenTextEdit
            // 
            this.stkChuyenTextEdit.Location = new System.Drawing.Point(275, 98);
            this.stkChuyenTextEdit.Name = "stkChuyenTextEdit";
            this.stkChuyenTextEdit.Size = new System.Drawing.Size(134, 20);
            this.stkChuyenTextEdit.TabIndex = 11;
            this.stkChuyenTextEdit.EditValueChanged += new System.EventHandler(this.stkChuyenTextEdit_EditValueChanged);
            this.stkChuyenTextEdit.Leave += new System.EventHandler(this.stkChuyenTextEdit_Leave);
            // 
            // nameOfSTKDichTxt
            // 
            this.nameOfSTKDichTxt.AutoSize = true;
            this.nameOfSTKDichTxt.Location = new System.Drawing.Point(327, 177);
            this.nameOfSTKDichTxt.Name = "nameOfSTKDichTxt";
            this.nameOfSTKDichTxt.Size = new System.Drawing.Size(0, 13);
            this.nameOfSTKDichTxt.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "STK đích:";
            // 
            // stkDichTextEdit
            // 
            this.stkDichTextEdit.Location = new System.Drawing.Point(275, 154);
            this.stkDichTextEdit.Name = "stkDichTextEdit";
            this.stkDichTextEdit.Size = new System.Drawing.Size(134, 20);
            this.stkDichTextEdit.TabIndex = 17;
            this.stkDichTextEdit.EditValueChanged += new System.EventHandler(this.stkDichTextEdit_EditValueChanged);
            this.stkDichTextEdit.Leave += new System.EventHandler(this.stkDichTextEdit_Leave);
            // 
            // amountTKChuyenTxt
            // 
            this.amountTKChuyenTxt.AutoSize = true;
            this.amountTKChuyenTxt.Location = new System.Drawing.Point(327, 138);
            this.amountTKChuyenTxt.Name = "amountTKChuyenTxt";
            this.amountTKChuyenTxt.Size = new System.Drawing.Size(0, 13);
            this.amountTKChuyenTxt.TabIndex = 20;
            // 
            // frmChuyenKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amountTKChuyenTxt);
            this.Controls.Add(this.nameOfSTKDichTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stkDichTextEdit);
            this.Controls.Add(this.nameOfSTKOwnerTxt);
            this.Controls.Add(this.takeActionBtn);
            this.Controls.Add(this.sotienTextEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stkChuyenTextEdit);
            this.Name = "frmChuyenKhoan";
            this.Text = "Chuyển khoản";
            ((System.ComponentModel.ISupportInitialize)(this.sotienTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stkChuyenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stkDichTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameOfSTKOwnerTxt;
        private System.Windows.Forms.Button takeActionBtn;
        private DevExpress.XtraEditors.TextEdit sotienTextEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit stkChuyenTextEdit;
        private System.Windows.Forms.Label nameOfSTKDichTxt;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit stkDichTextEdit;
        private System.Windows.Forms.Label amountTKChuyenTxt;
    }
}