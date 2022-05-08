using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SAIRCMS.Domain.Entities.Attributes;

namespace SAIRCMS.Domain.Entities
{
    [Table("SRF_PRODUCT_INFO")]
    public class Product:BaseEntity
    {
        private string productName;
        private string brandName;
        private string categoryName;
        public string Name { get => productName; set => productName = $"{categoryName} - {brandName}"; }
        [CascadingType]
        public Brand Brand { get; set; }
        [CascadingType]
        public Category Category { get; set; }
        [CascadingType]
        public Type Type { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        [IgnoreCase]
        public IList<Product> List { get; set; }
    }
    
}
