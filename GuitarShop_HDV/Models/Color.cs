using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Models
{
    public class Color
    {
        public int id { set; get; }
        public string name { set; get; }

        public Color()
        {
        }

        public Color(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
