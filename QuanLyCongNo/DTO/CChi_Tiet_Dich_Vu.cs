using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using Utility;

namespace DTO
{
    public class CChi_Tiet_Dich_Vu
    {
        private long m_lngAuto_ID;
        private long m_lngChung_Tu_ID;
        private int m_intDich_Vu_ID;
        private int m_intXe_ID;
        private decimal m_dcSo_Luong;
        private decimal m_dcDon_Gia;
        private decimal m_dcThanh_Tien;
        private string m_strDia_Chi_Lay;
        private string m_strDia_Chi_Do;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private bool m_blnDeleted;

        public CChi_Tiet_Dich_Vu()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_lngChung_Tu_ID = CConst.INT_VALUE_NULL;
            m_intDich_Vu_ID = CConst.INT_VALUE_NULL;
            m_intXe_ID = CConst.INT_VALUE_NULL;
            m_dcSo_Luong = CConst.DC_VALUE_NULL;
            m_dcDon_Gia = CConst.DC_VALUE_NULL;
            m_dcThanh_Tien = CConst.DC_VALUE_NULL;
            m_strDia_Chi_Lay = CConst.STR_VALUE_NULL;
            m_strDia_Chi_Do = CConst.STR_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_blnDeleted = CConst.BL_VALUE_NULL;
        }

        public long Auto_ID
        {
            get
            {
                return m_lngAuto_ID;
            }
            set
            {
                m_lngAuto_ID = value;
            }
        }

        public long Chung_Tu_ID
        {
            get
            {
                return m_lngChung_Tu_ID;
            }
            set
            {
                m_lngChung_Tu_ID = value;
            }
        }

        public int Dich_Vu_ID
        {
            get
            {
                return m_intDich_Vu_ID;
            }
            set
            {
                m_intDich_Vu_ID = value;
            }
        }

        public int Xe_ID
        {
            get
            {
                return m_intXe_ID;
            }
            set
            {
                m_intXe_ID = value;
            }
        }

        public decimal So_Luong
        {
            get
            {
                return m_dcSo_Luong;
            }
            set
            {
                m_dcSo_Luong = value;
            }
        }

        public decimal Don_Gia
        {
            get
            {
                return m_dcDon_Gia;
            }
            set
            {
                m_dcDon_Gia = value;
            }
        }

        public decimal Thanh_Tien
        {
            get
            {
                return m_dcThanh_Tien;
            }
            set
            {
                m_dcThanh_Tien = value;
            }
        }

        public string Dia_Chi_Lay
        {
            get
            {
                return m_strDia_Chi_Lay;
            }
            set
            {
                m_strDia_Chi_Lay = value.Trim();
            }
        }

        public string Dia_Chi_Do
        {
            get
            {
                return m_strDia_Chi_Do;
            }
            set
            {
                m_strDia_Chi_Do = value.Trim();
            }
        }

        public DateTime Created
        {
            get
            {
                return m_dtmCreated;
            }
            set
            {
                m_dtmCreated = value;
            }
        }

        public string Created_By
        {
            get
            {
                return m_strCreated_By;
            }
            set
            {
                m_strCreated_By = value.Trim();
            }
        }

        public DateTime Last_Updated
        {
            get
            {
                return m_dtmLast_Updated;
            }
            set
            {
                m_dtmLast_Updated = value;
            }
        }

        public string Last_Updated_By
        {
            get
            {
                return m_strLast_Updated_By;
            }
            set
            {
                m_strLast_Updated_By = value.Trim();
            }
        }

        public bool Deleted
        {
            get
            {
                return m_blnDeleted;
            }
            set
            {
                m_blnDeleted = value;
            }
        }
    }
}