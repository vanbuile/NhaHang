using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Cafe
{
    class Food
    {
        private int id;
        private string name;
        private float price;
        private Category category;

        public Food() { }
        public Food(int id, string name, float price, Category category)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.category = category;
           
        }
        public Food(DataRow dr)
        {
            this.id = (int)dr["id"];
            this.name = dr["name"].ToString();
            this.price = (float)Convert.ToDouble(dr["price"].ToString());
            this.category = CategoryDAO.LoadCategory((int)dr["idCategory"]);
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public Category Category { get => category; set => category = value; }
    }
}
