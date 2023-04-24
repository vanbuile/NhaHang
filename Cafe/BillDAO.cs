using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   

namespace Cafe
{
    class BillDAO
    {
        BillDAO() { }
        public static Bill LoadBill(int idTable)
        {
            DataTable dt = DataProvider.ExecuteQuery("SELECT * FROM Bill WHERE status = 'waiting' AND idTable = " + idTable.ToString());
            
            DataRow dr = dt.Rows[0];
            Bill bill = new Bill(dr);
            
            return bill;
        }
    }
}
