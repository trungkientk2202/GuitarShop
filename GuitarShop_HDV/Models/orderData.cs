using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Models
{
    public class orderData
    {
        public int errCode { set; get; }
        public string message { set; get; }

        public orderData()
        {
        }

        public orderData(int errCode, string message)
        {
            this.errCode = errCode;
            this.message = message;
        }
    }
}
