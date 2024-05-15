using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public static class BLL_ManagementError
    {
        public static DataTable GetError(bool status)
        {
            return DAL_ManegementError.GetError(status);
        }
        public static int UpdateStatusError(int stt, bool status)
        {
            return DAL_ManegementError.UpdateStatusError(stt, status);
        }
        public static int InsertError(string error, string location)
        {
            return DAL_ManegementError.InsertError(error, location);
        }
    }
}
