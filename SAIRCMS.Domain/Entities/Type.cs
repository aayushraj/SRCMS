using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIRCMS.Domain.Entities
{
    [Table("SRF_TYPE_INFO")]
    public class Type:BaseEntity
    {
        public string Name { get; set; }
        [IgnoreCase]
        public IList<Type> List { get; set; }
    }
}
