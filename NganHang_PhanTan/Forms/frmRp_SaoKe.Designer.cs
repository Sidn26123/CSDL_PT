
namespace NganHang_PhanTan
{
    partial class frmRp_SaoKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.stkTxt = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.dateStartDE = new DevExpress.XtraEditors.DateEdit();
            this.dateEndDE = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.previewBtn = new System.Windows.Forms.Button();
            this.nameSTKTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stkTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "STK:";
            // 
            // stkTxt
            // 
            this.stkTxt.Location = new System.Drawing.Point(83, 30);
            this.stkTxt.Name = "stkTxt";
            this.stkTxt.Size = new System.Drawing.Size(134, 20);
            this.stkTxt.TabIndex = 17;
            this.stkTxt.EditValueChanged += new System.EventHandler(this.stkTxt_EditValueChanged);
            this.stkTxt.EnabledChanged += new System.EventHandler(this.stkTxt_EnabledChanged);
            this.stkTxt.Leave += new System.EventHandler(this.stkTxt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // dateStartDE
            // 
            this.dateStartDE.EditValue = null;
            this.dateStartDE.Location = new System.Drawing.Point(389, 30);
            this.dateStartDE.Name = "dateStartDE";
            this.dateStartDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDE.Size = new System.Drawing.Size(100, 20);
            this.dateStartDE.TabIndex = 22;
            // 
            // dateEndDE
            // 
            this.dateEndDE.EditValue = null;
            this.dateEndDE.Location = new System.Drawing.Point(638, 30);
            this.dateEndDE.Name = "dateEndDE";
            this.dateEndDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEndDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEndDE.Size = new System.Drawing.Size(100, 20);
            this.dateEndDE.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ngày cuối cùng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(325, 116);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(75, 23);
            this.previewBtn.TabIndex = 25;
            this.previewBtn.Text = "Preview";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // nameSTKTxt
            // 
            this.nameSTKTxt.AutoSize = true;
            this.nameSTKTxt.Location = new System.Drawing.Point(142, 65);
            this.nameSTKTxt.Name = "nameSTKTxt";
            this.nameSTKTxt.Size = new System.Drawing.Size(0, 13);
            this.nameSTKTxt.TabIndex = 26;
            // 
            // frmRp_SaoKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 208);
            this.Controls.Add(this.nameSTKTxt);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.dateEndDE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateStartDE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stkTxt);
            this.Name = "frmRp_SaoKe";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stkTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit stkTxt;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dateStartDE;
        private DevExpress.XtraEditors.DateEdit dateEndDE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.Label nameSTKTxt;
    }
}