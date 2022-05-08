using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAIRCMS.Domain.Entities
{
    [Table("SRF_CATEGORY_INFO")]
    public class Category:BaseEntity
    {
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [IgnoreCase]
        public IList<Category> List { get; set; }
    }
}