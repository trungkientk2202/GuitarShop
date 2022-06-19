using GuitarShop_HDV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Response
{
    public class responseOrder
    {
        public orderData orderData { set; get; }

        public List<Order> orderDatas { set; get; }
        public string message { set; get; }
        public responseOrder()
        {
        }

        public responseOrder(orderData orderData, List<Order> orderDatas, string message)
        {
            this.orderData = orderData;
            this.orderDatas = orderDatas;
            this.message = message;
        }
    }
}
