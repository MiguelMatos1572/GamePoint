using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePointDB.Entity
{
    public  class Stock
    {
        public int Id { get; set; }
        public string MovementType { get; set; }
        public DateTime MovementDate { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
