using GuitarShop_HDV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Response
{
    public class responseUser
    {
        public int errCode { set; get; }
        public String message { set; get; }
        public User user { set; get; }

        public List<User> data { set; get; }
        public responseUser()
        {
        }

        public responseUser(int errCode, string message, User user, List<User> data)
        {
            this.errCode = errCode;
            this.message = message;
            this.user = user;
            this.data = data;
        }

    }

}
