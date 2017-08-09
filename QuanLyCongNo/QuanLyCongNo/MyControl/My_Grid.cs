using DevExpress.XtraGrid;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLyCongNo.MyControl
{
    [ToolboxItem(true)]
    public class MyGrid : GridControl
    {
        private GridView gridView;

        public MyGrid()
        {
            Dock = DockStyle.Fill;
            Name = "grid_data";
        }
        protected override DevExpress.XtraGrid.Views.Base.BaseView CreateDefaultView()
        {
            return CreateView("MyView");
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }

        private void InitializeComponent()
        {
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView.GridControl = this;
            this.gridView.Name = "gridView1";
            // 
            // MyGrid
            // 
            this.MainView = this.gridView;
            this.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

    }

    public class MyGridView : GridView
    {
        public MyGridView() : this(null) { }
        public MyGridView(GridControl grid)
            : base(grid)
        {
            BeginInit();

            // CODE GIAO DIỆN CHO GRIDVIEW SAU
            // ...


            //formmat cell header
            foreach (DevExpress.XtraGrid.Columns.GridColumn v_objcol in this.Columns)
            {
                v_objcol.AppearanceHeader.Font = new Font("Arial", 12);
                v_objcol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }


            OptionsSelection.MultiSelect = true;
            OptionsView.EnableAppearanceEvenRow = true;
            OptionsView.ShowAutoFilterRow = true;
            OptionsView.ShowGroupPanel = false;
            OptionsView.AllowHtmlDrawHeaders = true;
           


            IndicatorWidth = 40;
            // tạo thêm cột stt
            CustomDrawRowIndicator += new RowIndicatorCustomDrawEventHandler(MyGridView_CustomDrawRowIndicator);


            EndInit();
        }

        void MyGridView_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }

    public class MyGridViewInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName
        {
            get { return "MyView"; }
        }

        public override DevExpress.XtraGrid.Views.Base.BaseView CreateView(GridControl grid)
        {
            return new MyGridView(grid);
        }
    }
}
