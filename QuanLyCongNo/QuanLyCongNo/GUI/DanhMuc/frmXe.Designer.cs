namespace QuanLyCongNo.GUI.DanhMuc
{
    partial class frmXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXe));
            this.myGrid = new QuanLyCongNo.MyControl.MyGrid();
            this.myGridView1 = new QuanLyCongNo.MyControl.MyGridView();
            this.col_Auto_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_SoXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TenXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TrongTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.myGrid.Size = new System.Drawing.Size(1151, 556);
            this.myGrid.TabIndex = 4;
            this.myGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Auto_ID,
            this.col_SoXe,
            this.col_TenXe,
            this.col_TrongTai,
            this.col_GhiChu});
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
            this.col_Auto_ID.Width = 80;
            // 
            // col_SoXe
            // 
            this.col_SoXe.Caption = "Số xe";
            this.col_SoXe.FieldName = "SoXe";
            this.col_SoXe.MaxWidth = 150;
            this.col_SoXe.Name = "col_SoXe";
            this.col_SoXe.Visible = true;
            this.col_SoXe.VisibleIndex = 1;
            this.col_SoXe.Width = 150;
            // 
            // col_TenXe
            // 
            this.col_TenXe.Caption = "Tên xe";
            this.col_TenXe.FieldName = "TenXe";
            this.col_TenXe.Name = "col_TenXe";
            this.col_TenXe.Visible = true;
            this.col_TenXe.VisibleIndex = 2;
            this.col_TenXe.Width = 371;
            // 
            // col_TrongTai
            // 
            this.col_TrongTai.Caption = "Trọng Tải";
            this.col_TrongTai.FieldName = "TrongTai";
            this.col_TrongTai.Name = "col_TrongTai";
            this.col_TrongTai.Visible = true;
            this.col_TrongTai.VisibleIndex = 3;
            this.col_TrongTai.Width = 198;
            // 
            // col_GhiChu
            // 
            this.col_GhiChu.Caption = "Ghi chú";
            this.col_GhiChu.Name = "col_GhiChu";
            this.col_GhiChu.Visible = true;
            this.col_GhiChu.VisibleIndex = 4;
            this.col_GhiChu.Width = 310;
            // 
            // frmXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 615);
            this.Controls.Add(this.myGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXe";
            this.Text = "Xe";
            this.Load += new System.EventHandler(this.frmXe_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn col_SoXe;
        private DevExpress.XtraGrid.Columns.GridColumn col_TenXe;
        private DevExpress.XtraGrid.Columns.GridColumn col_TrongTai;
        private DevExpress.XtraGrid.Columns.GridColumn col_GhiChu;
    }
}