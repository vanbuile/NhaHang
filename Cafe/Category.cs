using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Cafe
{
    class Category

    {
        private int id;
        private string name;

        public Category() { }
        
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Category(DataRow dr)
        {
            this.id = (int)dr["id"];
            this.name = dr["name"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
