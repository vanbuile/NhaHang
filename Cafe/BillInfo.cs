using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
   class BillInfo
    {
        private string name;
        private int count;
        private float price;
        private Food food;
        public BillInfo() { }
        public BillInfo(string name, int count, float price, int idFood)
        {
            this.name = name;
            this.count = count;
            this.price = price;
            this.food = FoodDAO.LoadFood(idFood);
        }
        public BillInfo(DataRow dr)
        {
            this.name = dr["name"].ToString();
            this.count = (int)dr["count"];
            this.price = (float)Convert.ToDouble(dr["price"].ToString());
            this.food = FoodDAO.LoadFood((int)dr["idFood"]);
        }

        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }

        public float getTotal()
        {
            return this.count*this.price;
        }
    }
}
