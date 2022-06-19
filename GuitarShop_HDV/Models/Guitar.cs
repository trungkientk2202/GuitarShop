using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarShop_HDV.Models;

namespace GuitarShop_HDV.Models
{
    public class guitar
    {
        public int id { set; get; }
        public string name { set; get; }
        public double price { set; get; }
        public string contents { set; get; }
        public Nullable<int> discount { set; get; }

        public Nullable<int> views { set; get; }
        public DateTime created { set; get; }
        public Nullable<DateTime> updated { set; get; }
        public bool isDelete { set; get; }

        public string image { set; get; }

        public string imageURL { set; get; }
        public guitar()
        {
        }

        public guitar(int id, string name, double price, string contents, int? discount, int? views, DateTime created, DateTime? updated, bool isDelete, string image, string imageURL)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.contents = contents;
            this.discount = discount;
            this.views = views;
            this.created = created;
            this.updated = updated;
            this.isDelete = isDelete;
            this.image = image;
            this.imageURL = imageURL;
        }
    }
}
