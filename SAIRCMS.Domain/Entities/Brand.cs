using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIRCMS.Domain.Entities
{
    [Table("SRF_BRAND_INFO")]
    public class Brand : BaseEntity
    {
        [DisplayName("Brand Name")]
        public string BrandName { get; set; }
        public string BrandCode { get; set; }
        [IgnoreCase]
        public IList<Brand> List { get; set; }

    }
}
