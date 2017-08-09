using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataPlayer;
using Utility;
using System.Data;

namespace Controller
{
    public class CNhan_Vien_Controller
    {
        private static CNhan_Vien_Controller Instance { get; set; }
        public static CNhan_Vien_Controller getInstance()
        {
            if (Instance == null)
                Instance = new CNhan_Vien_Controller();
            return Instance;
        }
        private void MapNhan_Vien(DataRow p_row, CNhan_Vien p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Ma_Nhan_Vien"))
                p_objDes.Ma_Nhan_Vien = CUtility.Convert_To_String(p_row["Ma_Nhan_Vien"]);

            if (p_dt.Columns.Contains("Ten_Nhan_Vien"))
                p_objDes.Ten_Nhan_Vien = CUtility.Convert_To_String(p_row["Ten_Nhan_Vien"]);

            if (p_dt.Columns.Contains("So_Dien_Thoai"))
                p_objDes.So_Dien_Thoai = CUtility.Convert_To_String(p_row["So_Dien_Thoai"]);

            if (p_dt.Columns.Contains("Dia_Chi"))
                p_objDes.Dia_Chi = CUtility.Convert_To_String(p_row["Dia_Chi"]);

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
        }

        public IList<CNhan_Vien> List_Nhan_Vien()
        {
            IList<CNhan_Vien> v_arrRes = new List<CNhan_Vien>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_List_Nhan_Vien");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CNhan_Vien v_objRes = new CNhan_Vien();
                    MapNhan_Vien(v_row, v_objRes);
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

        public CNhan_Vien Get_Nhan_Vien_By_ID(int p_iID)
        {
            CNhan_Vien v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_Get_Nhan_Vien_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CNhan_Vien();
                    MapNhan_Vien(v_dt.Rows[0], v_objRes);
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

        public int Insert_Nhan_Vien(CNhan_Vien p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strQuanLyCongNo_Conn_String, "sp_ins_Nhan_Vien",
                    p_objData.Ma_Nhan_Vien, p_objData.Ten_Nhan_Vien, p_objData.So_Dien_Thoai, p_objData.Dia_Chi, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_Nhan_Vien(CNhan_Vien p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_upd_Nhan_Vien", p_objData.Auto_ID,
                    p_objData.Ma_Nhan_Vien, p_objData.Ten_Nhan_Vien, p_objData.So_Dien_Thoai, p_objData.Dia_Chi, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_Nhan_Vien(int p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_del_Nhan_Vien", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
