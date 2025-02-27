using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePointDB.Entity
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        //public Product? Product { get; set; }
        public int? ProductId { get; set; }
    }
}
