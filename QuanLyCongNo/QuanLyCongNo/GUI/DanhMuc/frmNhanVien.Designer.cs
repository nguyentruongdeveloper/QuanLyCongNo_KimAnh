namespace QuanLyCongNo.GUI.DanhMuc
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.myGrid = new QuanLyCongNo.MyControl.MyGrid();
            this.myGridView1 = new QuanLyCongNo.MyControl.MyGridView();
            this.col_Auto_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_MaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_SoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // myGrid
            // 
            this.myGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGrid.Location = new System.Drawing.Point(0, 59);
            this.myGrid.MainView = this.myGridView1;
            this.myGrid.Name = "myGrid";
            this.myGrid.Size = new System.Drawing.Size(1165, 556);
            this.myGrid.TabIndex = 4;
            this.myGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Auto_ID,
            this.col_MaNhanVien,
            this.col_TenNhanVien,
            this.col_SoDienThoai,
            this.col_DiaChi});
            this.myGridView1.GridControl = this.myGrid;
            this.myGridView1.IndicatorWidth = 40;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsSelection.MultiSelect = true;
            this.myGridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.myGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.myGridView1.OptionsView.ShowAutoFilterRow = true;
            this.myGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_Auto_ID
            // 
            this.col_Auto_ID.Caption = "MSHT";
            this.col_Auto_ID.FieldName = "Auto_ID";
            this.col_Auto_ID.MaxWidth = 80;
            this.col_Auto_ID.Name = "col_Auto_ID";
            this.col_Auto_ID.Visible = true;
            this.col_Auto_ID.VisibleIndex = 0;
            // 
            // col_MaNhanVien
            // 
            this.col_MaNhanVien.Caption = "Mã nhân viên";
            this.col_MaNhanVien.FieldName = "MaNhanVien";
            this.col_MaNhanVien.MaxWidth = 200;
            this.col_MaNhanVien.Name = "col_MaNhanVien";
            this.col_MaNhanVien.Visible = true;
            this.col_MaNhanVien.VisibleIndex = 1;
            // 
            // col_TenNhanVien
            // 
            this.col_TenNhanVien.Caption = "Tên nhân viên";
            this.col_TenNhanVien.FieldName = "TenNhanVien";
            this.col_TenNhanVien.Name = "col_TenNhanVien";
            this.col_TenNhanVien.Visible = true;
            this.col_TenNhanVien.VisibleIndex = 2;
            // 
            // col_SoDienThoai
            // 
            this.col_SoDienThoai.Caption = "Số điện thoại";
            this.col_SoDienThoai.FieldName = "SoDienThoai";
            this.col_SoDienThoai.MaxWidth = 200;
            this.col_SoDienThoai.Name = "col_SoDienThoai";
            this.col_SoDienThoai.Visible = true;
            this.col_SoDienThoai.VisibleIndex = 3;
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.Caption = "Địa chỉ";
            this.col_DiaChi.FieldName = "DiaChi";
            this.col_DiaChi.Name = "col_DiaChi";
            this.col_DiaChi.Visible = true;
            this.col_DiaChi.VisibleIndex = 4;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 615);
            this.Controls.Add(this.myGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.Controls.SetChildIndex(this.myGrid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControl.MyGrid myGrid;
        private MyControl.MyGridView myGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_Auto_ID;
        private DevExpress.XtraGrid.Columns.GridColumn col_MaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn col_TenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn col_SoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn col_DiaChi;
    }
}