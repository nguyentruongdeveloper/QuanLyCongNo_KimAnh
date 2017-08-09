using DevExpress;
namespace QuanLyCongNo.GUI.Common
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lblMessage = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btn_Login_Huy = new DevExpress.XtraEditors.CheckButton();
            this.btn_Login_DangNhap = new DevExpress.XtraEditors.CheckButton();
            this.ck_Login_GhiNho = new DevExpress.XtraEditors.CheckEdit();
            this.txt_Login_MatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txt_Login_DangNhap = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDangNhap = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHuy = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_Login_GhiNho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Login_MatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Login_DangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.lblMessage);
            this.lcMain.Controls.Add(this.pictureEdit1);
            this.lcMain.Controls.Add(this.btn_Login_Huy);
            this.lcMain.Controls.Add(this.btn_Login_DangNhap);
            this.lcMain.Controls.Add(this.ck_Login_GhiNho);
            this.lcMain.Controls.Add(this.txt_Login_MatKhau);
            this.lcMain.Controls.Add(this.txt_Login_DangNhap);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(918, 137, 250, 350);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(449, 167);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // lblMessage
            // 
            this.lblMessage.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMessage.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblMessage.Appearance.Options.UseFont = true;
            this.lblMessage.Appearance.Options.UseForeColor = true;
            this.lblMessage.Location = new System.Drawing.Point(114, 104);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(319, 11);
            this.lblMessage.StyleController = this.lcMain;
            this.lblMessage.TabIndex = 7;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::QuanLyCongNo.Properties.Resources.LoginIcon;
            this.pictureEdit1.Location = new System.Drawing.Point(16, 16);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(92, 135);
            this.pictureEdit1.StyleController = this.lcMain;
            this.pictureEdit1.TabIndex = 6;
            // 
            // btn_Login_Huy
            // 
            this.btn_Login_Huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Login_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login_Huy.Image")));
            this.btn_Login_Huy.Location = new System.Drawing.Point(333, 121);
            this.btn_Login_Huy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Login_Huy.MaximumSize = new System.Drawing.Size(100, 0);
            this.btn_Login_Huy.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_Login_Huy.Name = "btn_Login_Huy";
            this.btn_Login_Huy.Size = new System.Drawing.Size(100, 27);
            this.btn_Login_Huy.StyleController = this.lcMain;
            this.btn_Login_Huy.TabIndex = 5;
            this.btn_Login_Huy.Text = "&Hủy";
            this.btn_Login_Huy.CheckedChanged += new System.EventHandler(this.btn_Login_Huy_CheckedChanged);
            this.btn_Login_Huy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btn_Login_DangNhap
            // 
            this.btn_Login_DangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login_DangNhap.Image")));
            this.btn_Login_DangNhap.Location = new System.Drawing.Point(220, 121);
            this.btn_Login_DangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Login_DangNhap.MaximumSize = new System.Drawing.Size(100, 0);
            this.btn_Login_DangNhap.Name = "btn_Login_DangNhap";
            this.btn_Login_DangNhap.Size = new System.Drawing.Size(100, 27);
            this.btn_Login_DangNhap.StyleController = this.lcMain;
            this.btn_Login_DangNhap.TabIndex = 4;
            this.btn_Login_DangNhap.Text = "&Đăng nhập";
            this.btn_Login_DangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // ck_Login_GhiNho
            // 
            this.ck_Login_GhiNho.Location = new System.Drawing.Point(114, 77);
            this.ck_Login_GhiNho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ck_Login_GhiNho.Name = "ck_Login_GhiNho";
            this.ck_Login_GhiNho.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ck_Login_GhiNho.Properties.Appearance.Options.UseFont = true;
            this.ck_Login_GhiNho.Properties.Caption = "&Nhớ tài khoản và mật khẩu";
            this.ck_Login_GhiNho.Size = new System.Drawing.Size(319, 21);
            this.ck_Login_GhiNho.StyleController = this.lcMain;
            this.ck_Login_GhiNho.TabIndex = 3;
            // 
            // txt_Login_MatKhau
            // 
            this.txt_Login_MatKhau.EditValue = "";
            this.txt_Login_MatKhau.Location = new System.Drawing.Point(215, 48);
            this.txt_Login_MatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Login_MatKhau.Name = "txt_Login_MatKhau";
            this.txt_Login_MatKhau.Properties.MaxLength = 50;
            this.txt_Login_MatKhau.Properties.PasswordChar = '*';
            this.txt_Login_MatKhau.Properties.UseSystemPasswordChar = true;
            this.txt_Login_MatKhau.Size = new System.Drawing.Size(218, 23);
            this.txt_Login_MatKhau.StyleController = this.lcMain;
            this.txt_Login_MatKhau.TabIndex = 2;
            this.txt_Login_MatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
            // 
            // txt_Login_DangNhap
            // 
            this.txt_Login_DangNhap.EditValue = "";
            this.txt_Login_DangNhap.Location = new System.Drawing.Point(215, 16);
            this.txt_Login_DangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Login_DangNhap.Name = "txt_Login_DangNhap";
            this.txt_Login_DangNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login_DangNhap.Properties.Appearance.Options.UseFont = true;
            this.txt_Login_DangNhap.Properties.MaxLength = 20;
            this.txt_Login_DangNhap.Size = new System.Drawing.Size(218, 26);
            this.txt_Login_DangNhap.StyleController = this.lcMain;
            this.txt_Login_DangNhap.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.lciDangNhap,
            this.lciHuy,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(449, 167);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_Login_MatKhau;
            this.layoutControlItem2.Location = new System.Drawing.Point(98, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(325, 29);
            this.layoutControlItem2.Text = "&Mật khẩu: ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(98, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_Login_DangNhap;
            this.layoutControlItem1.Location = new System.Drawing.Point(98, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(325, 32);
            this.layoutControlItem1.Text = "&Tên đăng nhập:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(98, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ck_Login_GhiNho;
            this.layoutControlItem3.Location = new System.Drawing.Point(98, 61);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(325, 27);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // lciDangNhap
            // 
            this.lciDangNhap.Control = this.btn_Login_DangNhap;
            this.lciDangNhap.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lciDangNhap.Location = new System.Drawing.Point(204, 105);
            this.lciDangNhap.Name = "lciDangNhap";
            this.lciDangNhap.Size = new System.Drawing.Size(113, 36);
            this.lciDangNhap.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciDangNhap.TextSize = new System.Drawing.Size(0, 0);
            this.lciDangNhap.TextToControlDistance = 0;
            this.lciDangNhap.TextVisible = false;
            // 
            // lciHuy
            // 
            this.lciHuy.Control = this.btn_Login_Huy;
            this.lciHuy.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lciHuy.Location = new System.Drawing.Point(317, 105);
            this.lciHuy.Name = "lciHuy";
            this.lciHuy.Size = new System.Drawing.Size(106, 36);
            this.lciHuy.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciHuy.TextSize = new System.Drawing.Size(0, 0);
            this.lciHuy.TextToControlDistance = 0;
            this.lciHuy.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.pictureEdit1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(98, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(98, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(98, 141);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.lblMessage;
            this.layoutControlItem7.Location = new System.Drawing.Point(98, 88);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(0, 17);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(17, 17);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(325, 17);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            this.layoutControlItem7.TrimClientAreaToControl = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(98, 105);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(106, 36);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btn_Login_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Login_Huy;
            this.ClientSize = new System.Drawing.Size(449, 167);
            this.Controls.Add(this.lcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_Login_GhiNho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Login_MatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Login_DangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txt_Login_DangNhap;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txt_Login_MatKhau;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.CheckEdit ck_Login_GhiNho;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.CheckButton btn_Login_Huy;
        private DevExpress.XtraEditors.CheckButton btn_Login_DangNhap;
        private DevExpress.XtraLayout.LayoutControlItem lciDangNhap;
        private DevExpress.XtraLayout.LayoutControlItem lciHuy;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.LabelControl lblMessage;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}