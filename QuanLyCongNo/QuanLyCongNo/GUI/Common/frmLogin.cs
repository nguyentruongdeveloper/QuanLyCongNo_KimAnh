using System;
using System.Windows.Forms;
using System.Net;
using QuanLyCongNo.Extensions;

namespace QuanLyCongNo.GUI.Common
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            lcMain.AllowCustomization = false;
            loadDataFrom();
        }
        private void loadDataFrom()
        {
            Properties.Settings.Default.Reload();
            bool v_blCheckGhiNho = Properties.Settings.Default.GhiNo;
            if (v_blCheckGhiNho == true)
            {
                txt_Login_DangNhap.Text = Properties.Settings.Default.Username;
                txt_Login_MatKhau.Text = Properties.Settings.Default.Password;
                ck_Login_GhiNho.Checked = v_blCheckGhiNho;
            }
        }

        private bool validateForm()
        {
            bool v_blResult = true;
            if (string.IsNullOrEmpty(txt_Login_DangNhap.Text))
            {
                txt_Login_DangNhap.ErrorText = "Vui lòng nhập tên đăng nhập!";
                v_blResult = false;
            }
            if (string.IsNullOrEmpty(txt_Login_MatKhau.Text))
            {
                txt_Login_MatKhau.ErrorText = "Vui lòng nhập mật khẩu";
                v_blResult = false;
            }
            return v_blResult;
        }

        private bool Login()
        {
            bool v_blResult = true;
            return v_blResult;

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                if (Login())
                {


                }
                else
                {
                    CExtensions.showMessage("Đăng nhập không thành công!\n Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu!");

                }

            }



        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == (Keys.Alt | Keys.F10))
            //{
            //using (frmQuickAgency _frm = new frmQuickAgency())
            //{
            //    if (_frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            //    {
            //        clsEntity.InitMasterAdmin();
            //        this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //    }
            //}
            // }
        }

        private void btn_Login_Huy_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}