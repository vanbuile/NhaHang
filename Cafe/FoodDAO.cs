using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class FoodDAO
    {
        public  FoodDAO() { }
        public static Food LoadFood(int idFood) 
        {
            Food food = new Food();
            DataTable dt = DataProvider.ExecuteQuery("SELECT * FROM Food WHERE id = " +idFood.ToString());
            DataRow dr = dt.Rows[0];
            food.Id = (int)dr["id"];
            food.Name = dr["name"].ToString();
            food.Price = (float)dr["price"];
            return food;
        }
    }
    
}
