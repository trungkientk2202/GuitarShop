using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Models
{
    public class ShopCart
    {
        public int id { set; get; }
        public int userID { set; get; }
        public int idGuitar { set; get; }

        public string guitarName { set; get; }
        public int quantity { set; get; }
        public double amount { set; get; }
        public DateTime created { set; get; }
        public Nullable<DateTime> updated { set; get; }

        public string image { set; get; }

        public string imageURL { set; get; }
        public bool isOrdered { set; get; }

        public ShopCart()
        {
        }

        public ShopCart(int id, int userID, int idGuitar, string guitarName, int quantity, double amount, DateTime created, DateTime? updated, string image, string imageURL, bool isOrdered)
        {
            this.id = id;
            this.userID = userID;
            this.idGuitar = idGuitar;
            this.guitarName = guitarName;
            this.quantity = quantity;
            this.amount = amount;
            this.created = created;
            this.updated = updated;
            this.image = image;
            this.imageURL = imageURL;
            this.isOrdered = isOrdered;
        }
    }
}
