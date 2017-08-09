namespace QuanLyCongNo.GUI.HeThong
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.myGrid1 = new QuanLyCongNo.MyControl.MyGrid();
            this.myGridView1 = new QuanLyCongNo.MyControl.MyGridView();
            this.col_Auto_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // myGrid1
            // 
            this.myGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGrid1.Location = new System.Drawing.Point(0, 59);
            this.myGrid1.MainView = this.myGridView1;
            this.myGrid1.Name = "myGrid1";
            this.myGrid1.Size = new System.Drawing.Size(1223, 664);
            this.myGrid1.TabIndex = 4;
            this.myGrid1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Auto_ID,
            this.col_NhanVien,
            this.col_TaiKhoan,
            this.gridColumn1});
            this.myGridView1.GridControl = this.myGrid1;
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
            this.col_Auto_ID.MaxWidth = 100;
            this.col_Auto_ID.MinWidth = 100;
            this.col_Auto_ID.Name = "col_Auto_ID";
            this.col_Auto_ID.Visible = true;
            this.col_Auto_ID.VisibleIndex = 0;
            this.col_Auto_ID.Width = 100;
            // 
            // col_NhanVien
            // 
            this.col_NhanVien.Caption = "Nhân viên";
            this.col_NhanVien.FieldName = "NhanVien_ID";
            this.col_NhanVien.Name = "col_NhanVien";
            this.col_NhanVien.Visible = true;
            this.col_NhanVien.VisibleIndex = 1;
            // 
            // col_TaiKhoan
            // 
            this.col_TaiKhoan.Caption = "Tài khoản";
            this.col_TaiKhoan.FieldName = "TaiKhoan";
            this.col_TaiKhoan.Name = "col_TaiKhoan";
            this.col_TaiKhoan.Visible = true;
            this.col_TaiKhoan.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 723);
            this.Controls.Add(this.myGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaiKhoan";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.Controls.SetChildIndex(this.myGrid1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.myGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControl.MyGrid myGrid1;
        private MyControl.MyGridView myGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_Auto_ID;
        private DevExpress.XtraGrid.Columns.GridColumn col_NhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn col_TaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}