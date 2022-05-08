namespace SAIRCMS.Domain.Entities
{
    public class Supplier:BaseEntity
    {
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string PAN { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public long Contact { get; set; }
    }
}