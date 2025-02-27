using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePoint.Shared.Models
{
    internal class StockModel
    {
        public int Id { get; set; }
        public string MovementType { get; set; }
        public DateTime MovementDate { get; set; }
        public int Quantity { get; set; }
        public ProductModel Product { get; set; }
    }
}
