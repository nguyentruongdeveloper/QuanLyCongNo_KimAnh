

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using Utility;

namespace DTO
{
    public class CCong_No_Dau_Ky_Khach_Hang
    {
        private int m_intAuto_ID;
        private int m_intKhach_Hang_ID;
        private decimal m_dcTien_No;
		private string m_strDien_Giai;
        private bool m_blnDeleted;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strMa_Khach_Hang;
        private string m_strTen_Khach_Hang;

        public string Ten_Khach_Hang
        {
            get { return m_strTen_Khach_Hang; }
            set { m_strTen_Khach_Hang = value; }
        }


        public string Ma_Khach_Hang
        {
            get { return m_strMa_Khach_Hang; }
            set { m_strMa_Khach_Hang = value; }
        }


        public CCong_No_Dau_Ky_Khach_Hang()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_intAuto_ID = CConst.INT_VALUE_NULL;
            m_intKhach_Hang_ID = CConst.INT_VALUE_NULL;
            m_dcTien_No = CConst.DC_VALUE_NULL;
            m_strDien_Giai = CConst.STR_VALUE_NULL;
            m_blnDeleted = CConst.BL_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
        }

        public int Auto_ID
        {
            get
            {
                return m_intAuto_ID;
            }
            set
            {
                m_intAuto_ID = value;
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

        public decimal Tien_No
        {
            get
            {
                return m_dcTien_No;
            }
            set
            {
                m_dcTien_No = value;
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
    }
}