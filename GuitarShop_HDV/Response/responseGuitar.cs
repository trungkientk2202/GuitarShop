using GuitarShop_HDV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Response
{
    public class responseGuitar
    {
        public String mess { set; get; }
        public List<guitar> data { set; get; }

        public int errCode { set; get; }
        public responseGuitar()
        {
        }

        public responseGuitar(string mess, List<guitar> data, int errCode)
        {
            this.mess = mess;
            this.data = data;
            this.errCode = errCode;
        }
    }
}
