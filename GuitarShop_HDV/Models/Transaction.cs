using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Models
{
    public class Transaction
    {
        public int id { set; get; }
        public int userID { set; get; }
        public string customerName { set; get; }
        public string customerEmail { set; get; }
        public string customerPhone { set; get; }
        public string customerAddress { set; get; }
        public double amount { set; get; }
        public string message { set; get; }
        public DateTime created { set; get; }
        Nullable<DateTime> updated { set; get; }
        public bool status { set; get; }

        public string note { set; get; }
        public bool isCanceled { set; get; }

        public Transaction()
        {
        }

        public Transaction(int id, int userID, string customerName, string customerEmail, string customerPhone, string customerAddress, double amount, string message, DateTime created, DateTime? updated, bool status, string note, bool isCanceled)
        {
            this.id = id;
            this.userID = userID;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.customerPhone = customerPhone;
            this.customerAddress = customerAddress;
            this.amount = amount;
            this.message = message;
            this.created = created;
            this.updated = updated;
            this.status = status;
            this.note = note;
            this.isCanceled = isCanceled;
        }
    }
}
