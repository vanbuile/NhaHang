using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cafe
{
   class CategoryDAO
    {
        public CategoryDAO() { }
        public static Category LoadCategory(int idCategory)
        {
            DataTable dt= DataProvider.ExecuteQuery("SELECT * FROM Category WHERE id = "+idCategory.ToString());
            DataRow dr = dt.Rows[0];
            Category category = new Category(dr);
            return category;
        }

    }
}
