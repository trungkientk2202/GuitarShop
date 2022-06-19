using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Models
{
    public class PurchaseHistory
    {
        public int id { set; get; }
        public int transactionID { set; get; }
        public int idGuitar { set; get; }
        public int quantity { set; get; }
        public double amount { set; get; }
        public DateTime created { set; get; }

        
        public Nullable<DateTime> updated { set; get; }
        public bool status { set; get; }
        public bool isCanceled { set; get; }
        public string name { set; get; }
        public bool UserCanceled { set; get; }

        public PurchaseHistory()
        {
        }

        public PurchaseHistory(int id, int transactionID, int idGuitar, int quantity, double amount, DateTime created, string name, DateTime? updated, bool status, bool isCanceled, bool userCanceled)
        {
            this.id = id;
            this.transactionID = transactionID;
            this.idGuitar = idGuitar;
            this.quantity = quantity;
            this.amount = amount;
            this.created = created;
            this.name = name;
            this.updated = updated;
            this.status = status;
            this.isCanceled = isCanceled;
            UserCanceled = userCanceled;
        }
    }
}
