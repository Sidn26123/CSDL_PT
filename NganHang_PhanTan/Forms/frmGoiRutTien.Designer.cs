
namespace NganHang_PhanTan
{
    partial class frmGoiRutTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoiRutTien));
            this.stkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.backBarActionBtn = new DevExpress.XtraBars.BarButtonItem();
            this.nextBarActionBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.label2 = new System.Windows.Forms.Label();
            this.soTienTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.takeActionBtn = new System.Windows.Forms.Button();
            this.nameOfSTKOwnerTxt = new System.Windows.Forms.Label();
            this.loaiGDRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.label3 = new System.Windows.Forms.Label();
            this.amountMoneyTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTienTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiGDRadioGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // stkTextEdit
            // 
            this.stkTextEdit.Location = new System.Drawing.Point(180, 79);
            this.stkTextEdit.Name = "stkTextEdit";
            this.stkTextEdit.Size = new System.Drawing.Size(134, 20);
            this.stkTextEdit.TabIndex = 0;
            this.stkTextEdit.EditValueChanged += new System.EventHandler(this.stkTextEdit_EditValueChanged);
            this.stkTextEdit.Leave += new System.EventHandler(this.stkTextEdit_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "STK:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.backBarActionBtn,
            this.nextBarActionBtn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(865, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 383);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(865, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 342);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(865, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 342);
            // 
            // backBarActionBtn
            // 
            this.backBarActionBtn.Caption = "Quay lại";
            this.backBarActionBtn.Id = 0;
            this.backBarActionBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("backBarActionBtn.ImageOptions.Image")));
            this.backBarActionBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("backBarActionBtn.ImageOptions.LargeImage")));
            this.backBarActionBtn.Name = "backBarActionBtn";
            // 
            // nextBarActionBtn
            // 
            this.nextBarActionBtn.Caption = "barButtonItem1";
            this.nextBarActionBtn.Id = 1;
            this.nextBarActionBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("nextBarActionBtn.ImageOptions.Image")));
            this.nextBarActionBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nextBarActionBtn.ImageOptions.LargeImage")));
            this.nextBarActionBtn.Name = "nextBarActionBtn";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 41);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(865, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số tiền:";
            // 
            // soTienTextEdit
            // 
            this.soTienTextEdit.Location = new System.Drawing.Point(180, 129);
            this.soTienTextEdit.Name = "soTienTextEdit";
            this.soTienTextEdit.Properties.EditFormat.FormatString = "#.###";
            this.soTienTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.soTienTextEdit.Properties.Mask.EditMask = "n0";
            this.soTienTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.soTienTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.soTienTextEdit.Size = new System.Drawing.Size(134, 20);
            this.soTienTextEdit.TabIndex = 8;
            this.soTienTextEdit.EditValueChanged += new System.EventHandler(this.soTienTextEdit_EditValueChanged);
            // 
            // takeActionBtn
            // 
            this.takeActionBtn.Location = new System.Drawing.Point(200, 192);
            this.takeActionBtn.Name = "takeActionBtn";
            this.takeActionBtn.Size = new System.Drawing.Size(75, 23);
            this.takeActionBtn.TabIndex = 9;
            this.takeActionBtn.Text = "Thực hiện";
            this.takeActionBtn.UseVisualStyleBackColor = true;
            this.takeActionBtn.Click += new System.EventHandler(this.takeActionBtn_Click);
            // 
            // nameOfSTKOwnerTxt
            // 
            this.nameOfSTKOwnerTxt.AutoSize = true;
            this.nameOfSTKOwnerTxt.Location = new System.Drawing.Point(273, 102);
            this.nameOfSTKOwnerTxt.Name = "nameOfSTKOwnerTxt";
            this.nameOfSTKOwnerTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameOfSTKOwnerTxt.Size = new System.Drawing.Size(0, 13);
            this.nameOfSTKOwnerTxt.TabIndex = 10;
            this.nameOfSTKOwnerTxt.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // loaiGDRadioGroup
            // 
            this.loaiGDRadioGroup.Location = new System.Drawing.Point(420, 113);
            this.loaiGDRadioGroup.MenuManager = this.barManager1;
            this.loaiGDRadioGroup.Name = "loaiGDRadioGroup";
            this.loaiGDRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("GT", "Gửi tiền"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("RT", "Rút tiền")});
            this.loaiGDRadioGroup.Size = new System.Drawing.Size(100, 75);
            this.loaiGDRadioGroup.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Loại GD:";
            // 
            // amountMoneyTxt
            // 
            this.amountMoneyTxt.AutoSize = true;
            this.amountMoneyTxt.Location = new System.Drawing.Point(273, 152);
            this.amountMoneyTxt.Name = "amountMoneyTxt";
            this.amountMoneyTxt.Size = new System.Drawing.Size(0, 13);
            this.amountMoneyTxt.TabIndex = 36;
            this.amountMoneyTxt.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // frmGoiRutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 403);
            this.Controls.Add(this.amountMoneyTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loaiGDRadioGroup);
            this.Controls.Add(this.nameOfSTKOwnerTxt);
            this.Controls.Add(this.takeActionBtn);
            this.Controls.Add(this.soTienTextEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stkTextEdit);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmGoiRutTien";
            this.Text = "Rút tiền";
            this.Load += new System.EventHandler(this.frmGoiRutTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTienTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiGDRadioGroup.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit stkTextEdit;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem backBarActionBtn;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarButtonItem nextBarActionBtn;
        private System.Windows.Forms.Label nameOfSTKOwnerTxt;
        private System.Windows.Forms.Button takeActionBtn;
        private DevExpress.XtraEditors.TextEdit soTienTextEdit;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.RadioGroup loaiGDRadioGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label amountMoneyTxt;
    }
}