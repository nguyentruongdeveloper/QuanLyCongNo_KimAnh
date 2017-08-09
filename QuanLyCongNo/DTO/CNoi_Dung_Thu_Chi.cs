using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DTO
{
    public class CNoi_Dung_Thu_Chi
    {
        private int m_intAuto_ID;
        private int m_intLoai_Thu_Chi_ID;
        private string m_strNoi_Dung;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private bool m_blnDeleted;
        private string m_strTen_Loai;

        public string Ten_Loai
        {
            get { return m_strTen_Loai; }
            set { m_strTen_Loai = value; }
        }


        public CNoi_Dung_Thu_Chi()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_intAuto_ID = CConst.INT_VALUE_NULL;
            m_intLoai_Thu_Chi_ID = CConst.INT_VALUE_NULL;
            m_strNoi_Dung = CConst.STR_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_blnDeleted = CConst.BL_VALUE_NULL;
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

        public int Loai_Thu_Chi_ID
        {
            get
            {
                return m_intLoai_Thu_Chi_ID;
            }
            set
            {
                m_intLoai_Thu_Chi_ID = value;
            }
        }

        public string Noi_Dung
        {
            get
            {
                return m_strNoi_Dung;
            }
            set
            {
                m_strNoi_Dung = value.Trim();
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
