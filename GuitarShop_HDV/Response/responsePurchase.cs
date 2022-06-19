using GuitarShop_HDV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Response
{
    public class responsePurchase
    {

        public string message { set; get; }
        public List<PurchaseHistory> orderData { set; get; }
        public responsePurchase()
        {
        }

        public responsePurchase(string message, List<PurchaseHistory> orderData)
        {
            this.message = message;
            this.orderData = orderData;
        }
    }
}
