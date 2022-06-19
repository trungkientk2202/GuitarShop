using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Models
{
    public class Role
    {
        public int id { set; get; }
        public string roleName { set; get; }

        public Role()
        {
        }

        public Role(int id, string roleName)
        {
            this.id = id;
            this.roleName = roleName;
        }
    }
}
