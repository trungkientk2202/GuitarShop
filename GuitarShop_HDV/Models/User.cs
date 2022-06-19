using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Models
{
    public class User
    {
        public int id { set; get; }
        public string name { set; get; }
        public string email { set; get; }
        public string phone { set; get; }
        public string address { set; get; }

        public string password { set; get; }
        public DateTime created { set; get; }
        public Nullable<DateTime> updated { set; get; }
        public Boolean isDelete { set; get; }

        public int idRole { set; get; }

        public string roleName { set; get; }
        public User()
        {
        }

        public User(int id, string name, string email, string phone, string address, string password, DateTime created, DateTime? updated, bool isDelete, int idRole, string roleName)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.password = password;
            this.created = created;
            this.updated = updated;
            this.isDelete = isDelete;
            this.idRole = idRole;
            this.roleName = roleName;
        }
    }
}
