namespace QuanLyCongNo.GUI.DanhMuc
{
    partial class frmNoiDungThuChi
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoiDungThuChi));
            this.myGrid = new QuanLyCongNo.MyControl.MyGrid();
            this.myGridView1 = new QuanLyCongNo.MyControl.MyGridView();
            this.col_Auto_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_LoaiThuChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.res_lok = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.res_lok)).BeginInit();
            this.SuspendLayout();
            // 
            // myGrid
            // 
            this.myGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.myGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.myGrid.Location = new System.Drawing.Point(0, 59);
            this.myGrid.MainView = this.myGridView1;
            this.myGrid.Name = "myGrid";
            this.myGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.res_lok});
            this.myGrid.Size = new System.Drawing.Size(1165, 556);
            this.myGrid.TabIndex = 4;
            this.myGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Auto_ID,
            this.col_LoaiThuChi,
            this.col_NoiDung,
            this.gridColumn1});
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
            // col_LoaiThuChi
            // 
            this.col_LoaiThuChi.Caption = "Loại thu chi";
            this.col_LoaiThuChi.FieldName = "TenLoai";
            this.col_LoaiThuChi.MaxWidth = 200;
            this.col_LoaiThuChi.Name = "col_LoaiThuChi";
            this.col_LoaiThuChi.Visible = true;
            this.col_LoaiThuChi.VisibleIndex = 1;
            this.col_LoaiThuChi.Width = 200;
            // 
            // col_NoiDung
            // 
            this.col_NoiDung.Caption = "Nội Dung";
            this.col_NoiDung.FieldName = "NoiDung";
            this.col_NoiDung.Name = "col_NoiDung";
            this.col_NoiDung.Visible = true;
            this.col_NoiDung.VisibleIndex = 2;
            this.col_NoiDung.Width = 701;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 142;
            // 
            // res_lok
            // 
            this.res_lok.AutoHeight = false;
            this.res_lok.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.res_lok.Name = "res_lok";
            // 
            // frmNoiDungThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 615);
            this.Controls.Add(this.myGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNoiDungThuChi";
            this.Text = "Nội Dung Thu Chi";
            this.Load += new System.EventHandler(this.frmNoiDungThuChi_Load);
            this.Controls.SetChildIndex(this.myGrid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.res_lok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControl.MyGrid myGrid;
        private MyControl.MyGridView myGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_Auto_ID;
        private DevExpress.XtraGrid.Columns.GridColumn col_LoaiThuChi;
        private DevExpress.XtraGrid.Columns.GridColumn col_NoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit res_lok;
    }
}