using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePointDB.Entity
{
    public class Product : BaseEntity
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<Image>? Image { get; set; }
        public ICollection<Stock> Stock { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
