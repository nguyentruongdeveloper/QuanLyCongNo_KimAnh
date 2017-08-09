namespace QuanLyCongNo.GUI.Common
{
    partial class frmDanhMuc_Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMuc_Base));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_DanhMuc_ThemMoi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btn_DanhMuc_Sua = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btn_DanhMuc_Xoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btn_DanhMuc_NapLai = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btn_DanhMuc_Dong = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem4 = new DevExpress.XtraBars.BarLargeButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
            this.barLargeButtonItem3,
            this.barLargeButtonItem4,
            this.btn_DanhMuc_ThemMoi,
            this.btn_DanhMuc_Sua,
            this.btn_DanhMuc_Xoa,
            this.btn_DanhMuc_NapLai,
            this.btn_DanhMuc_Dong,
            this.barToggleSwitchItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 15;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DanhMuc_ThemMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DanhMuc_Sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DanhMuc_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DanhMuc_NapLai),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DanhMuc_Dong),
            new DevExpress.XtraBars.LinkPersistInfo(this.barToggleSwitchItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_DanhMuc_ThemMoi
            // 
            this.btn_DanhMuc_ThemMoi.Caption = "Thêm mới";
            this.btn_DanhMuc_ThemMoi.Id = 9;
            this.btn_DanhMuc_ThemMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DanhMuc_ThemMoi.ImageOptions.LargeImage")));
            this.btn_DanhMuc_ThemMoi.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btn_DanhMuc_ThemMoi.Name = "btn_DanhMuc_ThemMoi";
            this.btn_DanhMuc_ThemMoi.Size = new System.Drawing.Size(90, 0);
            this.btn_DanhMuc_ThemMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DanhMuc_ThemMoi_ItemClick);
            // 
            // btn_DanhMuc_Sua
            // 
            this.btn_DanhMuc_Sua.Caption = "Sửa";
            this.btn_DanhMuc_Sua.Id = 10;
            this.btn_DanhMuc_Sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DanhMuc_Sua.ImageOptions.LargeImage")));
            this.btn_DanhMuc_Sua.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            this.btn_DanhMuc_Sua.Name = "btn_DanhMuc_Sua";
            this.btn_DanhMuc_Sua.Size = new System.Drawing.Size(90, 0);
            this.btn_DanhMuc_Sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DanhMuc_Sua_ItemClick);
            // 
            // btn_DanhMuc_Xoa
            // 
            this.btn_DanhMuc_Xoa.Caption = "Xóa";
            this.btn_DanhMuc_Xoa.Id = 11;
            this.btn_DanhMuc_Xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DanhMuc_Xoa.ImageOptions.LargeImage")));
            this.btn_DanhMuc_Xoa.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.btn_DanhMuc_Xoa.Name = "btn_DanhMuc_Xoa";
            this.btn_DanhMuc_Xoa.Size = new System.Drawing.Size(90, 0);
            this.btn_DanhMuc_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DanhMuc_Xoa_ItemClick);
            // 
            // btn_DanhMuc_NapLai
            // 
            this.btn_DanhMuc_NapLai.Caption = "Nạp lại";
            this.btn_DanhMuc_NapLai.Id = 12;
            this.btn_DanhMuc_NapLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DanhMuc_NapLai.ImageOptions.LargeImage")));
            this.btn_DanhMuc_NapLai.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.btn_DanhMuc_NapLai.Name = "btn_DanhMuc_NapLai";
            this.btn_DanhMuc_NapLai.Size = new System.Drawing.Size(90, 0);
            this.btn_DanhMuc_NapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DanhMuc_NapLai_ItemClick);
            // 
            // btn_DanhMuc_Dong
            // 
            this.btn_DanhMuc_Dong.Caption = "Đóng";
            this.btn_DanhMuc_Dong.Id = 13;
            this.btn_DanhMuc_Dong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DanhMuc_Dong.ImageOptions.LargeImage")));
            this.btn_DanhMuc_Dong.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.btn_DanhMuc_Dong.Name = "btn_DanhMuc_Dong";
            this.btn_DanhMuc_Dong.Size = new System.Drawing.Size(90, 0);
            this.btn_DanhMuc_Dong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DanhMuc_Dong_ItemClick);
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barToggleSwitchItem1.Caption = "Kích hoạt";
            this.barToggleSwitchItem1.Id = 14;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1165, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 615);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1165, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 556);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1165, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 556);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm mới";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Làm Mới";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Đóng";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Thêm mới";
            this.barLargeButtonItem1.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Far;
            this.barLargeButtonItem1.Id = 5;
            this.barLargeButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.Image")));
            this.barLargeButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.LargeImage")));
            this.barLargeButtonItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.barLargeButtonItem1.MinSize = new System.Drawing.Size(80, 0);
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            this.barLargeButtonItem1.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.barLargeButtonItem1.Size = new System.Drawing.Size(50, 50);
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "Sửa";
            this.barLargeButtonItem2.Id = 6;
            this.barLargeButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem2.ImageOptions.Image")));
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // barLargeButtonItem3
            // 
            this.barLargeButtonItem3.Caption = "Xóa";
            this.barLargeButtonItem3.Id = 7;
            this.barLargeButtonItem3.Name = "barLargeButtonItem3";
            // 
            // barLargeButtonItem4
            // 
            this.barLargeButtonItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barLargeButtonItem4.Caption = "Thêm mới";
            this.barLargeButtonItem4.Id = 8;
            this.barLargeButtonItem4.ImageOptions.ImageUri.Uri = "AddItem;Size16x16";
            this.barLargeButtonItem4.MinSize = new System.Drawing.Size(100, 0);
            this.barLargeButtonItem4.Name = "barLargeButtonItem4";
            // 
            // frmDanhMuc_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 615);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDanhMuc_Base";
            this.Load += new System.EventHandler(this.frmDanhMuc_Base_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btn_DanhMuc_ThemMoi;
        private DevExpress.XtraBars.BarLargeButtonItem btn_DanhMuc_Sua;
        private DevExpress.XtraBars.BarLargeButtonItem btn_DanhMuc_Xoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem3;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem4;
        private DevExpress.XtraBars.BarLargeButtonItem btn_DanhMuc_NapLai;
        private DevExpress.XtraBars.BarLargeButtonItem btn_DanhMuc_Dong;
        public DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
    }
}