using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIRCMS.Domain
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
            CreatedBy = "aayush";
            ModifiedBy = "aayush";

        }
        [Key]
        public int Id { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        [IgnoreCase]
        public string SuccessMessage { get; set; }
        [IgnoreCase]
        public string FailureMessage { get; set; }
        [IgnoreCase]
        public bool IsSuccess { get; set; }
        public bool Status { get; set; }

    }
}
