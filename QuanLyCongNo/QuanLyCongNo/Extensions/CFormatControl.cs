using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCongNo.Extensions
{
    public static class CFormatControl
    {
        #region Format SpinEdit
        public static void Format(this SpinEdit spnMain, int DecimalScale = 0, bool LeftAlight = true, bool NotNegative = true, bool FormatNumber = true)
        {
            spnMain.Properties.Buttons.Clear();
            spnMain.Properties.Mask.UseMaskAsDisplayFormat = true;
            //spnMain.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            spnMain.Properties.AppearanceReadOnly.TextOptions.HAlignment = spnMain.Properties.AppearanceFocused.TextOptions.HAlignment = spnMain.Properties.Appearance.TextOptions.HAlignment = LeftAlight ? HorzAlignment.Near : HorzAlignment.Far;
            spnMain.Properties.Mask.EditMask = spnMain.Properties.DisplayFormat.FormatString = spnMain.Properties.EditFormat.FormatString = "N" + DecimalScale.ToString();
            if (NotNegative)
            {
                spnMain.KeyPress += NotNegative_KeyPress;
                if (spnMain.Properties.MinValue == spnMain.Properties.MaxValue)
                {
                    spnMain.Properties.MaxValue = decimal.MaxValue;
                }
                if (spnMain.Properties.MinValue < 0)
                    spnMain.Properties.MinValue = 0;

            }
            if (FormatNumber)
            {

                spnMain.Properties.DisplayFormat.FormatType = FormatType.Custom;
                spnMain.Properties.DisplayFormat.FormatString = "{0:###,###,###.##}";
            }
        }
        public static void Format(this RepositoryItemSpinEdit res_sp_Main, int DecimalScale = 0, bool LeftAlight = true, bool NotNegative = true, bool FormatNumber = true)
        {
            res_sp_Main.Buttons.Clear();
            res_sp_Main.Mask.UseMaskAsDisplayFormat = true;
            res_sp_Main.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            res_sp_Main.AppearanceReadOnly.TextOptions.HAlignment = res_sp_Main.AppearanceFocused.TextOptions.HAlignment = res_sp_Main.Appearance.TextOptions.HAlignment = LeftAlight ? HorzAlignment.Near : HorzAlignment.Far;
            res_sp_Main.Mask.EditMask = res_sp_Main.DisplayFormat.FormatString = res_sp_Main.EditFormat.FormatString = "N" + DecimalScale.ToString();
            if (NotNegative)
            {
                res_sp_Main.KeyPress += NotNegative_KeyPress;
                if (res_sp_Main.MinValue == res_sp_Main.MaxValue)
                {
                    res_sp_Main.MaxValue = decimal.MaxValue;
                }
                if (res_sp_Main.MinValue < 0)
                    res_sp_Main.MinValue = 0;

            }
            //if (FormatNumber)
            //{

            //    res_sp_Main.DisplayFormat.FormatType = FormatType.Custom;
            //    res_sp_Main.DisplayFormat.FormatString = "{0:###.###.###,##}";
            //}
        }
        public static void NotNegative_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }
        #endregion
    }
}
