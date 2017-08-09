using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class CUtility
    {
        public static DateTime ConvertFromStringToDateTime(string p_strDateTime)
        {
            IFormatProvider culture = new CultureInfo("fr-FR", true);
            return DateTime.Parse(p_strDateTime, culture);
        }

        public static DateTime GetDefaultDate()
        {
            return ConvertFromStringToDateTime("01/01/1900 00:00:00");
        }

        /// <summary>
        /// Cons
        /// </summary>
        public static int Convert_To_Int32(object p_objData)
        {
            if ((p_objData != System.DBNull.Value) && (CUtility.Convert_To_String(p_objData) != ""))
                return Convert.ToInt32(p_objData);
            else
                return CConst.INT_VALUE_NULL;
        }
        public static Int64 Convert_To_Int64(object p_objData)
        {
            if ((p_objData != System.DBNull.Value) && (CUtility.Convert_To_String(p_objData) != ""))
                return Convert.ToInt64(p_objData);
            else
                return CConst.INT_VALUE_NULL;
        }

        /// <summary>
        /// Cons
        /// </summary>
        public static double Convert_To_Double(object p_objData)
        {
            if ((p_objData != System.DBNull.Value) && (CUtility.Convert_To_String(p_objData) != ""))
                return Convert.ToDouble(p_objData);
            else
                return CConst.FLT_VALUE_NULL;
        }
        public static decimal Convert_To_Decimal(object p_objData)
        {
            if ((p_objData != System.DBNull.Value) && (CUtility.Convert_To_String(p_objData) != ""))
                return Convert.ToDecimal(p_objData);
            else
                return CConst.FLT_VALUE_NULL;
        }



        /// <summary>
        /// Cons
        /// </summary>
        public static bool Convert_To_Bool(object p_objData)
        {
            if (p_objData != System.DBNull.Value)
                return Convert.ToBoolean(p_objData);
            else
                return CConst.BL_VALUE_NULL;
        }

        /// <summary>
        /// Cons
        /// </summary>
        public static DateTime Convert_To_DateTime(object p_objData)
        {
            if (p_objData != System.DBNull.Value && p_objData != null)
                return Convert.ToDateTime(p_objData);
            else
                return CConst.DTM_VALUE_NULL;
        }

        /// <summary>
        /// Cons
        /// </summary>
        public static string Convert_To_String(object p_objData)
        {
            return Convert.ToString(p_objData);
        }

        /// <summary>
        /// Mã hoá chuỗi (MD5)
        /// </summary>
        /// <param name="p_strSource">DataSource</param>
        /// /// <param name="p_strIT">Mã số nhận dạng</param>
        /// <returns>string</returns>
        public static string MD5_Encrypt(string p_strSource)
        {
            System.Text.UTF8Encoding utf8encoding = new System.Text.UTF8Encoding();
            byte[] Data = utf8encoding.GetBytes(p_strSource);

            System.Security.Cryptography.MD5CryptoServiceProvider md5Encrypt = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashData = md5Encrypt.ComputeHash(Data);

            string result = "";

            for (int i = 0; i < hashData.Length; i++)
                result += Convert.ToString(hashData[i], 16).PadLeft(2, 'j');

            return result.PadLeft(32, 'n');
        }

        public static DateTime Add_Day_Include_Saturday(DateTime p_dtmNow, int p_iDay)
        {
            int v_iCount = 0;
            int v_iSub = 1;
            if (p_iDay < 0)
                v_iSub = -1;
            DateTime v_dtRes = p_dtmNow;

            while (v_iCount < Math.Abs(p_iDay))
            {
                v_iCount++;
                v_dtRes = v_dtRes.AddDays(v_iSub);

                while (v_dtRes.DayOfWeek == DayOfWeek.Sunday)
                    v_dtRes = v_dtRes.AddDays(v_iSub);
            }

            return v_dtRes;
        }

        public static DateTime Convert_To_Dau_Ngay(DateTime p_dtmDate)
        {
            DateTime v_dtmRes = p_dtmDate;

            v_dtmRes = CUtility.ConvertFromStringToDateTime(p_dtmDate.ToString("dd/MM/yyyy") + " 00:00:00");

            return v_dtmRes;
        }

        public static DateTime Convert_To_Cuoi_Ngay(DateTime p_dtmDate)
        {
            DateTime v_dtmRes = p_dtmDate;

            v_dtmRes = CUtility.ConvertFromStringToDateTime(p_dtmDate.ToString("dd/MM/yyyy") + " 23:59:59");

            return v_dtmRes;
        }


        /// <summary>
        /// Lấy ngày đầu tuần
        /// </summary>
        /// <param name="p_dtmData"></param>
        /// <returns></returns>
        public static DateTime Lay_Ngay_Dau_Tuan(DateTime p_dtmData)
        {
            DateTime v_dtmRes = p_dtmData;

            while (v_dtmRes.DayOfWeek != DayOfWeek.Monday)
                v_dtmRes = v_dtmRes.AddDays(-1);

            return v_dtmRes;
        }

        /// <summary>
        /// Lấy ngày đầu tháng
        /// </summary>
        /// <param name="p_dtmData"></param>
        /// <returns></returns>
        public static DateTime Lay_Ngay_Dau_Thang(DateTime p_dtmData)
        {
            DateTime v_dtmRes = p_dtmData;

            while (v_dtmRes.Day != 1)
                v_dtmRes = v_dtmRes.AddDays(-1);

            return v_dtmRes;
        }

        /// <summary>
        /// Lấy ngày đầu nam
        /// </summary>
        /// <param name="p_dtmData"></param>
        /// <returns></returns>
        public static DateTime Lay_Ngay_Dau_Nam(DateTime p_dtmData)
        {
            DateTime v_dtmRes = p_dtmData;

            while (v_dtmRes.DayOfYear != 1)
                v_dtmRes = v_dtmRes.AddDays(-1);

            return v_dtmRes;
        }

        public static double Min(double p_dbl1, double p_dbl2)
        {
            double v_dblRes = p_dbl1;
            if (v_dblRes > p_dbl2)
                v_dblRes = p_dbl2;
            return v_dblRes;
        }

        public static string Is_Valid_Password_Format(string p_strPass)
        {
            StringBuilder v_sb = new StringBuilder();

            if (p_strPass.Length < 8)
                v_sb.Append("Mật khẩu phải dài ít nhất 8 ký tự.<br/>");

            if (!Is_Contain_Character_Char(p_strPass))
                v_sb.Append("Mật khẩu phải có ít nhất một ký tự chữ.<br/>");

            if (!Is_Contain_Number_Char(p_strPass))
                v_sb.Append("Mật khẩu phải có ít nhất một ký tự số.<br/>");

            if (!Is_Contain_Special_Char(p_strPass))
                v_sb.Append("Mật khẩu phải có ít nhất một ký tự đặc biệt. Ký tự đặt biệt là các ký tự: +-(){}[]!?@#$%^&* <>:;.,=_~`.<br/>");

            return v_sb.ToString();
        }

        public static bool Is_Valid_Phone(string p_strPhone)
        {
            bool v_bRes = true;
            string v_strValid = @"0123456789 .-(){}[]+";
            //Kiểm tra tính hợp lệ,nếu không Contains(chứa) một trong các điều kiện trên là sai
            foreach (char v_c in p_strPhone)
            {
                if (!v_strValid.Contains(v_c.ToString()))
                {
                    v_bRes = false;
                    break;
                }
            }

            return v_bRes;
        }

        public static bool Is_Valid_Dang_Nhap(string p_strDang_Nhap)
        {
            bool v_bRes = true;
            string v_strValid = @"+(){}[]?/\!@#$%^&* <>:;,=~`";
            //Kiểm tra tính hợp lệ,nếu không Contains(chứa) một trong các điều kiện trên là sai
            foreach (char v_c in p_strDang_Nhap)
            {
                if (v_strValid.Contains(v_c.ToString()))
                {
                    v_bRes = false;
                    break;
                }
            }

            return v_bRes;
        }

        /// <summary>
        /// Gởi e-mail
        /// </summary>
        /// <param name="p_strSource">DataSource</param>
        /// <returns>string</returns>
        public static bool SendMailUseSMTP(string p_strFrom, string p_strTo, string p_strSubject,
                                            string p_strMessage, string p_strHost, bool p_bUseDefaultCredentials, int p_iPort,
                                            string p_strUser, string p_strPass, bool p_bEnableSsl)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            bool result = regex.IsMatch(p_strFrom);
            if (result == false)
            {
                throw new Exception("Email không hợp lệ!!!");
            }
            else
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                SmtpClient smtp = new SmtpClient(p_strHost);

                mail.From = new MailAddress(p_strFrom);
                mail.To.Add(p_strTo);
                mail.Subject = p_strSubject;
                mail.Body = p_strMessage;
                mail.IsBodyHtml = true;

                smtp.UseDefaultCredentials = p_bUseDefaultCredentials;
                smtp.Port = p_iPort;
                smtp.Credentials = new System.Net.NetworkCredential(p_strUser, p_strPass);
                smtp.EnableSsl = p_bEnableSsl;
                smtp.Send(mail);
                return true;
            }
        }

        private static bool Is_Contain_Character_Char(string p_strData)
        {
            bool v_bRes = false;

            //Kiểm tra tính hợp lệ,nếu không Contains(chứa) một trong các điều kiện trên là sai
            foreach (char v_c in p_strData)
            {
                if ((v_c >= 'A' && v_c <= 'Z') || (v_c >= 'a' && v_c <= 'z'))
                {
                    v_bRes = true;
                    break;
                }
            }

            return v_bRes;
        }

        private static bool Is_Contain_Special_Char(string p_strData)
        {
            bool v_bRes = false;
            string v_strValid = @"+-(){}[]?/\!@#$%^&* <>:;.,=_~`";

            //Kiểm tra tính hợp lệ,nếu không Contains(chứa) một trong các điều kiện trên là sai
            foreach (char v_c in p_strData)
            {
                if (v_strValid.Contains(v_c.ToString()))
                {
                    v_bRes = true;
                    break;
                }
            }

            return v_bRes;
        }

        private static bool Is_Contain_Number_Char(string p_strData)
        {
            bool v_bRes = false;

            //Kiểm tra tính hợp lệ,nếu không Contains(chứa) một trong các điều kiện trên là sai
            foreach (char v_c in p_strData)
            {
                if (v_c >= 48 && v_c <= 57)
                {
                    v_bRes = true;
                    break;
                }
            }

            return v_bRes;
        }

        //public static void Deleted_File(string p_strPath)
        //{
        //    if (File.Exists(p_strPath))
        //        File.Delete(p_strPath);
        //}

        public static string Convert_Tieng_Viet_Co_Dau_To_Khong_Dau(string p_strText)
        {
            string v_strRes = "";
            if (p_strText != null)
            {
                string[] v_arrText = p_strText.Split('/');

                for (int v_i = 0; v_i < v_arrText.Length; v_i++)
                    v_arrText[v_i] = Convert_Tieng_Viet_Co_Dau_To_Khong_Dau_Sub(v_arrText[v_i]);

                foreach (string v_strText in v_arrText)
                    v_strRes += "/" + v_strText;

                v_strRes = v_strRes.Remove(0, 1);
            }

            return v_strRes;
        }

        private static string Convert_Tieng_Viet_Co_Dau_To_Khong_Dau_Sub(string text)
        {
            //Ky tu dac biet

            for (int i = 32; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), "_");
            }
            text = text.Replace(".", "_");
            text = text.Replace(" ", "_");
            text = text.Replace(",", "_");
            text = text.Replace(";", "_");
            text = text.Replace(":", "_");
            text = text.Replace(">", "_");
            text = text.Replace("<", "_");
            text = text.Replace("(", "_");
            text = text.Replace(")", "_");
            text = text.Replace("?", "_");
            text = text.Replace("$", "_");
            text = text.Replace("&", "_");

            //'Dấu Ngang
            text = text.Replace("A", "A");
            text = text.Replace("a", "a");
            text = text.Replace("Ă", "A");
            text = text.Replace("ă", "a");
            text = text.Replace("Â", "A");
            text = text.Replace("â", "a");
            text = text.Replace("E", "E");
            text = text.Replace("e", "e");
            text = text.Replace("Ê", "E");
            text = text.Replace("ê", "e");
            text = text.Replace("I", "I");
            text = text.Replace("i", "i");
            text = text.Replace("O", "O");
            text = text.Replace("o", "o");
            text = text.Replace("Ô", "O");
            text = text.Replace("ô", "o");
            text = text.Replace("Ơ", "O");
            text = text.Replace("ơ", "o");
            text = text.Replace("U", "U");
            text = text.Replace("u", "u");
            text = text.Replace("Ư", "U");
            text = text.Replace("ư", "u");
            text = text.Replace("Y", "Y");
            text = text.Replace("y", "y");

            //    'Dấu Huyền
            text = text.Replace("À", "A");
            text = text.Replace("à", "a");
            text = text.Replace("Ằ", "A");
            text = text.Replace("ằ", "a");
            text = text.Replace("Ầ", "A");
            text = text.Replace("ầ", "a");
            text = text.Replace("È", "E");
            text = text.Replace("è", "e");
            text = text.Replace("Ề", "E");
            text = text.Replace("ề", "e");
            text = text.Replace("Ì", "I");
            text = text.Replace("ì", "i");
            text = text.Replace("Ò", "O");
            text = text.Replace("ò", "o");
            text = text.Replace("Ồ", "O");
            text = text.Replace("ồ", "o");
            text = text.Replace("Ờ", "O");
            text = text.Replace("ờ", "o");
            text = text.Replace("Ù", "U");
            text = text.Replace("ù", "u");
            text = text.Replace("Ừ", "U");
            text = text.Replace("ừ", "u");
            text = text.Replace("Ỳ", "Y");
            text = text.Replace("ỳ", "y");

            //'Dấu Sắc
            text = text.Replace("Á", "A");
            text = text.Replace("á", "a");
            text = text.Replace("Ắ", "A");
            text = text.Replace("ắ", "a");
            text = text.Replace("Ấ", "A");
            text = text.Replace("ấ", "a");
            text = text.Replace("É", "E");
            text = text.Replace("é", "e");
            text = text.Replace("Ế", "E");
            text = text.Replace("ế", "e");
            text = text.Replace("Í", "I");
            text = text.Replace("í", "i");
            text = text.Replace("Ó", "O");
            text = text.Replace("ó", "o");
            text = text.Replace("Ố", "O");
            text = text.Replace("ố", "o");
            text = text.Replace("Ớ", "O");
            text = text.Replace("ớ", "o");
            text = text.Replace("Ú", "U");
            text = text.Replace("ú", "u");
            text = text.Replace("Ứ", "U");
            text = text.Replace("ứ", "u");
            text = text.Replace("Ý", "Y");
            text = text.Replace("ý", "y");

            //'Dấu Hỏi
            text = text.Replace("Ả", "A");
            text = text.Replace("ả", "a");
            text = text.Replace("Ẳ", "A");
            text = text.Replace("ẳ", "a");
            text = text.Replace("Ẩ", "A");
            text = text.Replace("ẩ", "a");
            text = text.Replace("Ẻ", "E");
            text = text.Replace("ẻ", "e");
            text = text.Replace("Ể", "E");
            text = text.Replace("ể", "e");
            text = text.Replace("Ỉ", "I");
            text = text.Replace("ỉ", "i");
            text = text.Replace("Ỏ", "O");
            text = text.Replace("ỏ", "o");
            text = text.Replace("Ổ", "O");
            text = text.Replace("ổ", "o");
            text = text.Replace("Ở", "O");
            text = text.Replace("ở", "o");
            text = text.Replace("Ủ", "U");
            text = text.Replace("ủ", "u");
            text = text.Replace("Ử", "U");
            text = text.Replace("ử", "u");
            text = text.Replace("Ỷ", "Y");
            text = text.Replace("ỷ", "y");

            //'Dấu Ngã   
            text = text.Replace("Ã", "A");
            text = text.Replace("ã", "a");
            text = text.Replace("Ẵ", "A");
            text = text.Replace("ẵ", "a");
            text = text.Replace("Ẫ", "A");
            text = text.Replace("ẫ", "a");
            text = text.Replace("Ẽ", "E");
            text = text.Replace("ẽ", "e");
            text = text.Replace("Ễ", "E");
            text = text.Replace("ễ", "e");
            text = text.Replace("Ĩ", "I");
            text = text.Replace("ĩ", "i");
            text = text.Replace("Õ", "O");
            text = text.Replace("õ", "o");
            text = text.Replace("Ỗ", "O");
            text = text.Replace("ỗ", "o");
            text = text.Replace("Ỡ", "O");
            text = text.Replace("ỡ", "o");
            text = text.Replace("Ũ", "U");
            text = text.Replace("ũ", "u");
            text = text.Replace("Ữ", "U");
            text = text.Replace("ữ", "u");
            text = text.Replace("Ỹ", "Y");
            text = text.Replace("ỹ", "y");

            //'Dẫu Nặng
            text = text.Replace("Ạ", "A");
            text = text.Replace("ạ", "a");
            text = text.Replace("Ặ", "A");
            text = text.Replace("ặ", "a");
            text = text.Replace("Ậ", "A");
            text = text.Replace("ậ", "a");
            text = text.Replace("Ẹ", "E");
            text = text.Replace("ẹ", "e");
            text = text.Replace("Ệ", "E");
            text = text.Replace("ệ", "e");
            text = text.Replace("Ị", "I");
            text = text.Replace("ị", "i");
            text = text.Replace("Ọ", "O");
            text = text.Replace("ọ", "o");
            text = text.Replace("Ộ", "O");
            text = text.Replace("ộ", "o");
            text = text.Replace("Ợ", "O");
            text = text.Replace("ợ", "o");
            text = text.Replace("Ụ", "U");
            text = text.Replace("ụ", "u");
            text = text.Replace("Ự", "U");
            text = text.Replace("ự", "u");
            text = text.Replace("Ỵ", "Y");
            text = text.Replace("ỵ", "y");
            text = text.Replace("Đ", "D");
            text = text.Replace("đ", "d");

            foreach (char v_c in text)
            {
                if (!Is_Number_Char(v_c) && !Is_Character_Char(v_c))
                    text = text.Replace(v_c, '_');
            }

            string v_strRes = text.Replace("__", "_");

            return v_strRes;
        }

        private static bool Is_Number_Char(char v_c)
        {
            bool v_bRes = false;

            if (v_c >= 48 && v_c <= 57)
                v_bRes = true;

            return v_bRes;
        }

        private static bool Is_Character_Char(char v_c)
        {
            bool v_bRes = false;

            if (v_c >= 'A' && v_c <= 'Z')
                v_bRes = true;

            if (v_c >= 'a' && v_c <= 'z')
                v_bRes = true;

            return v_bRes;
        }

    }
}
