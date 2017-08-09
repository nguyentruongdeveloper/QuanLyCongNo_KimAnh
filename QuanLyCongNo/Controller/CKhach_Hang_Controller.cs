using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DataPlayer;
using Utility;

namespace QuanLyCongNo
{
    public class CKhach_Hang_Controller
    {
        private static CKhach_Hang_Controller Instance { get; set; }
        public static CKhach_Hang_Controller getInstance()
        {
            if (Instance == null)
                Instance = new CKhach_Hang_Controller();
            return Instance;
        }
        private void MapKhach_Hang(DataRow p_row, CKhach_Hang p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Ma_Khach_Hang"))
                p_objDes.Ma_Khach_Hang = CUtility.Convert_To_String(p_row["Ma_Khach_Hang"]);

            if (p_dt.Columns.Contains("Ten_Khach_Hang"))
                p_objDes.Ten_Khach_Hang = CUtility.Convert_To_String(p_row["Ten_Khach_Hang"]);

            if (p_dt.Columns.Contains("Dia_Chi"))
                p_objDes.Dia_Chi = CUtility.Convert_To_String(p_row["Dia_Chi"]);

            if (p_dt.Columns.Contains("So_Dien_Thoai"))
                p_objDes.So_Dien_Thoai = CUtility.Convert_To_String(p_row["So_Dien_Thoai"]);

            if (p_dt.Columns.Contains("Email"))
                p_objDes.Email = CUtility.Convert_To_String(p_row["Email"]);

            if (p_dt.Columns.Contains("Created"))
                p_objDes.Created = CUtility.Convert_To_DateTime(p_row["Created"]);

            if (p_dt.Columns.Contains("Created_By"))
                p_objDes.Created_By = CUtility.Convert_To_String(p_row["Created_By"]);

            if (p_dt.Columns.Contains("Last_Updated"))
                p_objDes.Last_Updated = CUtility.Convert_To_DateTime(p_row["Last_Updated"]);

            if (p_dt.Columns.Contains("Last_Updated_By"))
                p_objDes.Last_Updated_By = CUtility.Convert_To_String(p_row["Last_Updated_By"]);

            if (p_dt.Columns.Contains("Deleted"))
                p_objDes.Deleted = CUtility.Convert_To_Bool(p_row["Deleted"]);

            if (p_dt.Columns.Contains("Ma_So_Thue"))
                p_objDes.Ma_So_Thue = CUtility.Convert_To_String(p_row["Ma_So_Thue"]);
        }

        public IList<CKhach_Hang> List_Khach_Hang()
        {
            IList<CKhach_Hang> v_arrRes = new List<CKhach_Hang>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_List_Khach_Hang");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CKhach_Hang v_objRes = new CKhach_Hang();
                    MapKhach_Hang(v_row, v_objRes);
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

        public CKhach_Hang Get_Khach_Hang_By_ID(int p_iID)
        {
            CKhach_Hang v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_Get_Khach_Hang_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CKhach_Hang();
                    MapKhach_Hang(v_dt.Rows[0], v_objRes);
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

        public int Insert_Khach_Hang(CKhach_Hang p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strQuanLyCongNo_Conn_String, "sp_ins_Khach_Hang",
                    p_objData.Ma_Khach_Hang, p_objData.Ten_Khach_Hang, p_objData.Dia_Chi, p_objData.So_Dien_Thoai, p_objData.Email, p_objData.Last_Updated_By, p_objData.Ma_So_Thue));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_Khach_Hang(CKhach_Hang p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_upd_Khach_Hang", p_objData.Auto_ID,
                    p_objData.Ma_Khach_Hang, p_objData.Ten_Khach_Hang, p_objData.Dia_Chi, p_objData.So_Dien_Thoai, p_objData.Email, p_objData.Last_Updated_By, p_objData.Ma_So_Thue);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_Khach_Hang(int p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_del_Khach_Hang", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}