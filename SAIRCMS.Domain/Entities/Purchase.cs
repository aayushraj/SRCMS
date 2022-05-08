using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIRCMS.Domain.Entities
{
    public class Purchase:BaseEntity
    {
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
