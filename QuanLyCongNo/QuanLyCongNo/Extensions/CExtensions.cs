using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using QuanLyCongNo.GUI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongNo.Extensions
{
    public class CExtensions
    {
        #region Waiting Form
        public static SplashScreenManager ssmWait = null;
        public static void SetCaptionWaitForm(string Caption = "", string Desctiption = "")
        {
            try
            {
                if (ssmWait != null && ssmWait.IsSplashFormVisible)
                {
                    if (!string.IsNullOrEmpty(Caption))
                        ssmWait.SetWaitFormCaption(Caption);
                    if (!string.IsNullOrEmpty(Desctiption))
                        ssmWait.SetWaitFormDescription(Desctiption);
                }
            }
            catch { }
        }

        public static void CallWaitForm(XtraForm frmParent)
        {
            try
            {
                if (ssmWait == null || !ssmWait.IsSplashFormVisible)
                {
                    ssmWait = new SplashScreenManager(frmParent, typeof(frmWaiting), true, true);
                    ssmWait.ShowWaitForm();
                    SetCaptionWaitForm("Vui lòng chờ!", "Đang xử lý...");
                }
            }
            catch { }
        }

        public static void CloseWaitForm()
        {
            try
            {
                ssmWait.CloseWaitForm();
                ssmWait = null;
            }
            catch { }
        }
        #endregion

        #region Call form
        public class clsCallForm
        {
            public static List<FormItem> fList = null;
            public static void InitFormCollection()
            {
                fList = new List<FormItem>();
                try
                {
                    System.Reflection.Assembly projectA = System.Reflection.Assembly.GetExecutingAssembly();
                    foreach (Type t in projectA.GetTypes())
                    {
                        if (t.BaseType == typeof(XtraForm))
                        {
                            var emptyCtor = t.GetConstructor(Type.EmptyTypes);
                            if (emptyCtor != null)
                            {
                                var f = (XtraForm)emptyCtor.Invoke(new object[] { });
                                //if (clsEntity.Check_Role(clsGeneral.curPersonnel.eAccount, f.Name))
                                fList.Add(new FormItem(f.Name, f));
                            }
                        }
                        else if(t.BaseType == typeof(frmDanhMuc_Base))
                        {
                            var emptyCtor = t.GetConstructor(Type.EmptyTypes);
                            if (emptyCtor != null)
                            {
                                var f = (XtraForm)emptyCtor.Invoke(new object[] { });
                                //if (clsEntity.Check_Role(clsGeneral.curPersonnel.eAccount, f.Name))
                                fList.Add(new FormItem(f.Name, f));
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    showErrorException(ex, "Exception");
                }
            }

            public static XtraForm CreateNewForm(string bbiName)
            {
                var referrenceName = "";
                var firstUndercoreIndex = bbiName.IndexOf("_");
                if (firstUndercoreIndex < 0)
                {
                    referrenceName = bbiName;
                }
                else
                {
                    referrenceName = bbiName.Substring(firstUndercoreIndex + 1);
                    var secondUndercoreIndex = referrenceName.IndexOf("_");
                    referrenceName = referrenceName.Substring(0, secondUndercoreIndex) + ".frm" +
                                     referrenceName.Substring(secondUndercoreIndex + 1);
                }
                if (fList == null)
                    return null;
                try
                {
                    var cForms = fList.FirstOrDefault(f => f._fType.FullName.Contains(referrenceName)).CForm;
                    return cForms;
                }
                catch { return null; }
            }
        }

        public class FormItem
        {
            string _bbiName;

            public string BbiName
            {
                get { return _bbiName; }
                set { _bbiName = value; }
            }
            XtraForm _cForm;
            public Type _fType;
            public FormItem(string bbiName, XtraForm frmIn)
            {
                this._bbiName = bbiName;
                this._cForm = frmIn;
                this._fType = frmIn.GetType();
            }
            public XtraForm CForm
            {
                get
                {
                    if (_cForm == null || !_cForm.IsHandleCreated)
                    {
                        _cForm = (XtraForm)Activator.CreateInstance(_fType);
                    }
                    return _cForm;
                }
                set { _cForm = value; }
            }
        }
        #endregion

        #region Hiện thị thông báo
        static GUI.Common.frmMessage _frmMessage;
        static GUI.Common.frmConfirm _frmConfirm;
        static GUI.Common.frmError _frmError;

        /// <summary>
        /// Dùng để thông báo đến người dùng
        /// </summary>
        /// <param name="_message"></param>
        public static void showMessage(string _message)
        {
            if (_frmMessage == null)
                _frmMessage = new GUI.Common.frmMessage();
            if (!_frmMessage.IsHandleCreated)
            {
                _frmMessage.lblMessage.Text = _message;
                _frmMessage.ShowDialog();
            }
        }

        /// <summary>
        /// Dùng để xác nhận thông tin với người dùng
        /// </summary>
        /// <param name="_message"></param>
        /// <returns></returns>
        public static bool showConfirmMessage(string _message)
        {
            if (_frmConfirm == null)
                _frmConfirm = new GUI.Common.frmConfirm();
            if (!_frmConfirm.IsHandleCreated)
            {
                _frmConfirm.lblMessage.Text = _message;
                if (_frmConfirm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Dùng để hiển thị Exception
        /// </summary>
        /// <param name="_ex"></param>
        /// <param name="_message"></param>
        public static void showErrorException(Exception _ex, string _message)
        {
            if (_frmError == null) _frmError = new GUI.Common.frmError();
            if (!_frmError.IsHandleCreated)
            {
                _frmError.lblMessage.Text = _message;
                _frmError.meError.Text = _ex.ToString();
                _frmError.ShowDialog();
            }
        }
        #endregion
    }
}
