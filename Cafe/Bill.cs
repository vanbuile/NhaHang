using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class Bill
    {
        private int id;
        private DateTime DateCheckIn;
        private DateTime DateCheckOut;
        private List<BillInfo> billInfos;
        private int idTable;
        private int status;
        private float totalPrice;
        private int discount;
        public Bill() { }

        public Bill(DataRow dr) 
        {
            this.id = (int)dr["id"];
            this.DateCheckIn = (DateTime)dr["DateCheckIn"];
            this.DateCheckOut = (DateTime)dr["DateCheckOut"];
            this.billInfos = BillInfoDAO.LoadBillInfos(this.id);
            this.idTable = (int)dr["idTable"];
            this.status = (int)dr["status"];
            this.discount = (int)dr["discount"];
            this.totalPrice = (float)dr["totalPrice"];
        }

        public int Id { get => id; set => id = value; }
        public DateTime DateCheckIn1 { get => DateCheckIn; set => DateCheckIn = value; }
        public DateTime DateCheckOut1 { get => DateCheckOut; set => DateCheckOut = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int Status { get => status; set => status = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int Discount { get => discount; set => discount = value; }
        internal List<BillInfo> BillInfos { get => billInfos; set => billInfos = value; }
    }
}
