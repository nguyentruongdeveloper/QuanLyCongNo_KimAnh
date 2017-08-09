using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyCongNo.Extensions;

namespace QuanLyCongNo.GUI.HeThong
{
    public partial class frmThayDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmThayDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmThayDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
        private void customForm()
        {

        }
        private void loadData()
        {

        }
        private bool validateForm()
        {
            bool v_blResult = true;
            return v_blResult;
        }
        private bool saveData()
        {
            bool v_blResult = true;
            return v_blResult;

        }
        private void Cancel()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(validateForm())
            {
                if(saveData())
                {
                    CExtensions.showMessage("Lưu dữ liệu thành công!");
                }
                else
                {
                    CExtensions.showMessage("Lưu dữ liệu không thành công!");
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Cancel();

        }
    }
}