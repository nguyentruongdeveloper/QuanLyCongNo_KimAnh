using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Utility;

namespace QuanLyCongNo.GUI.Common
{
    public partial class frmSub_DanhMuc_Base : DevExpress.XtraEditors.XtraForm
    {
        public FormType fType { get; set; }

        public frmSub_DanhMuc_Base()
        {
            InitializeComponent();
        }

        private void frmSub_DanhMuc_Base_Load(object sender, EventArgs e)
        {
            customForm();
            loadData();

        }
        protected virtual void customForm()
        {

        }
        protected virtual void loadData()
        {
            

        }
        protected virtual bool validateForm()
        {
            return true;

        }
        protected virtual bool saveData()
        {
            return true;

        }
        protected virtual void closeForm()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}