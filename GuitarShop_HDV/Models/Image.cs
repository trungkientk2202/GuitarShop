using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop_HDV.Models
{
    public class Image
    {
        public int id { set; get; }
        public string image { set; get; }
        public string imgDetail { set; get; }

        public int idGuitar { set; get; }
        public bool idDeleted { set; get; }

        public Image()
        {
        }

        public Image(int id, string image, string imgDetail, int idGuitar, bool idDeleted)
        {
            this.id = id;
            this.image = image;
            this.imgDetail = imgDetail;
            this.idGuitar = idGuitar;
            this.idDeleted = idDeleted;
        }
    }
}
