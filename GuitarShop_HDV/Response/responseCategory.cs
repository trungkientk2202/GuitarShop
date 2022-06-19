using GuitarShop_HDV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Response
{
    public class responseCategory
    {
        public string message { set; get; }
        public List<Category> categoryData { set; get; }

        public responseCategory()
        {
        }

        public responseCategory(string message, List<Category> categoryData)
        {
            this.message = message;
            this.categoryData = categoryData;
        }
    }
}
