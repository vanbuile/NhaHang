using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Cafe
{
    class FoodTable
    {
        private int id;
        private string name;
        private string empty;
        private Bill bill;
        public FoodTable() { }
        public FoodTable(int id, string name, string empty)
        {
            this.id = id;
            this.name = name;
            this.empty = empty;
        }
        public FoodTable(DataRow dataRow)
        {
            this.id = (int)dataRow["id"];
            this.empty = dataRow["empty"].ToString();
            this.name = dataRow["name"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Empty { get => empty; set => empty = value; }
        public Bill Bill { get => bill; set => bill = value; }
    }
}
