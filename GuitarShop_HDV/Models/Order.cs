using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Models
{
    public class Order
    {
        public int id { set; get; }

        public int transactionID { set; get; }
        public int userID { set; get; }
        public string customerName { set; get; }
        public string customerEmail { set; get; }
        public string customerPhone { set; get; }
        public string customerAddress { set; get; }

        public string guitarName { set; get; }
        public int quantity { set; get; }
        public double amount { set; get; }

        public bool status { set; get; }
        public DateTime created { set; get; }
        public Nullable<DateTime> updated { set; get; }
        public bool isCanceled { set; get; }

        public Order()
        {
        }

        public Order(int id, int transactionID, int userID, string customerName, string customerEmail, string customerPhone, string customerAddress, string guitarName, int quantity, double amount, bool status, DateTime created, DateTime? updated, bool isCanceled)
        {
            this.id = id;
            this.transactionID = transactionID;
            this.userID = userID;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.customerPhone = customerPhone;
            this.customerAddress = customerAddress;
            this.guitarName = guitarName;
            this.quantity = quantity;
            this.amount = amount;
            this.status = status;
            this.created = created;
            this.updated = updated;
            this.isCanceled = isCanceled;
        }
    }
}
