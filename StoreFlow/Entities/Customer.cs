namespace StoreFlow.Entities
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerCountry { get; set; }
        public string? CustomerRegion { get; set; }
        public string? CustomerPostalCode { get; set; }
        public bool? IsActive { get; set; }
        public string? ImageUrl { get; set; }




    }
}
