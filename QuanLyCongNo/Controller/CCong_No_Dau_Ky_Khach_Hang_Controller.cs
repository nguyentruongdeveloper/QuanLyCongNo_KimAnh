using DataPlayer;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Utility;

namespace Controller
{
    public class CCong_No_Dau_Ky_Khach_Hang_Controller
    {
        private static CCong_No_Dau_Ky_Khach_Hang_Controller Instance { get; set; }
        public static CCong_No_Dau_Ky_Khach_Hang_Controller getInstance()
        {
            if (Instance == null)
                Instance = new CCong_No_Dau_Ky_Khach_Hang_Controller();
            return Instance;
        }
        private void MapCong_No_Dau_Ky_Khach_Hang(DataRow p_row, CCong_No_Dau_Ky_Khach_Hang p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Khach_Hang_ID"))
                p_objDes.Khach_Hang_ID = CUtility.Convert_To_Int32(p_row["Khach_Hang_ID"]);

            if (p_dt.Columns.Contains("Tien_No"))
                p_objDes.Tien_No = CUtility.Convert_To_Decimal(p_row["Tien_No"]);

            if (p_dt.Columns.Contains("Dien_Giai"))
                p_objDes.Dien_Giai = CUtility.Convert_To_String(p_row["Dien_Giai"]);

            if (p_dt.Columns.Contains("Deleted"))
                p_objDes.Deleted = CUtility.Convert_To_Bool(p_row["Deleted"]);

            if (p_dt.Columns.Contains("Created"))
                p_objDes.Created = CUtility.Convert_To_DateTime(p_row["Created"]);

            if (p_dt.Columns.Contains("Created_By"))
                p_objDes.Created_By = CUtility.Convert_To_String(p_row["Created_By"]);

            if (p_dt.Columns.Contains("Last_Updated"))
                p_objDes.Last_Updated = CUtility.Convert_To_DateTime(p_row["Last_Updated"]);

            if (p_dt.Columns.Contains("Last_Updated_By"))
                p_objDes.Last_Updated_By = CUtility.Convert_To_String(p_row["Last_Updated_By"]);

            if (p_dt.Columns.Contains("Ma_Khach_Hang"))
                p_objDes.Ma_Khach_Hang = CUtility.Convert_To_String(p_row["Ma_Khach_Hang"]);

            if (p_dt.Columns.Contains("Ten_Khach_Hang"))
                p_objDes.Ten_Khach_Hang = CUtility.Convert_To_String(p_row["Ten_Khach_Hang"]);
        }

        public IList<CCong_No_Dau_Ky_Khach_Hang> List_Cong_No_Dau_Ky_Khach_Hang()
        {
            IList<CCong_No_Dau_Ky_Khach_Hang> v_arrRes = new List<CCong_No_Dau_Ky_Khach_Hang>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_List_Cong_No_Dau_Ky_Khach_Hang");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CCong_No_Dau_Ky_Khach_Hang v_objRes = new CCong_No_Dau_Ky_Khach_Hang();
                    MapCong_No_Dau_Ky_Khach_Hang(v_row, v_objRes);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public CCong_No_Dau_Ky_Khach_Hang Get_Cong_No_Dau_Ky_Khach_Hang_By_ID(int p_iID)
        {
            CCong_No_Dau_Ky_Khach_Hang v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_Get_Cong_No_Dau_Ky_Khach_Hang_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CCong_No_Dau_Ky_Khach_Hang();
                    MapCong_No_Dau_Ky_Khach_Hang(v_dt.Rows[0], v_objRes);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_objRes;
        }

        public int Insert_Cong_No_Dau_Ky_Khach_Hang(CCong_No_Dau_Ky_Khach_Hang p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strQuanLyCongNo_Conn_String, "sp_ins_Cong_No_Dau_Ky_Khach_Hang",
                    p_objData.Khach_Hang_ID, p_objData.Tien_No, p_objData.Dien_Giai, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_Cong_No_Dau_Ky_Khach_Hang(CCong_No_Dau_Ky_Khach_Hang p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_upd_Cong_No_Dau_Ky_Khach_Hang", p_objData.Auto_ID,
                    p_objData.Khach_Hang_ID, p_objData.Tien_No, p_objData.Dien_Giai, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_Cong_No_Dau_Ky_Khach_Hang(int p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_del_Cong_No_Dau_Ky_Khach_Hang", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
