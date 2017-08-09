namespace QuanLyCongNo
{
    partial class Form1
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
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener1 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener2 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener3 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.reportDesigner1 = new DevExpress.XtraReports.UserDesigner.XRDesignMdiController(this.components);
            this.xrDesignRibbonController1 = new DevExpress.XtraReports.UserDesigner.XRDesignRibbonController(this.components);
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.xrDesignDockManager1 = new DevExpress.XtraReports.UserDesigner.XRDesignDockManager(this.components);
            this.toolBoxDockPanel1 = new DevExpress.XtraReports.UserDesigner.ToolBoxDockPanel();
            this.toolBoxDockPanel1_Container = new DevExpress.XtraReports.UserDesigner.DesignControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignRibbonController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignDockManager1)).BeginInit();
            this.toolBoxDockPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // reportDesigner1
            // 
            this.reportDesigner1.ContainerControl = null;
            xrDesignPanelListener1.DesignControl = this.xrDesignRibbonController1;
            xrDesignPanelListener2.DesignControl = this.xrDesignDockManager1;
            xrDesignPanelListener3.DesignControl = this.toolBoxDockPanel1;
            this.reportDesigner1.DesignPanelListeners.AddRange(new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener[] {
            xrDesignPanelListener1,
            xrDesignPanelListener2,
            xrDesignPanelListener3});
            this.reportDesigner1.Form = this;
            // 
            // xrDesignRibbonController1
            // 
            this.xrDesignRibbonController1.RibbonStatusBar = this.ribbonStatusBar1;
            this.xrDesignRibbonController1.XRDesignDockManager = this.xrDesignDockManager1;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 413);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = null;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1125, 20);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.ShowRightPane = true;
            // 
            // xrDesignDockManager1
            // 
            this.xrDesignDockManager1.Form = this;
            this.xrDesignDockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.toolBoxDockPanel1});
            this.xrDesignDockManager1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("xrDesignDockManager1.ImageStream")));
            this.xrDesignDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // toolBoxDockPanel1
            // 
            this.toolBoxDockPanel1.Controls.Add(this.toolBoxDockPanel1_Container);
            this.toolBoxDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.toolBoxDockPanel1.ID = new System.Guid("161a5a1a-d9b9-4f06-9ac4-d0c3e507c54f");
            this.toolBoxDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.toolBoxDockPanel1.Name = "toolBoxDockPanel1";
            this.toolBoxDockPanel1.OriginalSize = new System.Drawing.Size(165, 200);
            this.toolBoxDockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.toolBoxDockPanel1.SavedIndex = 1;
            this.toolBoxDockPanel1.Size = new System.Drawing.Size(165, 413);
            this.toolBoxDockPanel1.Text = "Toolbox";
            this.toolBoxDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // toolBoxDockPanel1_Container
            // 
            this.toolBoxDockPanel1_Container.Location = new System.Drawing.Point(5, 27);
            this.toolBoxDockPanel1_Container.Name = "toolBoxDockPanel1_Container";
            this.toolBoxDockPanel1_Container.Size = new System.Drawing.Size(153, 381);
            this.toolBoxDockPanel1_Container.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 433);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignRibbonController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignDockManager1)).EndInit();
            this.toolBoxDockPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraReports.UserDesigner.XRDesignMdiController reportDesigner1;
        private DevExpress.XtraReports.UserDesigner.XRDesignRibbonController xrDesignRibbonController1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraReports.UserDesigner.XRDesignDockManager xrDesignDockManager1;
        private DevExpress.XtraReports.UserDesigner.ToolBoxDockPanel toolBoxDockPanel1;
        private DevExpress.XtraReports.UserDesigner.DesignControlContainer toolBoxDockPanel1_Container;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
    }
}

