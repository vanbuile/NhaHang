using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class BillInfoDAO
    {
        public  BillInfoDAO() { }
        public static List<BillInfo> LoadBillInfos(int idBill) 
        {
            List<BillInfo> billInfos = new List<BillInfo>();
            DataTable dt = DataProvider.ExecuteQuery("SELECT * FROM BillInfo WHERE idBill = "+idBill.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                BillInfo billInfo = new BillInfo(dr);
                billInfos.Add(billInfo);
            }
            return billInfos;
        }
    }
}
