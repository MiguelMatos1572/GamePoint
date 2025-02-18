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
        public Image Image { get; set; }
        public Category Category { get; set; }
    }
}
