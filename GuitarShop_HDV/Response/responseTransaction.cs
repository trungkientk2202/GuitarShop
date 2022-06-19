using GuitarShop_HDV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Response
{
    public class responseTransaction
    {
        public transactionData transactionData { set; get; }

        public responseTransaction()
        {
        }

        public responseTransaction(transactionData transactionData)
        {
            this.transactionData = transactionData;
        }
    }
}
