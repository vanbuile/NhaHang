using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Cafe
{
    class FoodTableDAO
    {
        FoodTableDAO() { }
        public static List<FoodTable> LoadTableList() { 
            List<FoodTable> listFoodTable = new List<FoodTable>();

            DataTable data = DataProvider.ExecuteQuery("SELECT * FROM FoodTable");
            
            foreach (DataRow row in data.Rows)
            {
                FoodTable table = new FoodTable(row);
                listFoodTable.Add(table);
            }
            return listFoodTable;
        }
    }

}
