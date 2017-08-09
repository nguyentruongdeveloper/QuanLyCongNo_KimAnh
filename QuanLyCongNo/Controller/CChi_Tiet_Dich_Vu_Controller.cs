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
    public class CChi_Tiet_Dich_Vu_Controller
    {
        private static CChi_Tiet_Dich_Vu_Controller Instance { get; set; }
        public static CChi_Tiet_Dich_Vu_Controller getInstance()
        {
            if (Instance == null)
                Instance = new CChi_Tiet_Dich_Vu_Controller();
            return Instance;

        }
        private void MapChi_Tiet_Dich_Vu(DataRow p_row, CChi_Tiet_Dich_Vu p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int64(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Chung_Tu_ID"))
                p_objDes.Chung_Tu_ID = CUtility.Convert_To_Int64(p_row["Chung_Tu_ID"]);

            if (p_dt.Columns.Contains("Dich_Vu_ID"))
                p_objDes.Dich_Vu_ID = CUtility.Convert_To_Int32(p_row["Dich_Vu_ID"]);

            if (p_dt.Columns.Contains("Xe_ID"))
                p_objDes.Xe_ID = CUtility.Convert_To_Int32(p_row["Xe_ID"]);

            if (p_dt.Columns.Contains("So_Luong"))
                p_objDes.So_Luong = CUtility.Convert_To_Decimal ( p_row["So_Luong"]);

            if (p_dt.Columns.Contains("Don_Gia"))
                p_objDes.Don_Gia = CUtility.Convert_To_Decimal (p_row["Don_Gia"]);

            if (p_dt.Columns.Contains("Thanh_Tien"))
                p_objDes.Thanh_Tien = CUtility.Convert_To_Decimal
                    (p_row["Thanh_Tien"]);

            if (p_dt.Columns.Contains("Dia_Chi_Lay"))
                p_objDes.Dia_Chi_Lay = CUtility.Convert_To_String(p_row["Dia_Chi_Lay"]);

            if (p_dt.Columns.Contains("Dia_Chi_Do"))
                p_objDes.Dia_Chi_Do = CUtility.Convert_To_String(p_row["Dia_Chi_Do"]);

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

        public IList<CChi_Tiet_Dich_Vu> List_Chi_Tiet_Dich_Vu()
        {
            IList<CChi_Tiet_Dich_Vu> v_arrRes = new List<CChi_Tiet_Dich_Vu>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_List_Chi_Tiet_Dich_Vu");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CChi_Tiet_Dich_Vu v_objRes = new CChi_Tiet_Dich_Vu();
                    MapChi_Tiet_Dich_Vu(v_row, v_objRes);
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

        public CChi_Tiet_Dich_Vu Get_Chi_Tiet_Dich_Vu_By_ID(int p_iID)
        {
            CChi_Tiet_Dich_Vu v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strQuanLyCongNo_Conn_String, v_dt, "sp_sel_Get_Chi_Tiet_Dich_Vu_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CChi_Tiet_Dich_Vu();
                    MapChi_Tiet_Dich_Vu(v_dt.Rows[0], v_objRes);
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

        public int Insert_Chi_Tiet_Dich_Vu(CChi_Tiet_Dich_Vu p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strQuanLyCongNo_Conn_String, "sp_ins_Chi_Tiet_Dich_Vu",
                    p_objData.Chung_Tu_ID, p_objData.Dich_Vu_ID, p_objData.Xe_ID, p_objData.So_Luong, p_objData.Don_Gia, p_objData.Thanh_Tien, p_objData.Dia_Chi_Lay, p_objData.Dia_Chi_Do, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_Chi_Tiet_Dich_Vu(CChi_Tiet_Dich_Vu p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_upd_Chi_Tiet_Dich_Vu", p_objData.Auto_ID,
                    p_objData.Chung_Tu_ID, p_objData.Dich_Vu_ID, p_objData.Xe_ID, p_objData.So_Luong, p_objData.Don_Gia, p_objData.Thanh_Tien, p_objData.Dia_Chi_Lay, p_objData.Dia_Chi_Do, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_Chi_Tiet_Dich_Vu(int p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strQuanLyCongNo_Conn_String, "sp_del_Chi_Tiet_Dich_Vu", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
