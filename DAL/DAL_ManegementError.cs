using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_ManegementError
    {
        private static DP db = new DP();
        public static DataTable GetError(bool status)
        {
            string sql = "sp_GetError";
            DataTable tblErrors = null;
            db.addParam("TrangThai", status);

            tblErrors = db.queryExecuteAdapter(sql);
            return tblErrors;
        }
        public static int UpdateStatusError(int stt, bool status)
        {
            string sql = "sp_UpdateStatusError";
            db.addParam("STT", stt);
            db.addParam("TrangThai", status);

            DataTable result = db.queryExecuteAdapter(sql);
            int numOfRows = result.Rows.Count;
            return numOfRows;
        }
        public static int InsertError(string error, string location)
        {
            string sql = "sp_InsertError";
            db.addParam("TenLoi", error);
            db.addParam("ViTriLoi", location);

            DataTable result = db.queryExecuteAdapter(sql);
            int numOfRows = result.Rows.Count;
            return numOfRows;
        }
    }
}
