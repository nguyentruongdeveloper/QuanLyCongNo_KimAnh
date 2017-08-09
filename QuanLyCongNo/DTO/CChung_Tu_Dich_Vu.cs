using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DTO
{
    public class CChung_Tu_Dich_Vu
    {
        private long m_lngAuto_ID;
        private int m_intKhach_Hang_ID;
        private int m_intNhan_Vien_ID;
        private string m_strDien_Giai;
        private decimal m_dcTongTien;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private bool m_blnDeleted;

        public CChung_Tu_Dich_Vu()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_intKhach_Hang_ID = CConst.INT_VALUE_NULL;
            m_intNhan_Vien_ID = CConst.INT_VALUE_NULL;
            m_strDien_Giai = CConst.STR_VALUE_NULL;
            m_dcTongTien = CConst.DC_VALUE_NULL;
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

        public int Khach_Hang_ID
        {
            get
            {
                return m_intKhach_Hang_ID;
            }
            set
            {
                m_intKhach_Hang_ID = value;
            }
        }

        public int Nhan_Vien_ID
        {
            get
            {
                return m_intNhan_Vien_ID;
            }
            set
            {
                m_intNhan_Vien_ID = value;
            }
        }

        public string Dien_Giai
        {
            get
            {
                return m_strDien_Giai;
            }
            set
            {
                m_strDien_Giai = value.Trim();
            }
        }

        public decimal TongTien
        {
            get
            {
                return m_dcTongTien;
            }
            set
            {
                m_dcTongTien = value;
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
