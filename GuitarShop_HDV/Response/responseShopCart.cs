using GuitarShop_HDV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Response
{
    public class responseShopCart
    {
        public string message { set; get; }
        public List<ShopCart> cartsData { set; get; }

        public responseShopCart()
        {
        }

        public responseShopCart(string message, List<ShopCart> cartsData)
        {
            this.message = message;
            this.cartsData = cartsData;
        }
    }
}
