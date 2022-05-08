using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIRCMS.Shared.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
            ProductType = new List<string>() { "Lehenga", "Kurta", "Gown" };
        }
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductBrand { get; set; }
        public List<string> ProductType { get; set; }
    }


}
