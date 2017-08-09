namespace QuanLyCongNo.GUI.DanhMuc
{
    partial class frmDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVu));
            this.myGrid = new QuanLyCongNo.MyControl.MyGrid();
            this.myGridView1 = new QuanLyCongNo.MyControl.MyGridView();
            this.col_Auto_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_MaDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TenDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.col_MaDichVu,
            this.col_TenDichVu,
            this.col_DienGiai});
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
            this.col_Auto_ID.MaxWidth = 80;
            this.col_Auto_ID.Name = "col_Auto_ID";
            this.col_Auto_ID.Visible = true;
            this.col_Auto_ID.VisibleIndex = 0;
            // 
            // col_MaDichVu
            // 
            this.col_MaDichVu.Caption = "Mã dịch vụ";
            this.col_MaDichVu.MaxWidth = 200;
            this.col_MaDichVu.Name = "col_MaDichVu";
            this.col_MaDichVu.Visible = true;
            this.col_MaDichVu.VisibleIndex = 1;
            // 
            // col_TenDichVu
            // 
            this.col_TenDichVu.Caption = "Tên dịch vụ";
            this.col_TenDichVu.Name = "col_TenDichVu";
            this.col_TenDichVu.Visible = true;
            this.col_TenDichVu.VisibleIndex = 2;
            // 
            // col_DienGiai
            // 
            this.col_DienGiai.Caption = "Diễn giải";
            this.col_DienGiai.Name = "col_DienGiai";
            this.col_DienGiai.Visible = true;
            this.col_DienGiai.VisibleIndex = 3;
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 615);
            this.Controls.Add(this.myGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDichVu";
            this.Text = "Dịch Vụ";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn col_MaDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn col_TenDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn col_DienGiai;
    }
}