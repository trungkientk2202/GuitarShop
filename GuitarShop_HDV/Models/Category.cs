using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Models
{
    public class Category
    {
        public int id { set; get; }
        public string name { set; get; }
        public Nullable<int> parent_id { set; get; }

        public Category()
        {
        }

        public Category(int id, string name, int parent_id)
        {
            this.id = id;
            this.name = name;
            this.parent_id = parent_id;
        }
    }
}
