using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Models
{
    public class transactionData
    {
        public int transactionID { set; get; }
        public int errCode { set; get; }
        public string message { set; get; }

        public transactionData()
        {
        }

        public transactionData(int transactionID, int errCode, string message)
        {
            this.transactionID = transactionID;
            this.errCode = errCode;
            this.message = message;
        }
    }
}
